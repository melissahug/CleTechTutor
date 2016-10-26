using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CleTechTutor.Models
{
    public class TechList
    {
        public int TechListID { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Tutor> Tutors { get; set; }
    }
}