namespace RS232_Communicator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtWritter = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            contactToolStripMenuItem = new ToolStripMenuItem();
            msbtnRun = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tsslblVersion = new ToolStripStatusLabel();
            tsslblVersionNumber = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            tsslblStatusTitle = new ToolStripStatusLabel();
            tsslblStatusConnection = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtWritter
            // 
            txtWritter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtWritter.Location = new Point(12, 41);
            txtWritter.Multiline = true;
            txtWritter.Name = "txtWritter";
            txtWritter.Size = new Size(747, 502);
            txtWritter.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem, helpToolStripMenuItem, msbtnRun, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(771, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Margin = new Padding(0, 0, 10, 0);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(155, 26);
            openToolStripMenuItem.Text = "Open File";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(155, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(155, 26);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(155, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem1, loadToolStripMenuItem, exportToolStripMenuItem });
            settingsToolStripMenuItem.Margin = new Padding(0, 0, 10, 0);
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(224, 26);
            openToolStripMenuItem1.Text = "Edit";
            openToolStripMenuItem1.Click += openToolStripMenuItem1_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(224, 26);
            loadToolStripMenuItem.Text = "Import";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(224, 26);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { infoToolStripMenuItem, contactToolStripMenuItem });
            helpToolStripMenuItem.Margin = new Padding(0, 0, 10, 0);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(147, 26);
            infoToolStripMenuItem.Text = "Info";
            // 
            // contactToolStripMenuItem
            // 
            contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            contactToolStripMenuItem.Size = new Size(147, 26);
            contactToolStripMenuItem.Text = "Contact ";
            // 
            // msbtnRun
            // 
            msbtnRun.AutoToolTip = true;
            msbtnRun.Image = (Image)resources.GetObject("msbtnRun.Image");
            msbtnRun.Margin = new Padding(0, 0, 10, 0);
            msbtnRun.Name = "msbtnRun";
            msbtnRun.ShortcutKeys = Keys.F5;
            msbtnRun.Size = new Size(34, 24);
            msbtnRun.Tag = "Run";
            msbtnRun.Click += tsslblRun_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.ShortcutKeys = Keys.F6;
            toolStripMenuItem1.Size = new Size(34, 24);
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslblVersion, tsslblVersionNumber, toolStripStatusLabel3, tsslblStatusTitle, tsslblStatusConnection });
            statusStrip1.Location = new Point(0, 559);
            statusStrip1.Margin = new Padding(0, 0, 20, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(771, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslblVersion
            // 
            tsslblVersion.Margin = new Padding(0, 4, 20, 2);
            tsslblVersion.Name = "tsslblVersion";
            tsslblVersion.Size = new Size(60, 20);
            tsslblVersion.Text = "Version:";
            // 
            // tsslblVersionNumber
            // 
            tsslblVersionNumber.Margin = new Padding(0, 4, 20, 2);
            tsslblVersionNumber.Name = "tsslblVersionNumber";
            tsslblVersionNumber.Size = new Size(17, 20);
            tsslblVersionNumber.Text = "1";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Margin = new Padding(0, 4, 20, 2);
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(0, 20);
            // 
            // tsslblStatusTitle
            // 
            tsslblStatusTitle.Margin = new Padding(0, 4, 20, 2);
            tsslblStatusTitle.Name = "tsslblStatusTitle";
            tsslblStatusTitle.Size = new Size(131, 20);
            tsslblStatusTitle.Text = "Connection Status:";
            // 
            // tsslblStatusConnection
            // 
            tsslblStatusConnection.BackColor = Color.Yellow;
            tsslblStatusConnection.Margin = new Padding(0, 4, 20, 2);
            tsslblStatusConnection.Name = "tsslblStatusConnection";
            tsslblStatusConnection.Size = new Size(80, 20);
            tsslblStatusConnection.Text = "....Wating....";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(771, 585);
            Controls.Add(statusStrip1);
            Controls.Add(txtWritter);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(789, 632);
            Name = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtWritter;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem contactToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslblVersion;
        private ToolStripStatusLabel tsslblVersionNumber;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel tsslblStatusTitle;
        private ToolStripStatusLabel tsslblStatusConnection;
        private ToolStripMenuItem msbtnRun;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}
