using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyMCSV.Forms;

namespace TinyMCSV
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new About()).ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectInstanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new SelectInstance()).ShowDialog();
        }

        private void createANewInstanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new CreateNewInstance()).ShowDialog();
        }
    }
}
