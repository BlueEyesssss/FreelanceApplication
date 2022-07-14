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
    public partial class FormProposalSentOfHirer : Form
    {
        public Proposal proposal;
        IProposalRepository ProposalRepository = new ProposalRepository();
        public FormProposalSentOfHirer()
        {
            InitializeComponent();
        }

        private void FormProposalSentOfHirer_Load(object sender, EventArgs e)
        {
            try
            {
                ProposalRepository = new ProposalRepository();
                txtCreatedDate.Text = proposal.CreatedDate.ToString();
                txtMessage.Text = proposal.Message;
                txtPaymentAmount.Text = proposal.PaymentAmount.ToString();
                txtProjectId.Text = proposal.ProjectId.ToString();
                txtProposalId.Text = proposal.ProposalId.ToString();
                txtSeekerId.Text = proposal.SeekerId.ToString();
                txtStatus.Text = proposal.Status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "load");
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            bool check = ProposalRepository.UpdateStatus(proposal.ProposalId, "job started");
            if (check)
            {
                MessageBox.Show("Update successfully!");
            }
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            bool check = ProposalRepository.UpdateStatus(proposal.ProposalId, "proposal rejected");
            if (check)
            {
                MessageBox.Show("reject successfully!");
            }
        }
    }
}
