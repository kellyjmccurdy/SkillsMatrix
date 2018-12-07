using SkillsMatrix.Data;
using SkillsMatrix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Services
{
    public class QualificationService
    {
        private readonly Guid _userId;

        public QualificationService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateQualification(QualificationCreate model)
        {
            var entity =
                new Qualification()
                {
                    
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Qualifications.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
