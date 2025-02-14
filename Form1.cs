
using RS232_Communicator.Utilities;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO.Ports;
using System.Net.Http;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace RS232_Communicator
{
    public partial class Form1 : Form
    {

        private SerialPort? serialPort;
        private bool activeLoadFile = false;


        // Handles UI thread exceptions
        private static void GlobalThreadExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"An unexpected error occurred:\n{e.Exception.Message}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Handles non-UI thread exceptions
        private static void GlobalUnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Exception? ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                MessageBox.Show($"A critical error occurred:\n{ex.Message}",
                                "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Form1()
        {
            InitializeComponent();


            Application.ThreadException += new ThreadExceptionEventHandler(GlobalThreadExceptionHandler);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalUnhandledExceptionHandler);


            txtWritter.ScrollBars = ScrollBars.Vertical;
            txtWritter.WordWrap = true;

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)

            {

                string filePath = dialog.FileName;

                string fileContent = File.ReadAllText(filePath);

                txtWritter.Text = fileContent; // Assuming "" is your text box

            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void tsslblRun_Click(object sender, EventArgs e)
        {
            if (activeLoadFile)
            {
                MessageBox.Show("There is an active upload!");
            }


            GlobalsSettings _settings = new GlobalsSettings();

            txtWritter.Enabled = false;

            try
            {
                Parity parity = new Parity();
                StopBits stopBits = new StopBits();
                Handshake handshake = new Handshake();

                switch (_settings.Parity)
                {
                    case "None":
                        parity = Parity.None;
                        break;
                    case "Odd":
                        parity = Parity.Odd;
                        break;
                    case "Even":
                        parity = Parity.Even;
                        break;
                }

                switch (_settings.StopBits)
                {
                    case "1":
                        stopBits = StopBits.One;
                        break;
                    case "2":
                        stopBits = StopBits.Two;
                        break;
                }

                switch (_settings.FlowControl)
                {
                    case "None":
                        handshake = Handshake.None;
                        break;
                    case "Xon/Xoff":
                        handshake = Handshake.XOnXOff;
                        break;
                    case "RTS":
                        handshake = Handshake.RequestToSend;
                        break;
                    case "Xon/RTS":
                        handshake = Handshake.RequestToSendXOnXOff;
                        break;
                }

                // Configurar puerto
                serialPort = new SerialPort
                {
                    PortName = "COM" + _settings.SerialPort
                    ,
                    BaudRate = int.Parse(_settings.BaundRate)
                    ,
                    Parity = parity
                    ,
                    DataBits = int.Parse(_settings.DataBits)
                    ,
                    StopBits = stopBits
                    //,Handshake = handshake
                };

                serialPort.Open();

                int i = 1;
                int totalLines = txtWritter.Lines.Length;

                MessageBox.Show(totalLines.ToString());

                pbLoadProcess.Visible = true;

                foreach (string linea in txtWritter.Lines)
                {
                    serialPort.WriteLine(linea);

                    pbLoadProcess.Value = i / totalLines;

                    i++;
                }

                serialPort.Close();

                pbLoadProcess.Visible = false;
                MessageBox.Show("Upload Done!!");
                txtWritter.Enabled = true;
                activeLoadFile = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            GlobalsSettings _settings = new GlobalsSettings();

            try
            {
                Parity parity = new Parity();
                StopBits stopBits = new StopBits();
                Handshake handshake = new Handshake();

                switch (_settings.Parity)
                {
                    case "None":
                        parity = Parity.None;
                        break;
                    case "Odd":
                        parity = Parity.Odd;
                        break;
                    case "Even":
                        parity = Parity.Even;
                        break;
                }

                switch (_settings.StopBits)
                {
                    case "1":
                        stopBits = StopBits.One;
                        break;
                    case "2":
                        stopBits = StopBits.Two;
                        break;
                }

                switch (_settings.FlowControl)
                {
                    case "None":
                        handshake = Handshake.None;
                        break;
                    case "Xon/Xoff":
                        handshake = Handshake.XOnXOff;
                        break;
                    case "RTS":
                        handshake = Handshake.RequestToSend;
                        break;
                    case "Xon/RTS":
                        handshake = Handshake.RequestToSendXOnXOff;
                        break;
                }


                // Configurar puerto
                serialPort = new SerialPort
                {
                    PortName = "COM" + _settings.SerialPort
                    ,
                    BaudRate = int.Parse(_settings.BaundRate)
                    ,
                    Parity = parity
                    ,
                    DataBits = int.Parse(_settings.DataBits)
                    ,
                    StopBits = stopBits
                    //,Handshake = handshake
                };

                serialPort.Open();

                serialPort.Close();

                tsslblStatusConnection.Enabled = true;
                tsslblStatusConnection.Text = "Test Success !!!";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                tsslblStatusConnection.Enabled = true;
                tsslblStatusConnection.Text = "Fail";
                tsslblStatusConnection.BackColor = Color.Red;

            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string texto = txtWritter.Text;

                saveFileDialog.Filter = "Archivos MATLAB (*.m)|*.m|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Guardar como";
                saveFileDialog.DefaultExt = "m";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, texto);
                    MessageBox.Show("Archivo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SerialPortSettings serialPortSettings = new SerialPortSettings();
            serialPortSettings.StartPosition = FormStartPosition.CenterParent;
            serialPortSettings.ShowDialog();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();

            GlobalsSettings _settings = new GlobalsSettings();


            if (dialog.ShowDialog() == DialogResult.OK)

            {
                string filePath = dialog.FileName;

                XDocument? config = XDocument.Load(filePath);

                // Verificar si hay un namespace (xmlns)
                XNamespace? ns = config.Root?.GetDefaultNamespace() ?? XNamespace.None;

                // Buscar el nodo <appSettings>
                XElement? appSettings = config.Descendants(ns + "appSettings").FirstOrDefault();

                if (appSettings != null)
                {
                    // Buscar la clave "BaudRate"

                    foreach (XElement? val in appSettings.Elements(ns + "add"))
                    {

                        if (val != null)
                        {
                            _settings.SaveConfig(val.FirstAttribute.Value, val.LastAttribute.Value);
                        }
                    }

                }

            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string filePath = "RS232 Communicator.dll.config";
                string fileContent = File.ReadAllText(filePath);


                saveFileDialog.Filter = "Archivos Config (*.config)|*.config|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Guardar como";
                saveFileDialog.DefaultExt = "config";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, fileContent);
                    MessageBox.Show("Configurations Saved Successfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void txtWritter_TextChanged(object sender, EventArgs e)
        {
            tsstotalLines.Text = txtWritter.Lines.Length.ToString();
            tsstotalChars.Text = txtWritter.Text.Length.ToString();
        }
    }
}
