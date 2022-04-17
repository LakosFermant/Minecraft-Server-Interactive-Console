using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO.Pipes;

namespace Minecraft_Server_Interactive_Console
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //I have these two here declared at the top so that other functions can use them
        //Changing the functions from private to public had no effect, so I moved them here for public access
        OpenFileDialog openBat = new OpenFileDialog();
        OpenFileDialog openConfig = new OpenFileDialog();

        //Some fancy helpers to run an application within the windows forms
        [DllImport("user32.dll")] static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll")] static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")] static extern bool MoveWindow(IntPtr Handle, int x, int y, int w, int h, bool repaint);
        [DllImport("user32.dll")] private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")] public static extern int FindWindow(string lpClassName, String lpWindowName);
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)] static extern uint RegisterWindowMessage(string lpString);

        //This one helps copy and paste text from the textbox into cmd
        [DllImport("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        NamedPipeClientStream cmdPipe = new NamedPipeClientStream(".", "ServerWindow", PipeDirection.In, PipeOptions.Asynchronous);

        //These are here just for reference, they will never have a click function
        public void DirectoryLoc_Click(object sender, EventArgs e)
        {
            
        }

        private void BatFileLoc_Click(object sender, EventArgs e)
        {
            
        }

        private void ConfigFileLoc_Click(object sender, EventArgs e)
        {
            
        }

        //This will open a file dialog window for finding the server
        public void FindServerBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog findServer = new FolderBrowserDialog();

            if (findServer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                directoryLoc.Text = findServer.SelectedPath;
            }
        }

        //This will open a file dialog window for finding the bat file for the MC Server
        public void FindBatBtn_Click(object sender, EventArgs e)
        {
            
            openBat.Filter = "Bat Files|*.bat";

            if (openBat.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                batFileLoc.Text = openBat.FileName;
            }
        }

        //This will open a file dialog window for finding the config file for the MC Server
        public void FindConfigBtn_Click(object sender, EventArgs e)
        {
            
            openConfig.Filter = "Text Files|*.txt|JSON Files|*.json|Properties Files|*.properties";

            if (openConfig.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                configFileLoc.Text = openConfig.FileName;
            }
        }

        //This will start the MC server
        public void StartBtn_Click(object sender, EventArgs e)
        {
            

            if (batFileLoc.Text == "<null>" || directoryLoc.Text == "<null>")
            {
                MessageBox.Show("Please make sure you have a bat file and server directory selected.");
            }

            else
            {
                
                ProcessStartInfo serverStarter = new ProcessStartInfo(openBat.FileName);
                serverStarter.WorkingDirectory = directoryLoc.Text;
                cmdhost = Process.Start(serverStarter);
                cmdPipe.Connect();
                //serverWindow = cmdhost.MainWindowHandle;

                Thread.Sleep(500);
                
                //SetParent(serverWindow, consoleOutput.Handle);
                //ShowWindowAsync(serverWindow, 3);
            }
            
        }

        //This will stop the MC server
        public void StopBtn_Click(object sender, EventArgs e)
        {
            uint id = RegisterWindowMessage("stop");
           //IntPtr WindowToFind = FindWindow(null, "Minecraft Server");
            //Debug.Assert(WindowToFind != IntPtr.Zero);
            //SendMessage(WindowToFind, id, IntPtr.Zero, IntPtr.Zero);
            //SendMessage(serverWindow, "stop");
        }

        //This will open the config file for the MC server
        private void ConfigBtn_Click(object sender, EventArgs e)
        {
            if (configFileLoc.Text == "<null>")
            {
                MessageBox.Show("No config file was selected. Please select a config file first.");
            }

            else
            {
                Process.Start(openConfig.FileName);
            }
            
        }

        //This will send text to the MC window
        public void ConsoleInput_TextChanged(object sender, EventArgs e)
        {
            //SendMessage(serverWindow, consoleInput.Text);
        }

        private void ConsoleOutput_Paint(object sender, PaintEventArgs e)
        {

        }

        //This will close the application
        private void QuitButton_Click(object sender, EventArgs e)
        {
            //Quit Application
            Application.Exit();
        }

        private void Cmdhost_Exited(object sender, EventArgs e)
        {

        }
    }
}
