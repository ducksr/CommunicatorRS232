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
            SuspendLayout();
            // 
            // gbBundRate
            // 
            gbBundRate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbBundRate.Location = new Point(17, 17);
            gbBundRate.Name = "gbBundRate";
            gbBundRate.Size = new Size(250, 125);
            gbBundRate.TabIndex = 0;
            gbBundRate.TabStop = false;
            gbBundRate.Text = "Baund Rate";
            // 
            // SerialPortSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbBundRate);
            MinimumSize = new Size(562, 439);
            Name = "SerialPortSettings";
            Text = "SerialPortSettings";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbBundRate;
    }
}