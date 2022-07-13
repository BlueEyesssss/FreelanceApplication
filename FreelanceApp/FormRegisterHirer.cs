using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.repository;

namespace FreelanceApp
{
    public partial class FormRegisterHirer : Form
    {
        IHirerRepository HirerRepository = new HirerRepository();
        public bool InsertOrUpdate { get; set; }

        public FormRegisterHirer()
        {
            InitializeComponent();
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
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
            if (textBoxCompany.Text.Length < 5 || textBoxCompany.Text.Length > 50)
            {
                MessageBox.Show("company must be in [5;50]");
                return;
            }
            if (maskedTextBoxPhone.Text.Length != 10)
            {
                MessageBox.Show("Please input phone with 10 digits");
                return;
            }




            try
            {
                //get inf seeker
                Hirer Hirer = new Hirer
                {
                    UserName = textBoxUserName.Text,
                    Password = textBoxPassword.Text,
                    FullName = textBoxFullName.Text,
                    Balance = 0,
                    Phone = maskedTextBoxPhone.Text,
                    Location = textBoxLocation.Text,
                    CompanyName = textBoxCompany.Text
                };
                //check duplicate username
                if (!HirerRepository.checkDuplicateuserName(Hirer.UserName))
                {
                    if (HirerRepository.createUser(Hirer))
                    {
                        Hirer.UserId = HirerRepository.getHirerId(Hirer);
                        if (HirerRepository.createHirer(Hirer))
                        {
                            MessageBox.Show("create hirer success", "register hirer");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("create hirer fail", "register hirer");
                        }
                    }
                    else
                    {
                        MessageBox.Show("can't create user", "register hirer");
                    }
                }
                else
                {
                    MessageBox.Show("duplicate user name", "register hirer");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "register hirer");
            }
        }

        
    }
}
