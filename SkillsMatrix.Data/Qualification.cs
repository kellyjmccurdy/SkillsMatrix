﻿using System;
using System.Collections.Generic;
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

    public enum SkillLevel { Beginner = 1, Intermediate, Expert, Master }

    public enum SkillId
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

    public class Qualification
    {
        public int QualificationId { get; set; }
        public int SkillsId { get; set; }
        public int YrsOfExperience { get; set; }
        public CertificationName NameOfCertification { get; set; }
        public SkillLevel LevelOfSkill { get; set; }
    }
}
