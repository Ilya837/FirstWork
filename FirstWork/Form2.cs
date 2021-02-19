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
    public partial class RedactionForm : Form
    {
        MenuForm form = new MenuForm();
        public  RedactionForm()
        {
            InitializeComponent();
            
        }

        public RedactionForm(MenuForm f , string name)
        {
            InitializeComponent();
            this.New.Text = name ;
            form = f;

        }

        private void RedactionForm_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (this.New.Text == "New faculty name:")
            {
                form.Faculty.Text = this.name.Text;
            }
            else if (this.New.Text == "New Dean's name:")
            {
                form.Dean.Text = this.name.Text;
            }
            else
            {
                form.Abbreviation.Text = this.name.Text;
            }
            this.Close();
            form.Enabled = true;
            form.Focus();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Enabled = true;
            form.Focus();
        }

        private void Exit(object sender, FormClosedEventArgs e)
        {
            form.Enabled = true;
            form.Focus();
        }
    }
}
