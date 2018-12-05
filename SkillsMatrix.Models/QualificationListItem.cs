using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{
    public class QualificationListItem
    {
        public int QualificationId { get; set; }
        public int SkillsId { get; set; }
        public int YearsOfExperience { get; set; }
        public string SkillLevel { get; set; }
        public string Certification { get; set; }


        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
