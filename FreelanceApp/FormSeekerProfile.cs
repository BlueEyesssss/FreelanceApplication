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
    }
}
