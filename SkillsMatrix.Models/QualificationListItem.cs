﻿using SkillsMatrix.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Models
{
    public class QualificationListItem
    {
        public int QualificationId { get; set; }
        public Guid OwnerId { get; set; }
        public int EmployeeId { get; set; }
        public Skill NameOfSkill { get; set; }
        public int YrsOfExperience { get; set; }
        public SkillLevel LevelOfSkill { get; set; }
        public CertificationName NameOfCertification { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
