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
                    OwnerId = _userId,
                    EmployeeId = model.EmployeeId,
                    NameOfSkill = model.NameOfSkill,
                    LevelOfSkill = model.LevelOfSkill,
                    YrsOfExperience = model.YrsOfExperience,
                    NameOfCertification = model.NameOfCertification
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Qualifications.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<QualificationListItem> GetQualifications()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Qualifications
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new QualificationListItem
                                {
                                    QualificationId = e.QualificationId,
                                    EmployeeId = e.EmployeeId,
                                    NameOfSkill = e.NameOfSkill,
                                    LevelOfSkill = e.LevelOfSkill,
                                    YrsOfExperience = e.YrsOfExperience,
                                    NameOfCertification = e.NameOfCertification
                                }
                        );

                return query.ToArray();
            }
        }

        public QualificationDetail GetQualificationById(int QualificationId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Qualifications
                        .Single(e => e.QualificationId == QualificationId && e.OwnerId == _userId);
                return
                    new QualificationDetail
                    {
                        QualificationId = entity.QualificationId,
                        OwnerId = entity.OwnerId,
                        EmployeeId = entity.EmployeeId,
                        NameOfSkill = entity.NameOfSkill,
                        LevelOfSkill = entity.LevelOfSkill,
                        YrsOfExperience = entity.YrsOfExperience,
                        NameOfCertification = entity.NameOfCertification,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
    }
}
