using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{
    public class ProfileCreate
    {
        [Required]
        public int ProfileId { get; set; }
        public Guid OwnerId { get; set; }
        public int EmployeeId { get; set; }
        public int QualificationId { get; set; }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}
