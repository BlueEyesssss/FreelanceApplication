using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Seeker: User
    {
        public Seeker()
        {
            HasSkills = new HashSet<HasSkill>();
            Proposals = new HashSet<Proposal>();
        }

        public int SeekerId { get; set; }
        public string Overview { get; set; }
        public string School { get; set; }
        public string Major { get; set; }

        public virtual User SeekerNavigation { get; set; }
        public virtual ICollection<HasSkill> HasSkills { get; set; }
        public virtual ICollection<Proposal> Proposals { get; set; }
    }
}
