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
        public int EmployeeId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        public int SkillId { get; set; }

        public string SkillLevel { get; set; }

        public int CertificationId { get; set; }


        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
