﻿using SkillsMatrix.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{
    public class ProfileListItem
    {
        public int ProfileId { get; set; }
        public Guid OwnerId { get; set; }

        public int EmployeeId { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name ="Job Title")]
        public string JobTitle { get; set; }

        [Display(Name ="Skill")]
        public Skill NameOfSkill { get; set; }

        [Display(Name ="Skill Level")]
        public SkillLevel LevelOfSkill { get; set; }

        [Display(Name = "Qualification")]
        public int QualificationId { get; set; }

        [Display(Name ="Certification")]
        public CertificationName NameOfCertification { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
