using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{
    public class ProfileCreate
    {
        public Guid OwnerId { get; set; }

        [Display(Name ="Employee ID")]
        public int EmployeeId { get; set; }

        [Display(Name ="Qualification ID")]
        public int QualificationId { get; set; }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}
