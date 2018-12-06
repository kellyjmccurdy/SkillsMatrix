using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{
    public class ProfileCreate
    {
        public int SkillId { get; set; }
        public string SkillLevel { get; set; }
        public string CertificationName { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
