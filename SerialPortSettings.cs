﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS232_Communicator
{
    public partial class SerialPortSettings : Form
    {
        public SerialPortSettings()
        {
            InitializeComponent();

            lsCOMPortSelect.SelectedIndex = 0;

        }

        private void btnCloseSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
