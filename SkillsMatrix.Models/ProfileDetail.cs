using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{
    public class ProfileDetail
    {
        public int ProfileId { get; set; }
        public Guid OwnerId { get; set; }
        public int EmployeeId { get; set; }
        public int QualificationId { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name="Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
        public string EmployeeName { get; set; }

        public override string ToString() => $"[{ProfileId}] {OwnerId}";
    }
}
