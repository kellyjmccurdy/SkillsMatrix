using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Data
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }

        [Required]
        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }

        [Display(Name = "Qualification ID")]
        public int QualificationId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Qualification Qualification { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
