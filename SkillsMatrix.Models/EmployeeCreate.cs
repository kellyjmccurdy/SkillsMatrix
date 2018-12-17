using SkillsMatrix.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{

    public class EmployeeCreate
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name ="Job Title")]
        public string JobTitle { get; set; }

        [Display(Name ="Education Level")]
        public EducationLevel LevelOfEducation { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
