using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Project
    {
        public Project()
        {
            NeededSkills = new HashSet<NeededSkill>();
            Proposals = new HashSet<Proposal>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public int HirerId { get; set; }
        public string Location { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string Major { get; set; }
        public string Complexity { get; set; }
        public string ExpectedDuration { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Hirer Hirer { get; set; }
        public virtual ICollection<NeededSkill> NeededSkills { get; set; }
        public virtual ICollection<Proposal> Proposals { get; set; }
    }
}
