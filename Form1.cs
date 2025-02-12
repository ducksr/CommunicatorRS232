
using RS232_Communicator.Utilities;
using System.IO.Ports;
using System.Net.Http;
using System.Windows.Forms;
using System.Xml.Linq;


namespace RS232_Communicator
{
    public partial class Form1 : Form
    {

        private SerialPort serialPort;

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


            try
            {
                // Configurar puerto
                serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
                serialPort.Open();

                foreach (string linea in txtWritter.Lines)
                {
                    serialPort.WriteLine(linea);
                }

                serialPort.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Run Test connection");

            tsslblStatusConnection.Text = "Connected!";
            tsslblStatusConnection.BackColor = Color.GreenYellow;

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
            serialPortSettings.Show();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();

            GlobalsSettings _settings = new GlobalsSettings();


            if (dialog.ShowDialog() == DialogResult.OK)

            {
                string filePath = dialog.FileName;

                XDocument config = XDocument.Load(filePath);

                // Verificar si hay un namespace (xmlns)
                XNamespace ns = config.Root?.GetDefaultNamespace() ?? XNamespace.None;

                // Buscar el nodo <appSettings>
                XElement appSettings = config.Descendants(ns + "appSettings").FirstOrDefault();

                if (appSettings != null) {
                    // Buscar la clave "BaudRate"

                    foreach (XElement val in appSettings.Elements(ns + "add")) {

                        _settings.SaveConfig(val.FirstAttribute.Value,val.LastAttribute.Value);

                    }

                    /*
                    XElement value = appSettings.Elements(ns + "add")
                        .FirstOrDefault(e => (string)e.Attribute("key") == configname);

                    */

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
    }
}
