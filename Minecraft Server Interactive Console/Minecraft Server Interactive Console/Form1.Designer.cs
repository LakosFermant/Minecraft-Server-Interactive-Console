namespace Minecraft_Server_Interactive_Console
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.directLabel = new System.Windows.Forms.Label();
            this.batFileLabel = new System.Windows.Forms.Label();
            this.configFileLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.configBtn = new System.Windows.Forms.Button();
            this.directoryLoc = new System.Windows.Forms.Label();
            this.batFileLoc = new System.Windows.Forms.Label();
            this.configFileLoc = new System.Windows.Forms.Label();
            this.consoleInput = new System.Windows.Forms.TextBox();
            this.findServerBtn = new System.Windows.Forms.Button();
            this.findBatBtn = new System.Windows.Forms.Button();
            this.findConfigBtn = new System.Windows.Forms.Button();
            this.consoleOutput = new System.Windows.Forms.Panel();
            this.quitButton = new System.Windows.Forms.Button();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.cmdhost = new System.Diagnostics.Process();
            this.SuspendLayout();
            // 
            // directLabel
            // 
            this.directLabel.AutoSize = true;
            this.directLabel.Location = new System.Drawing.Point(13, 13);
            this.directLabel.Name = "directLabel";
            this.directLabel.Size = new System.Drawing.Size(86, 13);
            this.directLabel.TabIndex = 0;
            this.directLabel.Text = "Server Directory:";
            // 
            // batFileLabel
            // 
            this.batFileLabel.AutoSize = true;
            this.batFileLabel.Location = new System.Drawing.Point(12, 41);
            this.batFileLabel.Name = "batFileLabel";
            this.batFileLabel.Size = new System.Drawing.Size(79, 13);
            this.batFileLabel.TabIndex = 1;
            this.batFileLabel.Text = "Server Bat File:";
            // 
            // configFileLabel
            // 
            this.configFileLabel.AutoSize = true;
            this.configFileLabel.Location = new System.Drawing.Point(12, 74);
            this.configFileLabel.Name = "configFileLabel";
            this.configFileLabel.Size = new System.Drawing.Size(93, 13);
            this.configFileLabel.TabIndex = 2;
            this.configFileLabel.Text = "Server Config File:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 108);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(79, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Server Output: ";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 149);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(119, 23);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start Server";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(12, 178);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(119, 23);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.Text = "Stop Server";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // configBtn
            // 
            this.configBtn.Location = new System.Drawing.Point(12, 207);
            this.configBtn.Name = "configBtn";
            this.configBtn.Size = new System.Drawing.Size(119, 23);
            this.configBtn.TabIndex = 6;
            this.configBtn.Text = "Open Config";
            this.configBtn.UseVisualStyleBackColor = true;
            this.configBtn.Click += new System.EventHandler(this.ConfigBtn_Click);
            // 
            // directoryLoc
            // 
            this.directoryLoc.AutoSize = true;
            this.directoryLoc.Location = new System.Drawing.Point(134, 13);
            this.directoryLoc.Name = "directoryLoc";
            this.directoryLoc.Size = new System.Drawing.Size(35, 13);
            this.directoryLoc.TabIndex = 7;
            this.directoryLoc.Text = "<null>";
            this.directoryLoc.Click += new System.EventHandler(this.DirectoryLoc_Click);
            // 
            // batFileLoc
            // 
            this.batFileLoc.AutoSize = true;
            this.batFileLoc.Location = new System.Drawing.Point(134, 41);
            this.batFileLoc.Name = "batFileLoc";
            this.batFileLoc.Size = new System.Drawing.Size(35, 13);
            this.batFileLoc.TabIndex = 8;
            this.batFileLoc.Text = "<null>";
            this.batFileLoc.Click += new System.EventHandler(this.BatFileLoc_Click);
            // 
            // configFileLoc
            // 
            this.configFileLoc.AutoSize = true;
            this.configFileLoc.Location = new System.Drawing.Point(134, 74);
            this.configFileLoc.Name = "configFileLoc";
            this.configFileLoc.Size = new System.Drawing.Size(35, 13);
            this.configFileLoc.TabIndex = 9;
            this.configFileLoc.Text = "<null>";
            this.configFileLoc.Click += new System.EventHandler(this.ConfigFileLoc_Click);
            // 
            // consoleInput
            // 
            this.consoleInput.AllowDrop = true;
            this.consoleInput.Location = new System.Drawing.Point(137, 481);
            this.consoleInput.Name = "consoleInput";
            this.consoleInput.Size = new System.Drawing.Size(952, 20);
            this.consoleInput.TabIndex = 12;
            this.consoleInput.TextChanged += new System.EventHandler(this.ConsoleInput_TextChanged);
            // 
            // findServerBtn
            // 
            this.findServerBtn.AutoSize = true;
            this.findServerBtn.Location = new System.Drawing.Point(955, 13);
            this.findServerBtn.Name = "findServerBtn";
            this.findServerBtn.Size = new System.Drawing.Size(134, 23);
            this.findServerBtn.TabIndex = 14;
            this.findServerBtn.Text = "Find Directory";
            this.findServerBtn.UseVisualStyleBackColor = true;
            this.findServerBtn.Click += new System.EventHandler(this.FindServerBtn_Click);
            // 
            // findBatBtn
            // 
            this.findBatBtn.AutoSize = true;
            this.findBatBtn.Location = new System.Drawing.Point(955, 41);
            this.findBatBtn.Name = "findBatBtn";
            this.findBatBtn.Size = new System.Drawing.Size(134, 23);
            this.findBatBtn.TabIndex = 15;
            this.findBatBtn.Text = "Find Bat File";
            this.findBatBtn.UseVisualStyleBackColor = true;
            this.findBatBtn.Click += new System.EventHandler(this.FindBatBtn_Click);
            // 
            // findConfigBtn
            // 
            this.findConfigBtn.AutoSize = true;
            this.findConfigBtn.Location = new System.Drawing.Point(955, 70);
            this.findConfigBtn.Name = "findConfigBtn";
            this.findConfigBtn.Size = new System.Drawing.Size(134, 23);
            this.findConfigBtn.TabIndex = 16;
            this.findConfigBtn.Text = "Find Config File";
            this.findConfigBtn.UseVisualStyleBackColor = true;
            this.findConfigBtn.Click += new System.EventHandler(this.FindConfigBtn_Click);
            // 
            // consoleOutput
            // 
            this.consoleOutput.Location = new System.Drawing.Point(137, 108);
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.Size = new System.Drawing.Size(952, 367);
            this.consoleOutput.TabIndex = 17;
            this.consoleOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.ConsoleOutput_Paint);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(12, 237);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(119, 23);
            this.quitButton.TabIndex = 18;
            this.quitButton.Text = "Quit Application";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Location = new System.Drawing.Point(28, 484);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(103, 13);
            this.consoleLabel.TabIndex = 19;
            this.consoleLabel.Text = "Console Commands:";
            // 
            // cmdhost
            // 
            this.cmdhost.StartInfo.Domain = "";
            this.cmdhost.StartInfo.LoadUserProfile = false;
            this.cmdhost.StartInfo.Password = null;
            this.cmdhost.StartInfo.StandardErrorEncoding = null;
            this.cmdhost.StartInfo.StandardOutputEncoding = null;
            this.cmdhost.StartInfo.UserName = "";
            this.cmdhost.SynchronizingObject = this;
            this.cmdhost.Exited += new System.EventHandler(this.Cmdhost_Exited);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 530);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.findConfigBtn);
            this.Controls.Add(this.findBatBtn);
            this.Controls.Add(this.findServerBtn);
            this.Controls.Add(this.consoleInput);
            this.Controls.Add(this.configFileLoc);
            this.Controls.Add(this.batFileLoc);
            this.Controls.Add(this.directoryLoc);
            this.Controls.Add(this.configBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.configFileLabel);
            this.Controls.Add(this.batFileLabel);
            this.Controls.Add(this.directLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "M.S.I.C 1.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label directLabel;
        private System.Windows.Forms.Label batFileLabel;
        private System.Windows.Forms.Label configFileLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button configBtn;
        private System.Windows.Forms.Label directoryLoc;
        private System.Windows.Forms.Label batFileLoc;
        private System.Windows.Forms.Label configFileLoc;
        private System.Windows.Forms.TextBox consoleInput;
        private System.Windows.Forms.Button findServerBtn;
        private System.Windows.Forms.Button findBatBtn;
        private System.Windows.Forms.Button findConfigBtn;
        private System.Windows.Forms.Panel consoleOutput;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label consoleLabel;
        private System.Diagnostics.Process cmdhost;
    }
}

