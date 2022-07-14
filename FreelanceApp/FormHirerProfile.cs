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
            if (textBoxUserName.Text.Length < 5 || textBoxUserName.Text.Length > 50)
            {
                MessageBox.Show("username must be in [5;50]");
                return;
            }
            if (textBoxPassword.Text.Length < 5 || textBoxPassword.Text.Length > 50)
            {
                MessageBox.Show("password must be in [5;50]");
                return;
            }
            if (textBoxFullName.Text.Length < 5 || textBoxFullName.Text.Length > 50)
            {
                MessageBox.Show("fullname must be in [5;50]");
                return;
            }
            if (textBoxLocation.Text.Length < 5 || textBoxLocation.Text.Length > 50)
            {
                MessageBox.Show("Location must be in [5;50]");
                return;
            }
            
            if (maskedTextBoxPhone.Text.Length != 10)
            {
                MessageBox.Show("Please input phone with 10 digits");
                return;
            }
            Hirer Hirer = new Hirer
            {
                HirerId = int.Parse(textBoxUserID.Text),
                UserId = int.Parse(textBoxUserID.Text),
                UserName = textBoxUserName.Text,
                Password = textBoxPassword.Text,
                FullName = textBoxFullName.Text,
                Balance = Decimal.Parse(textBoxBalance.Text),
                Phone = maskedTextBoxPhone.Text,
                Location = textBoxLocation.Text,
            };
            bool check = HirerRepository.Update(Hirer); 
            if (check)
            {
                MessageBox.Show("Update successfully!");
                this.Close();
            }
        }
    }
}
