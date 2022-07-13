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
    public partial class FormPostedJobDetail : Form
    {
        public bool InsertOrUpdate; //true co nghia la update
        public int HirerId; // id cua nguoi hirer dang nhap vao
        public Project Project; //dung khi update mot Project, dua thong tin cua Project do qua
        ISkillRepository SkillRepository = new SkillRepository();
        IProjectRepository ProjectRepository = new ProjectRepository();
        INeededSkillRepository NeededSkillRepository = new NeededSkillRepository();

        public FormPostedJobDetail()
        {
            InitializeComponent();
        }

        private void FormPostedJobDetail_Load(object sender, EventArgs e)
        {
            //hien thi list skill len
            List<Skill> ListSkill = SkillRepository.GetSkills();
            string[] StringListSkill = new string[ListSkill.Count];

            int i = 0; //coi chung co loi phan nay
            foreach (Skill skill in ListSkill)
            {
                StringListSkill[i] = skill.SkillName;
                i++;
            }
            checkedListBoxSkill.Items.AddRange(StringListSkill);
            checkedListBoxSkill.CheckOnClick = true;


            if (InsertOrUpdate == false) //co nghia la insert
            {
                buttonWithDraw.Visible = false;
                dateTimePickerCreatedDate.Value = DateTime.UtcNow.Date;
                dateTimePickerCreatedDate.Enabled = false;
                textBoxProjectID.Visible = false;
                textBoxProjectID.Enabled = false;

            }
            else //code cho update
            {
                
                buttonWithDraw.Visible = false;
                textBoxProjectID.Text = Project.ProjectId.ToString();
                textBoxProjectName.Text = Project.ProjectName.ToString();
                textBoxDescription.Text = Project.Description.ToString();
                textBoxLocation.Text = Project.Location.ToString();
                textBoxPaymentAmount.Text = Project.PaymentAmount.ToString();
                textBoxMajor.Text = Project.Major.ToString();
                textBoxComplexity.Text = Project.Complexity.ToString();
                textBoxExpectedDuration.Text = Project.ExpectedDuration.ToString();
                dateTimePickerCreatedDate.Value = (DateTime)Project.CreatedDate;



                List<Skill> listSkillNeededInProject = NeededSkillRepository.GetSkillByProjectID(this.Project.ProjectId);
                List<String> listStringSkillNeededInProject = new List<String>();
                foreach (Skill skill in listSkillNeededInProject)
                {
                    listStringSkillNeededInProject.Add(skill.SkillName);
                }

                for (int count = 0; count < checkedListBoxSkill.Items.Count; count++)
                {
                    if (listStringSkillNeededInProject.Contains(checkedListBoxSkill.Items[count].ToString()))
                    {
                        checkedListBoxSkill.SetItemChecked(count, true);
                    }
                }


            }



            



            
            
            
            
            

        }

        private void SelectAllCheckBoxes(bool CheckThem)
        {
            for (int i = 0; i <= (checkedListBoxSkill.Items.Count - 1); i++)
            {
                if (CheckThem)
                {
                    checkedListBoxSkill.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    checkedListBoxSkill.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {


                if (checkedListBoxSkill.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please check at least one skill!");
                    return;
                }
                if (textBoxProjectName.Text.Length < 5 || textBoxProjectName.Text.Length > 50)
                {
                    MessageBox.Show("Please input project name in [5; 50] characters");
                    return;
                }
                if (textBoxDescription.Text.Length < 5 || textBoxDescription.Text.Length > 500)
                {
                    MessageBox.Show("Please input project description in [5; 500] characters");
                    return;
                }
                if (textBoxLocation.Text.Length < 5 || textBoxLocation.Text.Length > 50)
                {
                    MessageBox.Show("Please input location in [5; 50] characters");
                    return;
                }
                if (Decimal.Parse(textBoxPaymentAmount.Text) < 0 || Decimal.Parse(textBoxPaymentAmount.Text) > 1000)
                {
                    MessageBox.Show("The value of payment amount must be in [0; 1000]$");
                }
                if (textBoxMajor.Text.Length < 5 || textBoxMajor.Text.Length > 50)
                {
                    MessageBox.Show("Please input major in [5; 50] characters");
                    return;
                }
                if (textBoxComplexity.Text.Length < 5 || textBoxComplexity.Text.Length > 50)
                {
                    MessageBox.Show("Please input complexity in [5; 50] characters");
                    return;
                }
                if (textBoxExpectedDuration.Text.Length < 5 || textBoxExpectedDuration.Text.Length > 50)
                {
                    MessageBox.Show("Please input expecte duration in [5; 50] characters");
                    return;
                }






                //get inf seeker
                //Project Project = new Project
                //{   
                //    ProjectId = int.Parse(textBoxProjectID.Text),
                //    ProjectName = textBoxProjectName.Text,
                //    Description = textBoxDescription.Text,
                //    HirerId = this.HirerId,
                //    Location = textBoxLocation.Text,
                //    PaymentAmount = Decimal.Parse(textBoxPaymentAmount.Text),
                //    Major = textBoxMajor.Text,
                //    Complexity = textBoxComplexity.Text,
                //    ExpectedDuration = textBoxExpectedDuration.Text,
                //    CreatedDate = DateTime.UtcNow.Date,
                //};

                if (InsertOrUpdate == false) {
                    Project Project = new Project
                    {
                        
                        ProjectName = textBoxProjectName.Text,
                        Description = textBoxDescription.Text,
                        HirerId = this.HirerId,
                        Location = textBoxLocation.Text,
                        PaymentAmount = Decimal.Parse(textBoxPaymentAmount.Text),
                        Major = textBoxMajor.Text,
                        Complexity = textBoxComplexity.Text,
                        ExpectedDuration = textBoxExpectedDuration.Text,
                        CreatedDate = DateTime.UtcNow.Date,
                    };

                    bool check = ProjectRepository.CreateProject(Project);

                    List<Skill> ListSkill = SkillRepository.GetSkills(); // lay duoc tat cac skill

                    var selectedSkills = new List<string>();
                    foreach (var skill in checkedListBoxSkill.CheckedItems)
                    {
                        selectedSkills.Add(skill.ToString()); // cho nay neu nguoi dung ko chon la an cam
                    }

                    int ProjectId = ProjectRepository.getProjectIDByProject(Project);
                    bool checkSkill = false;
                    foreach (Skill skill in ListSkill)
                    {
                        foreach (String selectedSkill in selectedSkills)
                        {
                            if (skill.SkillName == selectedSkill)
                            {
                                NeededSkill NeededSkill = new NeededSkill
                                {
                                    ProjectId = ProjectId,
                                    SkillId = skill.SkillId,
                                };
                                checkSkill = NeededSkillRepository.Create(NeededSkill);
                            }
                        }
                    }

                    if (check & checkSkill)
                    {
                        MessageBox.Show("Post successfully!");
                        this.Close();

                    }
                    

                } else //update
                {
                    
                    Project Project = new Project
                    {
                        ProjectId = int.Parse(textBoxProjectID.Text),
                        ProjectName = textBoxProjectName.Text,
                        Description = textBoxDescription.Text,
                        HirerId = this.HirerId,
                        Location = textBoxLocation.Text,
                        PaymentAmount = Decimal.Parse(textBoxPaymentAmount.Text),
                        Major = textBoxMajor.Text,
                        Complexity = textBoxComplexity.Text,
                        ExpectedDuration = textBoxExpectedDuration.Text,
                        CreatedDate = DateTime.UtcNow.Date,
                    };

                    bool check = ProjectRepository.Update(Project);
                    var selectedSkills = new List<string>();
                    

                    bool deleteSkill = NeededSkillRepository.DeleteNeedeSkillByProjectID(Project.ProjectId);// xoa het skill cua 1 project


                    bool checkNeededSkill = false;
                    foreach (var skill in checkedListBoxSkill.CheckedItems)
                    {
                        selectedSkills.Add(skill.ToString()); // cho nay neu nguoi dung ko chon la an cam
                    }
                    int ProjectId = ProjectRepository.getProjectIDByProject(Project);
                    List<Skill> ListSkill = SkillRepository.GetSkills();
                    
                    foreach (Skill skill in ListSkill)
                    {
                        foreach (String selectedSkill in selectedSkills)
                        {
                            if (skill.SkillName == selectedSkill)
                            {
                                NeededSkill NeededSkill = new NeededSkill
                                {
                                    ProjectId = ProjectId,
                                    SkillId = skill.SkillId,
                                };
                                checkNeededSkill = NeededSkillRepository.Create(NeededSkill);
                            }
                        }
                    }

                    if (check)
                    {
                        MessageBox.Show("Update successfully!");
                        this.Close();

                    }
                }

                






                




            
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "post/edit a job - hirer");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPaymentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
