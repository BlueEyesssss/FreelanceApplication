using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public decimal? Balance { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }

        public virtual Hirer Hirer { get; set; }
        public virtual Seeker Seeker { get; set; }
    }
}
