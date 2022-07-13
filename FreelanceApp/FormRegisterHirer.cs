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
