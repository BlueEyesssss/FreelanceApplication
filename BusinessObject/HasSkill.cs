using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class HasSkill
    {
        public int HasSkillId { get; set; }
        public int SeekerId { get; set; }
        public int SkillId { get; set; }

        public virtual Seeker Seeker { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
