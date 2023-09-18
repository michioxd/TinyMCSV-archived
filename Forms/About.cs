using System.Diagnostics;
using TinyMCSV.Utils;

namespace TinyMCSV
{

    public partial class About : Form
    {

        public About()
        {
            InitializeComponent();

        }

        private void About_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new OpenBrowser("https://github.com/michioxd/tinymcsv");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new OpenBrowser("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            this.Close();
        }
    }
}
