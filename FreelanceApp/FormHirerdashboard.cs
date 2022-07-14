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
using DataAccess.repository;

namespace FreelanceApp
{
    public partial class FormHirerdashboard : Form
    {
        public int HirerId; //id cua nguoi hirer dang nhap vao
        IProjectRepository ProjectRepository = new ProjectRepository();
        INeededSkillRepository NeededSkillRepository = new NeededSkillRepository();
        BindingSource source;
        public FormHirerdashboard()
        {
            InitializeComponent();
        }

        private void buttonViewPostedJob_Click(object sender, EventArgs e)
        {

            //List<Project> listP = ProjectRepository.getListProject();

            //List<Project> listPNotStarted = new List<Project>();    //list này đc nhưng mà nó dư 3 att là hirer, needskill, proposal nên xài list dưới
            //List<dynamic> listPNotStarted1 = new List<dynamic>();
            //foreach (var item in listP)
            //{
            //    if (ProjectRepository.checkProjectStarted(item.ProjectId) == false)
            //    {
            //        if (item.HirerId == this.HirerId)
            //        {
            //            listPNotStarted.Add(item);
            //            listPNotStarted1.Add(new
            //            {
            //                ProjectId = item.ProjectId,
            //                ProjectName = item.ProjectName,
            //                Description = item.Description,
            //                HirerId = item.HirerId,
            //                Location = item.Location,
            //                PaymentAmount = item.PaymentAmount,
            //                Major = item.Major,
            //                Complexity = item.Complexity,
            //                ExpectedDuration = item.ExpectedDuration,
            //                CreatedDate = item.CreatedDate
            //            });
            //        }
            //    }
            //}

            LoadPostedProjectList();

            //if (listPNotStarted1.Count != 0)
            //{
            //    dataGridViewListPostedJob.DataSource = listPNotStarted1;

            //}
            //else
            //{
            //    MessageBox.Show("No item in the list");

            //}






        }

        private Project GetProject()
        {
            Project Project = null;
            try
            {
                Project = new Project
                {
                    ProjectId = int.Parse(textBoxProjectId.Text),
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Project");
            }
            return Project;
        }

        private void buttonPostAJob_Click(object sender, EventArgs e)
        {
            FormPostedJobDetail FormPostedJobDetail = new FormPostedJobDetail()
            {
                InsertOrUpdate = false,
                HirerId = this.HirerId,
            };
            FormPostedJobDetail.ShowDialog();
        }

        private void FormHirerdashboard_Load(object sender, EventArgs e)
        {
            dataGridViewAcceptedJob.Visible = false;
            dataGridViewListPostedJob.Visible = true;
            LoadPostedProjectList();
        }

        private void dataGridViewListPostedJob_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormPostedJobDetail FormPostedJobDetail = new FormPostedJobDetail
            {
                InsertOrUpdate = true,
                HirerId = this.HirerId,
                Project = GetProject(),
                
                
                
            };
            FormPostedJobDetail.ShowDialog();
        }

        public void LoadPostedProjectList()
        {
            List<Project> listP = ProjectRepository.getListProject();

            List<Project> listPNotStarted = new List<Project>();    //list này đc nhưng mà nó dư 3 att là hirer, needskill, proposal nên xài list dưới
            List<dynamic> listPNotStarted1 = new List<dynamic>();
            foreach (var item in listP)
            {
                if (ProjectRepository.checkProjectStarted(item.ProjectId) == false)
                {
                    if (item.HirerId == this.HirerId)
                    {
                        listPNotStarted.Add(item);
                        listPNotStarted1.Add(new
                        {
                            ProjectId = item.ProjectId,
                            ProjectName = item.ProjectName,
                            Description = item.Description,
                            HirerId = item.HirerId,
                            Location = item.Location,
                            PaymentAmount = item.PaymentAmount,
                            Major = item.Major,
                            Complexity = item.Complexity,
                            ExpectedDuration = item.ExpectedDuration,
                            CreatedDate = item.CreatedDate
                        });
                    }
                }
            }

            
              

            


            

            try
            {

                
                if (listPNotStarted1.Count != 0)
                {
                    source = new BindingSource();
                    source.DataSource = listPNotStarted1;
                    //
                    textBoxProjectId.DataBindings.Clear();
                    textBoxProjectName.DataBindings.Clear();
                    textBoxDescription.DataBindings.Clear();
                    textBoxLocation.DataBindings.Clear();
                    textBoxPaymentAmount.DataBindings.Clear();
                    textBoxMajor.DataBindings.Clear();
                    textBoxComplexity.DataBindings.Clear();
                    textBoxExpectedDuration.DataBindings.Clear();
                    dateTimePickerCreatedDate.DataBindings.Clear();


                    textBoxProjectId.DataBindings.Add("Text", source, "projectID");
                    textBoxProjectName.DataBindings.Add("Text", source, "projectName");
                    textBoxDescription.DataBindings.Add("Text", source, "description");
                    textBoxLocation.DataBindings.Add("Text", source, "location");
                    textBoxPaymentAmount.DataBindings.Add("Text", source, "paymentAmount");
                    textBoxMajor.DataBindings.Add("Text", source, "major");
                    textBoxComplexity.DataBindings.Add("Text", source, "complexity");
                    textBoxExpectedDuration.DataBindings.Add("Text", source, "expectedDuration");
                    dateTimePickerCreatedDate.DataBindings.Add("Text", source, "createdDate");




                    dataGridViewListPostedJob.DataSource = source;
                }
                
             



               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load posted project list");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadPostedProjectList();
        }

        private void dataGridViewListPostedJob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

<<<<<<< HEAD
        private void buttonDelete_Click(object sender, EventArgs e)
=======
        

        private void buttonDelete_Click_1(object sender, EventArgs e)
>>>>>>> 43cddf4e833966aeea93bbdcdb007f3af21a236e
        {
            try
            {
                var Project = GetProject();
                DialogResult dialogResult = MessageBox.Show("are you sure you want to delete this project?", "Sure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool checkNeededSkill = NeededSkillRepository.DeleteNeedeSkillByProjectID(Project.ProjectId);
                    bool checkDelete = ProjectRepository.Delete(Project.ProjectId);
                    if (checkNeededSkill & checkDelete)
                    {
                        MessageBox.Show("Delee Successfully!");
                        LoadPostedProjectList();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a project");

            }
<<<<<<< HEAD
=======


>>>>>>> 43cddf4e833966aeea93bbdcdb007f3af21a236e
        }



        //private void dataGridViewListPostedJob_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    Project Project = GetProject();
        //    if (memberID == member.memberID)
        //    {
        //        formMemberDetails frmMemberDetails = new formMemberDetails
        //        {
        //            Text = "Update member",
        //            insertOrUpdate = true,
        //            MemberInfor = GetMemberDTO(),
        //            memberRepository = memberRepository
        //        };
        //        if (frmMemberDetails.ShowDialog() == DialogResult.OK)
        //        {
        //            LoadMemberListForMember();
        //            //Set focus member updated
        //            source.Position = source.Count - 1;
        //        }
        //    }
        //    else
        //    {
        //        dataGridViewMemberList.CellDoubleClick += null;

        //    }
        //}

    }
}
