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
        public int ProfileId { get; set; }
        public int OwnerId { get; set; }
        public int EmployeeId { get; set; }
        public string SkillId { get; set; }
        public string SkillLevel { get; set; }
        public string CertificationName { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
