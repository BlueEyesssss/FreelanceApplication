using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.repository;
using BusinessObject;

namespace FreelanceApp
{
    public partial class FormHirerProfile : Form
    {
        public int HirerId;
        IHirerRepository HirerRepository = new HirerRepository();
        public FormHirerProfile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHirerProfile_Load(object sender, EventArgs e)
        {
            try
            {

                Hirer Hirer = HirerRepository.GetHirerByHirerID(this.HirerId);
                textBoxUserID.Text = Hirer.UserId.ToString();
                textBoxUserName.Text = Hirer.UserName.ToString();

                textBoxPassword.Text = Hirer.Password.ToString();

                textBoxFullName.Text = Hirer.FullName.ToString();

                textBoxBalance.Text = Hirer.Balance.ToString();

                maskedTextBoxPhone.Text = Hirer.Phone.ToString();

                textBoxLocation.Text = Hirer.Location.ToString();







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "load");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
