using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class NeededSkill
    {
        public int NeededSkillsId { get; set; }
        public int ProjectId { get; set; }
        public int SkillId { get; set; }

        public virtual Project Project { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
