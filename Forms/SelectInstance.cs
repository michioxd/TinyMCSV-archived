using TinyMCSV.Forms;

namespace TinyMCSV
{
    public partial class SelectInstance : Form
    {
        public SelectInstance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Main_Create_Click(object sender, EventArgs e)
        {
            (new CreateNewInstance()).ShowDialog();
        }
    }
}
