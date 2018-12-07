using SkillsMatrix.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{
    public class EmployeeEdit
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public EducationLevel LevelOfEducation { get; set; }
    }
}
