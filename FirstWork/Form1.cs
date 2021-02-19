using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWork
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedactionForm redact = new RedactionForm(this, "New faculty name:");
            redact.Show();
            this.Enabled = false;
            

        }

        private void deansNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedactionForm redact = new RedactionForm(this, "New Dean's name:");
            redact.Show();
            this.Enabled = false;
            
        }

        private void abbreviationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedactionForm redact = new RedactionForm(this, "New abbreviation:");
            redact.Show();
            this.Enabled = false;
            
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void File_Click(object sender, EventArgs e)
        {

        }
    }
}
