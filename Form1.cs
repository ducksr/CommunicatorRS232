using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RS232_Communicator
{
    public partial class Form1 : Form
    {
        private Rectangle originalFormRect;
        private Rectangle originalTxtWritterRect;

        private float originalTxtWritterSize;

        private float fontScale = 1f;


        public Form1()
        {
            InitializeComponent();

            txtWritter.ScrollBars = ScrollBars.Vertical;
            txtWritter.WordWrap = true;

            originalFormRect = new Rectangle(this.Location, this.Size);
            originalTxtWritterRect = new Rectangle(txtWritter.Location, txtWritter.Size);
            originalTxtWritterSize = txtWritter.Font.Size;

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel3.ToolTipText = "Run";
        }
    }
}
