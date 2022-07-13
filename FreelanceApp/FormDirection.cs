using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreelanceApp
{
    public partial class FormDirection : Form
    {
        public FormDirection()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateHirer_Click(object sender, EventArgs e)
        {
            this.Close();
            FormRegisterHirer FormRegisterHirer = new FormRegisterHirer();
            FormRegisterHirer.ShowDialog();
        }

        private void buttonCreateSeeker_Click(object sender, EventArgs e)
        {
            this.Close();
            FormRegisterSeeker FormRegisterSeeker = new FormRegisterSeeker();
            FormRegisterSeeker.ShowDialog();
        }
    }
}
