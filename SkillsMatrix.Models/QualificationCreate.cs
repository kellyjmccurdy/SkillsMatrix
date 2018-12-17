using SkillsMatrix.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{
    public class QualificationCreate
    {
        [Key]
        public int QualificationId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "Skill")]
        public Skill NameOfSkill { get; set; }

        [Range(1, 30)]
        [Display(Name = "Years of Experience")]
        public int YrsOfExperience { get; set; }

        [Required]
        [Display(Name = "Skill Level")]
        public SkillLevel LevelOfSkill { get; set; }

        [Display(Name = "Certification")]
        public CertificationName NameOfCertification { get; set; }
        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
