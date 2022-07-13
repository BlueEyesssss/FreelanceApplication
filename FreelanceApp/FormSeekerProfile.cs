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
    public partial class FormSeekerProfile : Form
    {
        SeekerRepository seekerRepository;
        SkillRepository skillRepository;
        public Seeker seeker;
        List<Skill> listSkilll;
        public FormSeekerProfile()
        {
            InitializeComponent();
        }

        private void FormSeekerProfile_Load(object sender, EventArgs e)
        {
            try
            {
                seekerRepository = new SeekerRepository();
                skillRepository = new SkillRepository();
                listSkilll = skillRepository.GetSkills();
                txtFullname.Text = seeker.FullName;
                txtLocation.Text = seeker.Location;
                txtMajor.Text = seeker.Major;
                txtOverview.Text = seeker.Overview;
                txtPhone.Text = seeker.Phone;
                txtPwd.Text = seeker.Password;
                txtSchool.Text = seeker.School;
                txtUserName.Text = seeker.UserName;

                //list skill seeker has
                List<string> listSkillSeeker = seekerRepository.getSkillSeekerHas(seeker.SeekerId);

                //load list skill
                bool checkSkillsame = false;
                List<Skill> listSkill = skillRepository.GetSkills();
                foreach (var item in listSkill)
                {
                    checkSkillsame = false;
                    foreach (var skillSeekerhas in listSkillSeeker)
                    {
                        if (item.SkillName.Equals(skillSeekerhas))
                        {
                            cbSkill.Items.Add(item.SkillName, CheckState.Checked);
                            checkSkillsame = true;
                            break;
                        }
                    }
                    if (checkSkillsame == false)
                    {
                        cbSkill.Items.Add(item.SkillName);
                    }
                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "load");
            }
        }

        public dynamic checkFormat()
        {
            //check duplicate username
            //if (seekerRepository.checkDuplicateuserName(txtUserName.Text))
            //{
            //    return new
            //    {
            //        check = false,
            //        msg = "duplicate username",
            //    };
            //};

            //check format phone
            if (txtPhone.Text.Length != 10)
            {
                return new
                {
                    check = false,
                    msg = "phone number not correct",
                };
            }

            //if (txtUserName.Text.Length < 5 || txtUserName.Text.Length > 50)
            //{
            //    return new
            //    {
            //        check = false,
            //        msg = "username must be in [5;50]",
            //    };
            //}
            if (txtPwd.Text.Length < 5 || txtPwd.Text.Length > 50)
            {
                return new
                {
                    check = false,
                    msg = "password must be in [5;50]",
                };
            }
            if (txtFullname.Text.Length < 5 || txtFullname.Text.Length > 50)
            {
                return new
                {
                    check = false,
                    msg = "fullname must be in [5;50]",
                };
            }
            if (txtLocation.Text.Length < 5 || txtLocation.Text.Length > 50)
            {
                return new
                {
                    check = false,
                    msg = "Location must be in [5;50]",
                };
            }
            if (txtSchool.Text.Length < 5 || txtSchool.Text.Length > 50)
            {
                return new
                {
                    check = false,
                    msg = "School must be in [5;50]",
                };
            }

            if (txtPhone.Text.Length != 10)
            {
                return new
                {
                    check = false,
                    msg = "Please input phone with 10 digits",
                };
            }
            if (txtOverview.Text.Length < 5 || txtOverview.Text.Length > 50)
            {
                return new
                {
                    check = false,
                    msg = "overview must be in [5;50]",
                };
            }
            if (txtMajor.Text.Length < 5 || txtMajor.Text.Length > 50)
            {
                return new
                {
                    check = false,
                    msg = "Major must be in [5;50]",
                };
            }
            if (cbSkill.CheckedItems.Count == 0)
            {
                return new
                {
                    check = false,
                    msg = "Please check at least one skill!",
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
            foreach (var item in listSkilll)
            {
                if (skillname.Equals(item.SkillName))
                {
                    return item.SkillId;
                }
            }
            return -1;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var checkf = checkFormat();
                if(checkf.check == false)
                {
                    MessageBox.Show(checkf.msg, "click update");
                    FormSeekerProfile formSeekerProfile = new FormSeekerProfile
                    {
                        seeker = seeker
                    };
                    formSeekerProfile.ShowDialog();
                }
                else
                {
                    //get inf seeker
                    Seeker seeker1 = new Seeker
                    {
                        UserId = seeker.UserId,
                        UserName = txtUserName.Text,
                        Password = txtPwd.Text,
                        FullName = txtFullname.Text,
                        Phone = txtPhone.Text,
                        Location = txtLocation.Text,
                        Overview = txtOverview.Text,
                        School = txtSchool.Text,
                        Major = txtMajor.Text
                    };
                    //xóa hết skill của seeker
                    if (skillRepository.clearAllSkillSeeker(seeker.UserId))
                    {
                        //them skill mới lại cho seeker
                        bool checkAddSkill = false;
                        foreach (int index in cbSkill.CheckedIndices)
                        {
                            int skillid = getSkillID(cbSkill.Items[index].ToString());
                            if (!skillRepository.addSkill(seeker.UserId, skillid))
                            {
                                checkAddSkill = true;
                            }
                        }
                        if (checkAddSkill)
                        {
                            MessageBox.Show("add skill seeker fail", "update seeker");
                        }
                        else
                        {
                            //cập nhật user
                            if (seekerRepository.updateUSer_inSeeker(seeker1))
                            {
                                if (seekerRepository.updateSeeker(seeker1))
                                {
                                    MessageBox.Show("update seeker success", "update seeker");
                                }
                                else
                                {
                                    MessageBox.Show("update seeker fail", "update seeker");
                                }
                            }
                            else
                            {
                                MessageBox.Show("update user fail", "update seeker");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("delete skill fail", "click update");
                    }

                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "click update");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
