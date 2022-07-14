using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class ProjectHasSkill
    {
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

        public string SkillNeed { get; set; }

        public int matchSkill { get; set; }
    }
}
