using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repository
{
    public interface IProposalRepository
    {
        List<Proposal> getListSubmitedProposal(int seekerid);
        List<Proposal> getListReceivedJob(int seekerid);
        bool createProposal(Proposal proposal);
        Proposal getJobApply(int projectid, int seekerid);
        bool deleteProposal(Proposal proposal);

        List<Proposal> getListProposalSentToHirerID(int ProjectID);

        bool UpdateStatus(int ProposalID, string status);

        bool Update(Proposal Proposal, string status);

    }
}
