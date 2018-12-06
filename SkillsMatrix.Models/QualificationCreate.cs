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
        public int SkillId { get; set; }

        [Range(1, 30)]
        public int YearsOfExperience { get; set; }
        public string SkillLevel { get; set; }
        public string Certification { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
