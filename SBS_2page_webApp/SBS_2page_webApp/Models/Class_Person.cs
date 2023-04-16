using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SBS_2page_webApp.Models
{
    public class Class_Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }

    }
}