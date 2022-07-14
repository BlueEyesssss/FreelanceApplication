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
    public partial class FormAcceptedJobDetail : Form
    {
        public Proposal Proposal;
        IProposalRepository ProposalRepository = new ProposalRepository();
        public FormAcceptedJobDetail()
        {
            InitializeComponent();
        }

        private void FormAcceptedJobDetail_Load(object sender, EventArgs e)
        {
            try
            {

                dateTimePickerCreatedDate.Text = Proposal.CreatedDate.ToString();
                textBoxMessage.Text = Proposal.Message;
                textBoxPaymentAmount.Text = Proposal.PaymentAmount.ToString();
                textBoxProjectName.Text = Proposal.Project.ProjectName.ToString();
                textBoxDescription.Text = Proposal.Project.Description.ToString();
                textBoxLocation.Text = Proposal.Project.Location.ToString();
                textBoxComplexity.Text = Proposal.Project.Complexity.ToString();
                textBoxExpectedDuration.Text = Proposal.Project.ExpectedDuration.ToString();


                textBoxSeekerName.Text = Proposal.Seeker.FullName.ToString();

                textBoxMajor.Text = Proposal.Seeker.Major.ToString();
                textBoxPhone.Text = Proposal.Seeker.Phone.ToString();







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "load");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
