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
    public partial class FormSubmitedProposalDetailOfSeeker : Form
    {
        public Proposal proposal;
        ProposalRepository proposalRepository;
        public FormSubmitedProposalDetailOfSeeker()
        {
            InitializeComponent();
        }

        private void FormSubmitedProposalDetailOfSeeker_Load(object sender, EventArgs e)
        {
            try
            {
                proposalRepository = new ProposalRepository();
                txtCreatedDate.Text = proposal.CreatedDate.ToString();
                txtMessage.Text = proposal.Message;
                txtPaymentAmount.Text = proposal.PaymentAmount.ToString();
                txtProjectId.Text = proposal.ProjectId.ToString();
                txtProposalId.Text = proposal.ProposalId.ToString();
                txtSeekerId.Text = proposal.SeekerId.ToString();
                txtStatus.Text = proposal.Status;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "load");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("delete it?", "delete", MessageBoxButtons.OKCancel);
                if(d == DialogResult.OK)
                {
                    if (proposalRepository.deleteProposal(proposal))
                    {
                        MessageBox.Show("delete success", "delete");
                    }
                    else
                    {
                        MessageBox.Show("delete fail", "delete");
                    }
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "delete");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
