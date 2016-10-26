using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CleTechTutor.Models
{
    public class Tutor
    {
        [Key]
        public int TutorID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string LearningPath { get; set; }

        [ForeignKey("TechList")]
        public int TechListID { get; set; }
        public virtual TechList TechList { get; set; }
       
    }
}