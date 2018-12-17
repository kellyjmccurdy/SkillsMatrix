using SkillsMatrix.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{
    public class ProfileListItem
    {
        [Display(Name ="Profile ID")]
        public int ProfileId { get; set; }
        public Guid OwnerId { get; set; }

        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Qualification ID")]
        public int QualificationId { get; set; }

        [Display(Name = "Skill")]
        public Skill NameOfSkill { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
