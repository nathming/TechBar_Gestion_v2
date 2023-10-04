using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TechBar_Gestion_v2.Model_bdd_bar
{
    public partial class User
    {
        public int IdUser { get; set; }
        public string Rfidnumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal? Credit { get; set; }
    }
}
