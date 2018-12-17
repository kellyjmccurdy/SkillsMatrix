using SkillsMatrix.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{
   public class QualificationEdit
    {
        public int QualificationId { get; set; }
        public Guid OwnerId { get; set; }
        public int EmployeeId { get; set; }

        [Display(Name = "Skill")]
        public Skill NameOfSkill { get; set; }

        [Display(Name = "Years of Experience")]
        public int YrsOfExperience { get; set; }

        [Display(Name = "Skill Level")]
        public SkillLevel LevelOfSkill { get; set; }

        [Display(Name = "Certification")]
        public CertificationName NameOfCertification { get; set; }
    }
}
