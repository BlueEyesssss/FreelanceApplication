using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Proposal
    {
        public int ProposalId { get; set; }
        public int ProjectId { get; set; }
        public int SeekerId { get; set; }
        public decimal? PaymentAmount { get; set; }

        public string? Message { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Project Project { get; set; }
        public virtual Seeker Seeker { get; set; }
    }
}
