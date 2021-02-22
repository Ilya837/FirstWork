using System;
using System.IO;
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void File_Click(object sender, EventArgs e)
        {
            
            if (FileName.Text == "" || Faculty.Text == "" || Dean.Text == "" || Abbreviation.Text == "")
            {
                MessageBox.Show(
                  "Информация не была записана в файл.\rПроверьте поля на заполненность",
                   "",
                   MessageBoxButtons.OK,
                  MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.DefaultDesktopOnly);               
            }
            else
            {
                
                FileStream fileStream = new FileStream(FileName.Text, FileMode.OpenOrCreate);
                fileStream.Seek(0, SeekOrigin.End);
                string str = "Факультет: " + Faculty.Text + "\rДекан: " + Dean.Text + "\rАббревиатура: " + Abbreviation.Text + "\r- - - - - - - - - - - - - - - - - - - - - - -\r";
                byte[] array = System.Text.Encoding.Default.GetBytes(str);
                fileStream.Write(array, 0, array.Length);
                MessageBox.Show(
                 "Информация записана в файл",
                  "",
                  MessageBoxButtons.OK,
                 MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.DefaultDesktopOnly);
                fileStream.Close();
            }
            
            this.Focus();
        }
    }
}
