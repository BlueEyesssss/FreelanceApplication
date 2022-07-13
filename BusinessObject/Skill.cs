using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Skill
    {
        public Skill()
        {
            HasSkills = new HashSet<HasSkill>();
            NeededSkills = new HashSet<NeededSkill>();
        }

        public int SkillId { get; set; }
        public string SkillName { get; set; }

        public virtual ICollection<HasSkill> HasSkills { get; set; }
        public virtual ICollection<NeededSkill> NeededSkills { get; set; }
    }
}
