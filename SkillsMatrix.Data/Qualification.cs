﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Data
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
        CSS,
        HTML,
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

    public class Qualification
    {
        [Key]
        public int QualificationId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "Skill")]
        public Skill NameOfSkill { get; set; }

        [Required]
        [Display(Name = "Skill Level")]
        public SkillLevel LevelOfSkill { get; set; }

        [Display(Name = "Years of Experience")]
        public int YrsOfExperience { get; set; }

        [Display(Name = "Certification")]
        public CertificationName NameOfCertification { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}

