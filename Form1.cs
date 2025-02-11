
using System.IO.Ports;


namespace RS232_Communicator
{
    public partial class Form1 : Form
    {
        private string fileNameLocation = "";

        private SerialPort serialPort;


        public Form1()
        {
            InitializeComponent();

            txtWritter.ScrollBars = ScrollBars.Vertical;
            txtWritter.WordWrap = true;


            msbtnRun.ToolTipText = "Run";

            this.Name = Application.ProductName;

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
            

            try {
                // Configurar puerto
                serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
                serialPort.Open();

                foreach (string linea in txtWritter.Lines)
                {
                    serialPort.WriteLine(linea);
                }

                serialPort.Close();

            }
            catch (Exception ex) {
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
    }
}
