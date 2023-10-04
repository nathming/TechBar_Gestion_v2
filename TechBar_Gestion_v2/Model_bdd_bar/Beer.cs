using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TechBar_Gestion_v2.Model_bdd_bar
{
    public partial class Beer
    {
        public int Idbeer { get; set; }
        public string Nom { get; set; }
        public decimal? Price { get; set; }
        public int? Stock { get; set; }
        public string Description { get; set; }
    }
}
