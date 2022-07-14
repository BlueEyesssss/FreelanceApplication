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
    public partial class FormApplyJob : Form
    {
        public Project project;
        ProposalRepository proposalRepository;
        public int seekerid;

        public bool applied = false;
        public Proposal proposal1;
        public string Message;
        public string paymentamount;

        public FormApplyJob()
        {
            InitializeComponent();
        }

        private void FormApplyJob_Load(object sender, EventArgs e)
        {
            proposalRepository = new ProposalRepository();
            if (applied == true)
            {
                txtMessage.Text = proposal1.Message;
                txtPaymentAmount.Text = proposal1.PaymentAmount.ToString();
                txtMessage.Enabled = false;
                txtPaymentAmount.Enabled = false;
                btApplying.Enabled = false;
            }
            else if (Message != null && paymentamount != null)
            {
                txtMessage.Text = Message;
                txtPaymentAmount.Text = paymentamount.ToString();
            }
        }

        public dynamic checkFormat()
        {
            try
            {
                if (txtMessage.Text.Length <= 0 || txtMessage.Text.Length > 255)
                {
                    return new
                    {
                        check = false,
                        msg = "message must be [1..255] character",
                    };
                }
                if (decimal.Parse(txtPaymentAmount.Text) <= 0)
                {
                    return new
                    {
                        check = false,
                        msg = "number must be large than 0",
                    };
                }
            }
            catch
            {
                return new
                {
                    check = false,
                    msg = "number must be a number",
                };
            }
            return new
            {
                check = true,
                msg = "no error",
            };
        }

        private void btApplying_Click(object sender, EventArgs e)
        {
            try
            {
                
                var checkf = checkFormat();
                if (checkf.check == false)
                {
                    MessageBox.Show(checkf.msg, "applying job");
                    FormApplyJob formApplyJob = new FormApplyJob
                    {
                        project = new Project
                        {
                            ProjectId = project.ProjectId
                        },
                        seekerid = seekerid,
                        Message = txtMessage.Text,
                        paymentamount = txtPaymentAmount.Text
                    };
                    formApplyJob.ShowDialog();
                }
                else
                {
                    Proposal proposal = new Proposal
                    {
                        ProjectId = project.ProjectId,
                        SeekerId = seekerid,
                        PaymentAmount = decimal.Parse(txtPaymentAmount.Text),
                        Status = "proposal sent",
                        Message = txtMessage.Text,
                    };
                    if (proposalRepository.createProposal(proposal))
                    {
                        MessageBox.Show("sent success", "applying job");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("sent fail", "applying job");
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("payment amount must be a number", "applying job");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "applying job");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
