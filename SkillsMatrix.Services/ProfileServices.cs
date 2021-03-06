﻿using SkillsMatrix.Data;
using SkillsMatrix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Services
{
    public class ProfileServices
    {
        private readonly Guid _userId;

        public ProfileServices(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateProfile(ProfileCreate model)
        {
            var entity =
                new Profile()
                {
                    OwnerId = _userId,
                    EmployeeId = model.EmployeeId,
                    QualificationId = model.QualificationId,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Profiles.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ProfileListItem> GetProfiles()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Profiles
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new ProfileListItem
                                {
                                    ProfileId = e.ProfileId,
                                    OwnerId = e.OwnerId,
                                    EmployeeId = e.EmployeeId,
                                    LastName = e.Employee.LastName,
                                    FirstName = e.Employee.FirstName,
                                    JobTitle = e.Employee.JobTitle,
                                    NameOfSkill = e.Qualification.NameOfSkill,
                                    LevelOfSkill = e.Qualification.LevelOfSkill,
                                    QualificationId = e.QualificationId,
                                    NameOfCertification = e.Qualification.NameOfCertification,
                                    CreatedUtc = e.CreatedUtc,

                                }
                        );

                return query.ToArray();
            }
        }

        public ProfileDetail GetProfileById(int ProfileId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Profiles
                        .Single(e => e.ProfileId == ProfileId && e.OwnerId == _userId);
                return
                    new ProfileDetail
                    {
                        ProfileId = entity.ProfileId,
                        OwnerId = entity.OwnerId,
                        EmployeeId = entity.EmployeeId,
                        LastName = entity.Employee.LastName,
                        FirstName = entity.Employee.FirstName,
                        JobTitle = entity.Employee.JobTitle,
                        NameOfSkill = entity.Qualification.NameOfSkill,
                        LevelOfSkill = entity.Qualification.LevelOfSkill,
                        QualificationId = entity.QualificationId,
                        NameOfCertification = entity.Qualification.NameOfCertification,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc,
                        
                    };
            }
        }

        public bool UpdateProfile(ProfileEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Profiles
                        .Single(e => e.ProfileId == model.ProfileId && e.OwnerId == _userId);

                entity.ProfileId = model.ProfileId;
                entity.OwnerId = model.OwnerId;
                entity.EmployeeId = model.EmployeeId;
                entity.QualificationId = model.QualificationId;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteProfile(int profileId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Profiles
                        .Single(e => e.ProfileId == profileId && e.OwnerId == _userId);

                ctx.Profiles.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
