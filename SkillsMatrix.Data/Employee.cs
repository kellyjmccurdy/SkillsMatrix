using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Data
{
    public enum EducationLevel
    {
    Doctorate = 1,
    Master,
    Bachelor,
    Associate,
    SomeCollege,
    HighSchool
    }

    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = " Job Title")]
        public string JobTitle { get; set; }

        [Required]
        [Display(Name = "Education Level")]
        public EducationLevel LevelOfEducation { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
