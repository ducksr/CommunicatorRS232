namespace RS232_Communicator
{
    partial class SerialPortSettings
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
            gbBundRate = new GroupBox();
            rb115200baundrate = new RadioButton();
            rb57600baundrate = new RadioButton();
            rb38400baundrate = new RadioButton();
            rb19200baundrate = new RadioButton();
            rb9600baundrate = new RadioButton();
            rb4800baundrate = new RadioButton();
            rb2400baundrate = new RadioButton();
            rb1200baundrate = new RadioButton();
            rb600baundrate = new RadioButton();
            rb300baundrate = new RadioButton();
            rb110baundrate = new RadioButton();
            gbDataBits = new GroupBox();
            rb8databits = new RadioButton();
            rb7databits = new RadioButton();
            gbStopBits = new GroupBox();
            rb2stopbits = new RadioButton();
            rb1stopbits = new RadioButton();
            gbParity = new GroupBox();
            rbEvenParity = new RadioButton();
            rbOddParity = new RadioButton();
            rbNoneParity = new RadioButton();
            gbFlowControl = new GroupBox();
            rbXonXoffFlowControl = new RadioButton();
            rbXonRTSFlowControl = new RadioButton();
            rbRTSFlowControl = new RadioButton();
            rbNoneFlowControl = new RadioButton();
            lsCOMPortSelect = new ListBox();
            btnSaveSettings = new Button();
            btnCloseSettings = new Button();
            gbBundRate.SuspendLayout();
            gbDataBits.SuspendLayout();
            gbStopBits.SuspendLayout();
            gbParity.SuspendLayout();
            gbFlowControl.SuspendLayout();
            SuspendLayout();
            // 
            // gbBundRate
            // 
            gbBundRate.BackColor = SystemColors.ButtonFace;
            gbBundRate.Controls.Add(rb115200baundrate);
            gbBundRate.Controls.Add(rb57600baundrate);
            gbBundRate.Controls.Add(rb38400baundrate);
            gbBundRate.Controls.Add(rb19200baundrate);
            gbBundRate.Controls.Add(rb9600baundrate);
            gbBundRate.Controls.Add(rb4800baundrate);
            gbBundRate.Controls.Add(rb2400baundrate);
            gbBundRate.Controls.Add(rb1200baundrate);
            gbBundRate.Controls.Add(rb600baundrate);
            gbBundRate.Controls.Add(rb300baundrate);
            gbBundRate.Controls.Add(rb110baundrate);
            gbBundRate.Location = new Point(17, 12);
            gbBundRate.Name = "gbBundRate";
            gbBundRate.Size = new Size(443, 116);
            gbBundRate.TabIndex = 0;
            gbBundRate.TabStop = false;
            gbBundRate.Text = "Baund Rate";
            // 
            // rb115200baundrate
            // 
            rb115200baundrate.AutoSize = true;
            rb115200baundrate.Location = new Point(354, 66);
            rb115200baundrate.Name = "rb115200baundrate";
            rb115200baundrate.Size = new Size(78, 24);
            rb115200baundrate.TabIndex = 12;
            rb115200baundrate.Text = "115200";
            rb115200baundrate.UseVisualStyleBackColor = true;
            // 
            // rb57600baundrate
            // 
            rb57600baundrate.AutoSize = true;
            rb57600baundrate.Location = new Point(278, 66);
            rb57600baundrate.Name = "rb57600baundrate";
            rb57600baundrate.Size = new Size(70, 24);
            rb57600baundrate.TabIndex = 11;
            rb57600baundrate.Text = "57600";
            rb57600baundrate.UseVisualStyleBackColor = true;
            // 
            // rb38400baundrate
            // 
            rb38400baundrate.AutoSize = true;
            rb38400baundrate.Location = new Point(202, 66);
            rb38400baundrate.Name = "rb38400baundrate";
            rb38400baundrate.Size = new Size(70, 24);
            rb38400baundrate.TabIndex = 10;
            rb38400baundrate.Text = "38400";
            rb38400baundrate.UseVisualStyleBackColor = true;
            // 
            // rb19200baundrate
            // 
            rb19200baundrate.AutoSize = true;
            rb19200baundrate.Location = new Point(126, 66);
            rb19200baundrate.Name = "rb19200baundrate";
            rb19200baundrate.Size = new Size(70, 24);
            rb19200baundrate.TabIndex = 9;
            rb19200baundrate.Text = "19200";
            rb19200baundrate.UseVisualStyleBackColor = true;
            // 
            // rb9600baundrate
            // 
            rb9600baundrate.AutoSize = true;
            rb9600baundrate.Checked = true;
            rb9600baundrate.Location = new Point(66, 66);
            rb9600baundrate.Name = "rb9600baundrate";
            rb9600baundrate.Size = new Size(62, 24);
            rb9600baundrate.TabIndex = 8;
            rb9600baundrate.TabStop = true;
            rb9600baundrate.Text = "9600";
            rb9600baundrate.UseVisualStyleBackColor = true;
            // 
            // rb4800baundrate
            // 
            rb4800baundrate.AutoSize = true;
            rb4800baundrate.Location = new Point(6, 66);
            rb4800baundrate.Name = "rb4800baundrate";
            rb4800baundrate.Size = new Size(62, 24);
            rb4800baundrate.TabIndex = 7;
            rb4800baundrate.Text = "4800";
            rb4800baundrate.UseVisualStyleBackColor = true;
            // 
            // rb2400baundrate
            // 
            rb2400baundrate.AutoSize = true;
            rb2400baundrate.Location = new Point(254, 26);
            rb2400baundrate.Name = "rb2400baundrate";
            rb2400baundrate.Size = new Size(62, 24);
            rb2400baundrate.TabIndex = 6;
            rb2400baundrate.Text = "2400";
            rb2400baundrate.UseVisualStyleBackColor = true;
            // 
            // rb1200baundrate
            // 
            rb1200baundrate.AutoSize = true;
            rb1200baundrate.Location = new Point(186, 26);
            rb1200baundrate.Name = "rb1200baundrate";
            rb1200baundrate.Size = new Size(62, 24);
            rb1200baundrate.TabIndex = 5;
            rb1200baundrate.Text = "1200";
            rb1200baundrate.UseVisualStyleBackColor = true;
            // 
            // rb600baundrate
            // 
            rb600baundrate.AutoSize = true;
            rb600baundrate.Location = new Point(126, 26);
            rb600baundrate.Name = "rb600baundrate";
            rb600baundrate.Size = new Size(54, 24);
            rb600baundrate.TabIndex = 4;
            rb600baundrate.Text = "600";
            rb600baundrate.UseVisualStyleBackColor = true;
            // 
            // rb300baundrate
            // 
            rb300baundrate.AutoSize = true;
            rb300baundrate.Location = new Point(66, 26);
            rb300baundrate.Name = "rb300baundrate";
            rb300baundrate.Size = new Size(54, 24);
            rb300baundrate.TabIndex = 3;
            rb300baundrate.Text = "300";
            rb300baundrate.UseVisualStyleBackColor = true;
            // 
            // rb110baundrate
            // 
            rb110baundrate.AutoSize = true;
            rb110baundrate.Location = new Point(6, 26);
            rb110baundrate.Name = "rb110baundrate";
            rb110baundrate.Size = new Size(54, 24);
            rb110baundrate.TabIndex = 2;
            rb110baundrate.Text = "110";
            rb110baundrate.UseVisualStyleBackColor = true;
            // 
            // gbDataBits
            // 
            gbDataBits.BackColor = SystemColors.ButtonFace;
            gbDataBits.Controls.Add(rb8databits);
            gbDataBits.Controls.Add(rb7databits);
            gbDataBits.Location = new Point(17, 153);
            gbDataBits.Name = "gbDataBits";
            gbDataBits.Size = new Size(120, 70);
            gbDataBits.TabIndex = 1;
            gbDataBits.TabStop = false;
            gbDataBits.Text = "Data Bits";
            // 
            // rb8databits
            // 
            rb8databits.AutoSize = true;
            rb8databits.Location = new Point(59, 26);
            rb8databits.Name = "rb8databits";
            rb8databits.Size = new Size(38, 24);
            rb8databits.TabIndex = 1;
            rb8databits.Text = "8";
            rb8databits.UseVisualStyleBackColor = true;
            // 
            // rb7databits
            // 
            rb7databits.AutoSize = true;
            rb7databits.Checked = true;
            rb7databits.Location = new Point(13, 26);
            rb7databits.Name = "rb7databits";
            rb7databits.Size = new Size(38, 24);
            rb7databits.TabIndex = 0;
            rb7databits.TabStop = true;
            rb7databits.Text = "7";
            rb7databits.UseVisualStyleBackColor = true;
            // 
            // gbStopBits
            // 
            gbStopBits.BackColor = SystemColors.ButtonFace;
            gbStopBits.Controls.Add(rb2stopbits);
            gbStopBits.Controls.Add(rb1stopbits);
            gbStopBits.Location = new Point(151, 153);
            gbStopBits.Name = "gbStopBits";
            gbStopBits.Size = new Size(120, 70);
            gbStopBits.TabIndex = 2;
            gbStopBits.TabStop = false;
            gbStopBits.Text = "Stop Bits";
            // 
            // rb2stopbits
            // 
            rb2stopbits.AutoSize = true;
            rb2stopbits.Checked = true;
            rb2stopbits.Location = new Point(63, 26);
            rb2stopbits.Name = "rb2stopbits";
            rb2stopbits.Size = new Size(38, 24);
            rb2stopbits.TabIndex = 1;
            rb2stopbits.TabStop = true;
            rb2stopbits.Text = "2";
            rb2stopbits.UseVisualStyleBackColor = true;
            // 
            // rb1stopbits
            // 
            rb1stopbits.AutoSize = true;
            rb1stopbits.Location = new Point(11, 26);
            rb1stopbits.Name = "rb1stopbits";
            rb1stopbits.Size = new Size(38, 24);
            rb1stopbits.TabIndex = 0;
            rb1stopbits.Text = "1";
            rb1stopbits.UseVisualStyleBackColor = true;
            // 
            // gbParity
            // 
            gbParity.BackColor = SystemColors.ButtonFace;
            gbParity.Controls.Add(rbEvenParity);
            gbParity.Controls.Add(rbOddParity);
            gbParity.Controls.Add(rbNoneParity);
            gbParity.Location = new Point(17, 246);
            gbParity.Name = "gbParity";
            gbParity.Size = new Size(120, 157);
            gbParity.TabIndex = 3;
            gbParity.TabStop = false;
            gbParity.Text = "Parity";
            // 
            // rbEvenParity
            // 
            rbEvenParity.AutoSize = true;
            rbEvenParity.Checked = true;
            rbEvenParity.Location = new Point(16, 114);
            rbEvenParity.Name = "rbEvenParity";
            rbEvenParity.Size = new Size(61, 24);
            rbEvenParity.TabIndex = 2;
            rbEvenParity.TabStop = true;
            rbEvenParity.Text = "Even";
            rbEvenParity.UseVisualStyleBackColor = true;
            // 
            // rbOddParity
            // 
            rbOddParity.AutoSize = true;
            rbOddParity.Location = new Point(16, 68);
            rbOddParity.Name = "rbOddParity";
            rbOddParity.Size = new Size(59, 24);
            rbOddParity.TabIndex = 1;
            rbOddParity.Text = "Odd";
            rbOddParity.UseVisualStyleBackColor = true;
            // 
            // rbNoneParity
            // 
            rbNoneParity.AutoSize = true;
            rbNoneParity.Location = new Point(16, 26);
            rbNoneParity.Name = "rbNoneParity";
            rbNoneParity.Size = new Size(66, 24);
            rbNoneParity.TabIndex = 0;
            rbNoneParity.Text = "None";
            rbNoneParity.UseVisualStyleBackColor = true;
            // 
            // gbFlowControl
            // 
            gbFlowControl.BackColor = SystemColors.ButtonFace;
            gbFlowControl.Controls.Add(rbXonXoffFlowControl);
            gbFlowControl.Controls.Add(rbXonRTSFlowControl);
            gbFlowControl.Controls.Add(rbRTSFlowControl);
            gbFlowControl.Controls.Add(rbNoneFlowControl);
            gbFlowControl.Location = new Point(151, 246);
            gbFlowControl.Name = "gbFlowControl";
            gbFlowControl.Size = new Size(120, 157);
            gbFlowControl.TabIndex = 4;
            gbFlowControl.TabStop = false;
            gbFlowControl.Text = "Flow Control";
            // 
            // rbXonXoffFlowControl
            // 
            rbXonXoffFlowControl.AutoSize = true;
            rbXonXoffFlowControl.Location = new Point(17, 56);
            rbXonXoffFlowControl.Name = "rbXonXoffFlowControl";
            rbXonXoffFlowControl.Size = new Size(90, 24);
            rbXonXoffFlowControl.TabIndex = 1;
            rbXonXoffFlowControl.Text = "Xon/Xoff";
            rbXonXoffFlowControl.UseVisualStyleBackColor = true;
            // 
            // rbXonRTSFlowControl
            // 
            rbXonRTSFlowControl.AutoSize = true;
            rbXonRTSFlowControl.Location = new Point(17, 116);
            rbXonRTSFlowControl.Name = "rbXonRTSFlowControl";
            rbXonRTSFlowControl.Size = new Size(86, 24);
            rbXonRTSFlowControl.TabIndex = 3;
            rbXonRTSFlowControl.Text = "Xon/RTS";
            rbXonRTSFlowControl.UseVisualStyleBackColor = true;
            // 
            // rbRTSFlowControl
            // 
            rbRTSFlowControl.AutoSize = true;
            rbRTSFlowControl.Location = new Point(17, 86);
            rbRTSFlowControl.Name = "rbRTSFlowControl";
            rbRTSFlowControl.Size = new Size(54, 24);
            rbRTSFlowControl.TabIndex = 2;
            rbRTSFlowControl.Text = "RTS";
            rbRTSFlowControl.UseVisualStyleBackColor = true;
            // 
            // rbNoneFlowControl
            // 
            rbNoneFlowControl.AutoSize = true;
            rbNoneFlowControl.Checked = true;
            rbNoneFlowControl.Location = new Point(17, 26);
            rbNoneFlowControl.Name = "rbNoneFlowControl";
            rbNoneFlowControl.Size = new Size(66, 24);
            rbNoneFlowControl.TabIndex = 0;
            rbNoneFlowControl.TabStop = true;
            rbNoneFlowControl.Text = "None";
            rbNoneFlowControl.UseVisualStyleBackColor = true;
            // 
            // lsCOMPortSelect
            // 
            lsCOMPortSelect.FormattingEnabled = true;
            lsCOMPortSelect.Items.AddRange(new object[] { "COM0", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15", "COM16", "COM17", "COM18", "COM19", "COM20", "COM21", "COM22", "COM23", "COM24", "COM25", "COM26", "COM27", "COM28", "COM29", "COM30", "COM31", "COM32", "COM33", "COM34", "COM35", "COM36", "COM37", "COM38", "COM39", "COM40", "COM41", "COM42", "COM43", "COM44", "COM45", "COM46", "COM47", "COM48", "COM49", "COM50", "COM51", "COM52", "COM53", "COM54", "COM55", "COM56", "COM57", "COM58", "COM59", "COM60", "COM61", "COM62", "COM63", "COM64", "COM65", "COM66", "COM67", "COM68", "COM69", "COM70", "COM71", "COM72", "COM73", "COM74", "COM75", "COM76", "COM77", "COM78", "COM79", "COM80", "COM81", "COM82", "COM83", "COM84", "COM85", "COM86", "COM87", "COM88", "COM89", "COM90", "COM91", "COM92", "COM93", "COM94", "COM95", "COM96", "COM97", "COM98", "COM99", "COM100", "COM101", "COM102", "COM103", "COM104", "COM105", "COM106", "COM107", "COM108", "COM109", "COM110", "COM111", "COM112", "COM113", "COM114", "COM115", "COM116", "COM117", "COM118", "COM119", "COM120", "COM121", "COM122", "COM123", "COM124", "COM125", "COM126", "COM127", "COM128", "COM129", "COM130", "COM131", "COM132", "COM133", "COM134", "COM135", "COM136", "COM137", "COM138", "COM139", "COM140", "COM141", "COM142", "COM143", "COM144", "COM145", "COM146", "COM147", "COM148", "COM149", "COM150" });
            lsCOMPortSelect.Location = new Point(310, 153);
            lsCOMPortSelect.Name = "lsCOMPortSelect";
            lsCOMPortSelect.Size = new Size(150, 244);
            lsCOMPortSelect.TabIndex = 5;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.Location = new Point(106, 429);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(119, 43);
            btnSaveSettings.TabIndex = 6;
            btnSaveSettings.Text = "Save";
            btnSaveSettings.UseVisualStyleBackColor = true;
            btnSaveSettings.Click += btnSaveSettings_Click;
            // 
            // btnCloseSettings
            // 
            btnCloseSettings.Location = new Point(258, 429);
            btnCloseSettings.Name = "btnCloseSettings";
            btnCloseSettings.Size = new Size(119, 43);
            btnCloseSettings.TabIndex = 7;
            btnCloseSettings.Text = "Close";
            btnCloseSettings.UseVisualStyleBackColor = true;
            btnCloseSettings.Click += btnCloseSettings_Click;
            // 
            // SerialPortSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(484, 484);
            Controls.Add(btnCloseSettings);
            Controls.Add(btnSaveSettings);
            Controls.Add(lsCOMPortSelect);
            Controls.Add(gbFlowControl);
            Controls.Add(gbParity);
            Controls.Add(gbStopBits);
            Controls.Add(gbDataBits);
            Controls.Add(gbBundRate);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(502, 531);
            MinimumSize = new Size(502, 531);
            Name = "SerialPortSettings";
            Text = "Serial Port Settings";
            gbBundRate.ResumeLayout(false);
            gbBundRate.PerformLayout();
            gbDataBits.ResumeLayout(false);
            gbDataBits.PerformLayout();
            gbStopBits.ResumeLayout(false);
            gbStopBits.PerformLayout();
            gbParity.ResumeLayout(false);
            gbParity.PerformLayout();
            gbFlowControl.ResumeLayout(false);
            gbFlowControl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbBundRate;
        private GroupBox gbDataBits;
        private RadioButton rb300baundrate;
        private RadioButton rb110baundrate;
        private RadioButton rb8databits;
        private RadioButton rb7databits;
        private GroupBox gbStopBits;
        private RadioButton rb2stopbits;
        private RadioButton rb1stopbits;
        private RadioButton rb1200baundrate;
        private RadioButton rb600baundrate;
        private RadioButton rb115200baundrate;
        private RadioButton rb57600baundrate;
        private RadioButton rb38400baundrate;
        private RadioButton rb19200baundrate;
        private RadioButton rb9600baundrate;
        private RadioButton rb4800baundrate;
        private RadioButton rb2400baundrate;
        private GroupBox gbParity;
        private RadioButton rbEvenParity;
        private RadioButton rbOddParity;
        private RadioButton rbNoneParity;
        private GroupBox gbFlowControl;
        private RadioButton rbXonXoffFlowControl;
        private RadioButton rbXonRTSFlowControl;
        private RadioButton rbRTSFlowControl;
        private RadioButton rbNoneFlowControl;
        private ListBox lsCOMPortSelect;
        private Button btnSaveSettings;
        private Button btnCloseSettings;
    }
}