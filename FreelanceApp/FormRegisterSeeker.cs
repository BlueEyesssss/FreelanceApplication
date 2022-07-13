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
    public partial class FormRegisterSeeker : Form
    {
        SeekerRepository seekerRepository;
        SkillRepository skillRepository;
        List<Skill> listSkill;

        public Seeker seeker1;
        public FormRegisterSeeker()
        {
            InitializeComponent();
            seekerRepository = new SeekerRepository();
        }

        private void FormRegisterSeeker_Load(object sender, EventArgs e)
        {
            seekerRepository = new SeekerRepository();
            skillRepository = new SkillRepository();
            if(seeker1 != null)
            {
                txtFullname.Text = seeker1.FullName;
                txtLocation.Text = seeker1.Location;
                txtMajor.Text = seeker1.Major;
                txtOverview.Text = seeker1.Overview;
                txtPhone.Text = seeker1.Phone;
                txtPwd.Text = seeker1.Password;
                txtSchool.Text = seeker1.School;
                txtUserName.Text = seeker1.UserName;
            }
            listSkill = skillRepository.GetSkills();
            foreach (var item in listSkill)
            {
                cbSkill.Items.Add(item.SkillName);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public dynamic checkFormat()
        {
            //check duplicate username
            if (seekerRepository.checkDuplicateuserName(txtUserName.Text))
            {
                return new
                {
                    check = false,
                    msg = "duplicate username",
                };
            };

            //check format phone
            if (txtPhone.Text.Length != 10)
            {
                return new
                {
                    check = false,
                    msg = "phone number not correct",
                };
            }


            //no error
            return new
            {
                check = true,
                msg = "no error",
            };
        }

        public int getSkillID(string skillname)
        {
            foreach (var item in listSkill)
            {
                if (skillname.Equals(item.SkillName))
                {
                    return item.SkillId;
                }
            }
            return -1;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text.Length < 5 || txtUserName.Text.Length > 50)
                {
                    MessageBox.Show("username must be in [5;50]");
                    return;
                }
                if (txtPwd.Text.Length < 5 || txtPwd.Text.Length > 50)
                {
                    MessageBox.Show("password must be in [5;50]");
                    return;
                }
                if (txtFullname.Text.Length < 5 || txtFullname.Text.Length > 50)
                {
                    MessageBox.Show("fullname must be in [5;50]");
                    return;
                }
                if (txtLocation.Text.Length < 5 || txtLocation.Text.Length > 50)
                {
                    MessageBox.Show("Location must be in [5;50]");
                    return;
                }
                if (txtSchool.Text.Length < 5 || txtSchool.Text.Length > 50)
                {
                    MessageBox.Show("School must be in [5;50]");
                    return;
                }
                if (txtPhone.Text.Length != 10)
                {
                    MessageBox.Show("Please input phone with 10 digits");
                    return;
                }
                if (txtOverview.Text.Length < 5 || txtOverview.Text.Length > 50)
                {
                    MessageBox.Show("overview must be in [5;50]");
                    return;
                }
                if (txtMajor.Text.Length < 5 || txtMajor.Text.Length > 50)
                {
                    MessageBox.Show("Major must be in [5;50]");
                    return;
                }
                if (cbSkill.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please check at least one skill!");
                    return;
                }

                //get inf seeker
                Seeker seeker = new Seeker
                {
                    UserName = txtUserName.Text,
                    Password = txtPwd.Text,
                    FullName = txtFullname.Text,
                    Balance = 0,
                    Phone = txtPhone.Text,
                    Location = txtLocation.Text,
                    Overview = txtOverview.Text,
                    School = txtSchool.Text,
                    Major = txtMajor.Text
                };
                var checkf = checkFormat();
                if(checkf.check == false)
                {
                    MessageBox.Show(checkf.msg, "register seeker");
                    FormRegisterSeeker formRegisterSeeker = new FormRegisterSeeker
                    {
                        seeker1 = seeker
                    };
                    if(formRegisterSeeker.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
                else
                {
                    //tao user
                    if (seekerRepository.createUser(seeker))
                    {
                        //tạo seeker
                        seeker.UserId = seekerRepository.getSeekerId(seeker);
                        if (seekerRepository.createSeeker(seeker))
                        {
                            //them skill cho seeker
                            bool checkAddSkill = false;
                            foreach (int index in cbSkill.CheckedIndices)
                            {
                                int skillid = getSkillID(cbSkill.Items[index].ToString());
                                if(!skillRepository.addSkill(seeker.UserId, skillid))
                                {
                                    checkAddSkill = true;
                                }
                            }
                            if (checkAddSkill)
                            {
                                MessageBox.Show("add skill seeker fail", "register seeker");
                            }
                            else
                            {
                                MessageBox.Show("create seeker success", "register seeker");
                            }
                        }
                        else
                        {
                            MessageBox.Show("create seeker fail", "register seeker");
                        }

                    }
                    else
                    {
                        MessageBox.Show("can't create user", "register seeker");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "register seeker");
            }
        }

    }
}
