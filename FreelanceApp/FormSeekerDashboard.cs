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
    public partial class FormSeekerDashboard : Form
    {
        public int seekerid;
        ProjectRepository projectRepository;
        ProposalRepository proposalRepository;
        SeekerRepository seekerRepository;
        public FormSeekerDashboard()
        {
            InitializeComponent();
            projectRepository = new ProjectRepository();
            proposalRepository = new ProposalRepository();
        }

        private void FormSeekerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btViewListJob_Click(object sender, EventArgs e)
        {
            try
            {
                clearField();
                dataGridViewListJob.Visible = true;
                dataGridViewListProposal.Visible = false;
                dataGridViewReceivedJobList.Visible = false;
                //get list project
                List<Project> listP = projectRepository.getListProject();
                if (listP != null)
                {
                    //get list job not started
                    List<Project> listPNotStarted = new List<Project>();    //list này đc nhưng mà nó dư 3 att là hirer, needskill, proposal nên xài list dưới
                    List<dynamic> listPNotStarted1 = new List<dynamic>();
                    foreach (var item in listP)
                    {
                        if (projectRepository.checkProjectStarted(item.ProjectId) == false)
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
                    dataGridViewListJob.DataSource = null;
                    dataGridViewListJob.DataSource = listPNotStarted1;
                }
                else
                {
                    MessageBox.Show("no job not started", "View list job");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "View list job");
            }
        }
        public void clearField()
        {
            txtComplexity.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtLocation.Text = string.Empty;
            txtMajor.Text = string.Empty;
            txtPaymentAmount.Text = string.Empty;
            txtProjectName.Text = string.Empty;
            txtSkillNeed.Text = string.Empty;
        }
        private void dataGridViewListJob_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clearField();
                if (e.RowIndex == -1) return;
                DataGridViewRow row = dataGridViewListJob.Rows[e.RowIndex];

                txtProjectID.Text = row.Cells[0].Value.ToString();
                txtProjectName.Text = row.Cells[1].Value.ToString();
                txtDescription.Text = row.Cells[2].Value.ToString();
                txtHirerID.Text = row.Cells[3].Value.ToString();
                txtLocation.Text = row.Cells[4].Value.ToString();
                txtPaymentAmount.Text = row.Cells[5].Value.ToString();
                txtMajor.Text = row.Cells[6].Value.ToString();
                txtComplexity.Text = row.Cells[7].Value.ToString();
                dtpCreateday.Value = DateTime.Parse(row.Cells[9].Value.ToString());
                dtpExpedtedDay.Text = row.Cells[8].Value.ToString();

                //get skill project need
                //txtSkillNeed.Text = projectRepository.getSkillProjectNeed(int.Parse(row.Cells[0].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " click row of list job");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewListJob.Visible = false;
                dataGridViewListProposal.Visible = true;
                dataGridViewReceivedJobList.Visible = false;
                clearField();
                List<Proposal> listP = proposalRepository.getListSubmitedProposal(seekerid);
                //lọc lại
                List<dynamic> listSubmitedP = new List<dynamic>();
                foreach (var item in listP)
                {
                    listSubmitedP.Add(new
                    {
                        ProposalId = item.ProposalId,
                        ProjectId = item.ProjectId,
                        SeekerId = item.SeekerId,
                        PaymentAmount = item.PaymentAmount,
                        Message = item.Message,
                        Status = item.Status,
                        CreatedDate = item.CreatedDate,
                    });
                }
                dataGridViewListProposal.DataSource = null;
                dataGridViewListProposal.DataSource = listSubmitedP;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "view list subted proposal");
            }
        }

        private void btViewReceivedJob_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewListJob.Visible = false;
                dataGridViewListProposal.Visible = false;
                dataGridViewReceivedJobList.Visible = true;
                clearField();
                List<Proposal> listP = proposalRepository.getListReceivedJob(seekerid);
                //lọc lại
                List<dynamic> listReceivedP = new List<dynamic>();
                foreach (var item in listP)
                {
                    listReceivedP.Add(new
                    {
                        ProposalId = item.ProposalId,
                        ProjectId = item.ProjectId,
                        SeekerId = item.SeekerId,
                        PaymentAmount = item.PaymentAmount,
                        Message = item.Message,
                        Status = item.Status,
                        CreatedDate = item.CreatedDate,
                    });
                }
                dataGridViewReceivedJobList.DataSource = null;
                dataGridViewReceivedJobList.DataSource = listReceivedP;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "view list subted proposal");
            }
        }

        private void dataGridViewListJob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewListJob.Rows[e.RowIndex];

                //check xem seeker apply chua
                Proposal proposalApplied = proposalRepository.getJobApply(int.Parse(row.Cells[0].Value.ToString()), seekerid);
                if (proposalApplied != null)
                {
                    //đã gửi apply r
                    FormApplyJob formApplyJob = new FormApplyJob
                    {
                        proposal1 = proposalApplied,
                        applied = true,
                    };
                    if (formApplyJob.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
                else
                {
                    //chua gui đơn apply
                    FormApplyJob formApplyJob = new FormApplyJob
                    {
                        project = new Project
                        {
                            ProjectId = int.Parse(row.Cells[0].Value.ToString()),
                            ProjectName = row.Cells[1].Value.ToString(),
                            Description = row.Cells[2].Value.ToString(),
                            HirerId = int.Parse(row.Cells[3].Value.ToString()),
                            Location = row.Cells[4].Value.ToString(),
                            PaymentAmount = decimal.Parse(row.Cells[5].Value.ToString()),
                            Major = row.Cells[6].Value.ToString(),
                            Complexity = row.Cells[7].Value.ToString(),
                            CreatedDate = DateTime.Parse(row.Cells[9].Value.ToString()),
                            ExpectedDuration = row.Cells[8].Value.ToString() + "",
                        },
                        seekerid = seekerid,
                    };
                    if (formApplyJob.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "click row job");
            }
        }

        private void dataGridViewListProposal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clearField();
                if (e.RowIndex == -1) return;
                DataGridViewRow row = dataGridViewListProposal.Rows[e.RowIndex];
                Proposal proposalDetail = new Proposal
                {
                    ProposalId = int.Parse(row.Cells[0].Value.ToString()),
                    ProjectId = int.Parse(row.Cells[1].Value.ToString()),
                    SeekerId = int.Parse(row.Cells[2].Value.ToString()),
                    PaymentAmount = decimal.Parse(row.Cells[3].Value.ToString()),
                    Message = row.Cells[4].Value.ToString(),
                    Status = row.Cells[5].Value.ToString(),
                    CreatedDate = DateTime.Parse(row.Cells[6].Value.ToString()),
                };
                FormSubmitedProposalDetailOfSeeker formSubmitedProposalDetailOfSeeker = new FormSubmitedProposalDetailOfSeeker
                {
                    proposal = proposalDetail
                };
                if (formSubmitedProposalDetailOfSeeker.ShowDialog() == DialogResult.OK)
                {
                    //load list again
                    dataGridViewListJob.Visible = false;
                    dataGridViewListProposal.Visible = true;
                    dataGridViewReceivedJobList.Visible = false;
                    clearField();
                    List<Proposal> listP = proposalRepository.getListSubmitedProposal(seekerid);
                    //lọc lại
                    List<dynamic> listSubmitedP = new List<dynamic>();
                    foreach (var item in listP)
                    {
                        listSubmitedP.Add(new
                        {
                            ProposalId = item.ProposalId,
                            ProjectId = item.ProjectId,
                            SeekerId = item.SeekerId,
                            PaymentAmount = item.PaymentAmount,
                            Message = item.Message,
                            Status = item.Status,
                            CreatedDate = item.CreatedDate,
                        });
                    }
                    dataGridViewListProposal.DataSource = null;
                    dataGridViewListProposal.DataSource = listSubmitedP;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "click row submited proposal");
            }
        }

        private void btViewProfile_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    seekerRepository = new SeekerRepository();
                    Seeker seeker = seekerRepository.GetListSeekerByid(seekerid)[0];
                    FormSeekerProfile formSeekerProfile = new FormSeekerProfile
                    {
                        seeker = seeker
                    };
                    formSeekerProfile.ShowDialog();
                }
                catch (Exception ex)
                {
                }
            }

        }
    }
}        

