using RS232_Communicator.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RS232_Communicator
{
    public partial class SerialPortSettings : Form
    {

        private GlobalsSettings _settings = new GlobalsSettings();

        // Handles UI thread exceptions
        private static void GlobalThreadExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"An unexpected error occurred:\n{e.Exception.Message}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Handles non-UI thread exceptions
        private static void GlobalUnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                MessageBox.Show($"A critical error occurred:\n{ex.Message}",
                                "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public SerialPortSettings()
        {
            InitializeComponent();

            Application.ThreadException += new ThreadExceptionEventHandler(GlobalThreadExceptionHandler);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalUnhandledExceptionHandler);

            LoadData();            

        }

        private void LoadData() {

            //Set Baund Rate
            foreach (RadioButton activecontrolRB in gbBundRate.Controls)
            {
                if (activecontrolRB.Text == _settings.BaundRate)
                {
                    // MessageBox.Show(activecontrol.Text);
                    activecontrolRB.Checked = true;
                }
            }

            // Set Data Bits
            foreach (RadioButton activecontrolRB in gbDataBits.Controls)
            {
                if (activecontrolRB.Text == _settings.DataBits)
                {
                    // MessageBox.Show(activecontrol.Text);
                    activecontrolRB.Checked = true;
                }
            }

            // Set Stop Bits
            foreach (RadioButton activecontrolRB in gbStopBits.Controls)
            {
                if (activecontrolRB.Text == _settings.StopBits)
                {
                    // MessageBox.Show(activecontrol.Text);
                    activecontrolRB.Checked = true;
                }

            }

            // Set Parity
            foreach (RadioButton activecontrolRB in gbParity.Controls)
            {
                if (activecontrolRB.Text == _settings.Parity)
                {
                    // MessageBox.Show(activecontrol.Text);
                    activecontrolRB.Checked = true;
                }
            }

            // Set Flow Control
            foreach (RadioButton activecontrolRB in gbFlowControl.Controls)
            {
                if (activecontrolRB.Text == _settings.FlowControl)
                {
                    // MessageBox.Show(activecontrol.Text);
                    activecontrolRB.Checked = true;
                }
            }

            // Set Serial Port
            lsCOMPortSelect.SelectedIndex = int.Parse(_settings.SerialPort);
        }

        private void btnCloseSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {

            GlobalsSettings _settings = new GlobalsSettings();

            // Set Baund Rate
            foreach (RadioButton activeRB in gbBundRate.Controls) {
                if (activeRB.Checked) {
                    _settings.SaveConfig("BaundRate", activeRB.Text);
                }
            }

            // Set Data Bits
            foreach (RadioButton activeRB in gbDataBits.Controls)
            {
                if (activeRB.Checked)
                {
                    _settings.SaveConfig("DataBits", activeRB.Text);
                }
            }

            // Set Stop Bits
            foreach (RadioButton activeRB in gbStopBits.Controls)
            {
                if (activeRB.Checked)
                {
                    _settings.SaveConfig("StopBits", activeRB.Text);
                }
            }

            // Set Parity
            foreach (RadioButton activeRB in gbParity.Controls)
            {
                if (activeRB.Checked)
                {
                    _settings.SaveConfig("Parity", activeRB.Text);
                }
            }

            // Set Parity
            foreach (RadioButton activeRB in gbParity.Controls)
            {
                if (activeRB.Checked)
                {
                    _settings.SaveConfig("Parity", activeRB.Text);
                }
            }

            // Set Flow Control
            foreach (RadioButton activeRB in gbFlowControl.Controls)
            {
                if (activeRB.Checked)
                {
                    _settings.SaveConfig("FlowControl", activeRB.Text);
                }
            }

            // Save Serial Port
            _settings.SaveConfig("SerialPort",lsCOMPortSelect.SelectedItem.ToString().Remove(0,3));


            
            

        }
    }
}
