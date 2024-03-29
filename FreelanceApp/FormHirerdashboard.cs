﻿using System;
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
        IProposalRepository ProposalRepository = new ProposalRepository();
        
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
            buttonDelete.Visible = true;
            dataGridViewListPostedJob.Visible = true;
            dataGridViewAcceptedJob.Visible = false;
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
            dateTimePickerCreatedDate.Enabled = false;
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
            BindingSource source;
            
            List<Project> listP = ProjectRepository.getListProjectByHirerID(this.HirerId);

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
                if (listPNotStarted.Count != 0)
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
                } else
                {
                    source = new BindingSource();
                    textBoxProjectId.DataBindings.Clear();
                    textBoxProjectName.DataBindings.Clear();
                    textBoxDescription.DataBindings.Clear();
                    textBoxLocation.DataBindings.Clear();
                    textBoxPaymentAmount.DataBindings.Clear();
                    textBoxMajor.DataBindings.Clear();
                    textBoxComplexity.DataBindings.Clear();
                    textBoxExpectedDuration.DataBindings.Clear();
                    dateTimePickerCreatedDate.DataBindings.Clear();
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var Project = GetProject();
                DialogResult dialogResult = MessageBox.Show("are you sure you want to delete this project?", "Sure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool checkDeleteProposal = ProposalRepository.deleteAllProposalOfProjectByProjectID(Project.ProjectId);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonDelete.Visible = false;
            dataGridViewListPostedJob.Visible = false;
            dataGridViewAcceptedJob.Visible = true;
            dataGridViewAcceptedJob.DataSource = ProposalRepository.getListProposalAcceptedByHirerID(this.HirerId);
        }

        private void dataGridViewAcceptedJob_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridViewAcceptedJob.Rows[e.RowIndex];
            FormAcceptedJobDetail FormAcceptedJobDetail = new FormAcceptedJobDetail
            {
                Proposal = new Proposal
                {
                    ProposalId = int.Parse(row.Cells[0].Value.ToString()),
                    ProjectId = int.Parse(row.Cells[1].Value.ToString()),
                    SeekerId = int.Parse(row.Cells[2].Value.ToString()),
                    PaymentAmount = decimal.Parse(row.Cells[3].Value.ToString()),
                    Message = row.Cells[4].Value.ToString(),
                    Status = row.Cells[5].Value.ToString(),
                    CreatedDate = DateTime.Parse(row.Cells[6].Value.ToString()),
                    Project = (Project)row.Cells[7].Value,
                    Seeker = (Seeker)row.Cells[8].Value,

                },
            };

            FormAcceptedJobDetail.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHirerProfile FormHirerProfile = new FormHirerProfile
            {
                HirerId = this.HirerId,
            };
            FormHirerProfile.ShowDialog();
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
