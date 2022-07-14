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

namespace FreelanceApp
{
    public partial class FormLogin : Form
    {
        IUserRepository UserRepository = new UserRepository();
        IHirerRepository HirerRepository = new HirerRepository();
        ISeekerRepository SeekerRepository = new SeekerRepository();




        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormDirection FormDirection = new FormDirection();
            FormDirection.ShowDialog();
           
        }

       
       

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var Hirers = HirerRepository.GetHirers();
            var Seekers = SeekerRepository.GetSeekers();
            //var Hirer = HirerRepository.GetHirers();
            //var Seeker = SeekerRepository.GetSeekers();
            bool haveAccount = false;


            foreach (var Hirer in Hirers)
            {
                if (Hirer.UserName == textBoxUserName.Text && Hirer.Password == textBoxPassword.Text)
                {
                   haveAccount = true;
                    FormHirerdashboard FormHirerdashboard = new FormHirerdashboard()
                    {
                        HirerId = Hirer.HirerId,
                    };

                    FormHirerdashboard.ShowDialog();
                    this.Close();
                 
                    
                }
            }

            foreach (var Seeker in Seekers)
            {
                if (Seeker.UserName == textBoxUserName.Text && Seeker.Password == textBoxPassword.Text)
                {
                    haveAccount = true;

                    FormSeekerDashboard FormSeekerDashboard = new FormSeekerDashboard
                    {
                        seekerid = Seeker.SeekerId,
                    };
                    textBoxPassword.Text = string.Empty;
                    FormSeekerDashboard.ShowDialog();
                }
            }

            if (haveAccount == false)
            {
                DialogResult dialogResult = MessageBox.Show("Incorrect User Name or Password!");
                
                
            }


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
