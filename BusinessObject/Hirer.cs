using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Hirer : User
    {
        public Hirer()
        {
            Projects = new HashSet<Project>();
        }

        public int HirerId { get; set; }
        public string CompanyName { get; set; }
        public virtual User HirerNavigation { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
