using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{
    public class ProfileEdit
    {
        public int ProfileId { get; set; }
        public Guid OwnerId { get; set; }
        public int EmployeeId { get; set; }
        public int QualificationId { get; set; }
    }
}
