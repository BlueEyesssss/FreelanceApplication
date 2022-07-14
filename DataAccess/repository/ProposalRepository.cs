using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repository
{
    public class ProposalRepository : IProposalRepository
    {
        public bool createProposal(Proposal proposal) => ProposalDAO.Instance.createProposal(proposal);

        public bool deleteProposal(Proposal proposal) => ProposalDAO.Instance.deleteProposal(proposal);

        public Proposal getJobApply(int projectid, int seekerid) => ProposalDAO.Instance.getJobApply(projectid, seekerid);

        public List<Proposal> getListReceivedJob(int seekerid) => ProposalDAO.Instance.getListReceivedJob(seekerid);

        public List<Proposal> getListSubmitedProposal(int seekerid) => ProposalDAO.Instance.getListSubmitedProposal(seekerid);

        public List<Proposal> getListProposalSentToHirerID(int ProjectID) => ProposalDAO.Instance.getListProposalSentToHirerID(ProjectID);

        public bool UpdateStatus(int ProposalID, string status) => ProposalDAO.Instance.UpdateStatus(ProposalID, status);

        public bool Update(Proposal Proposal, string status) => ProposalDAO.Instance.Update(Proposal, status);

        public List<Proposal> getListProposalAcceptedByHirerID(int HirerID) => ProposalDAO.Instance.getListProposalAcceptedByHirerID(HirerID);

        public bool deleteAllProposalOfProjectByProjectID(int ProjectID) => ProposalDAO.Instance.deleteAllProposalOfProjectByProjectID(ProjectID);
    }
}
