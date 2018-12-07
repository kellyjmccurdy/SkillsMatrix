using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{
    public enum CertificationName
    {
        ITSQB = 1,
        PMP,
        CSM,
        AWSCertifiedSolutionsArchitect,
        MCSE,
        CISSP,
        CISM,
        CGEIT,
        SixSigmaGreenBelt
    }

    public enum SkillLevel { Beginner = 1, Intermediate, Expert, Master, None }

    public enum Skill
    {
        MicrosoftOffice = 1,
        css,
        html,
        HRIS,
        ProjectManagement,
        SoftwareDevelopment,
        OrganizationalDevelopment,
        TeamBuilding,
        Training,
        Communication,
        Python,
        AngularJS,
        NETCore,
        Testing,
        ProblemSolving,
        Debugging,
        AttentionToDetail,
        UXUI
    }

    public class QualificationListItem
    {
        public int QualificationId { get; set; }
        public int OwnerId { get; set; }
        public int EmployeeId { get; set; }
        public Skill NameOfSkill { get; set; }
        public int YearsOfExperience { get; set; }
        public SkillLevel LevelOfSkill { get; set; }
        public CertificationName NameOfCertification { get; set; }
        public DateTime? CertExpirationDate { get; set; }


        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
