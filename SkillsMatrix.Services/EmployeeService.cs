using SkillsMatrix.Data;
using SkillsMatrix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Services
{
    public class EmployeeService
    {
        private readonly Guid _userId;

        public EmployeeService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateEmployee(EmployeeCreate model)
        {
            var entity =
                new Employee()
                {
                    OwnerId = _userId,
                    EmployeeId = model.EmployeeId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    JobTitle = model.JobTitle,
                    LevelOfEducation = model.LevelOfEducation,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Employees.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<EmployeeListItem> GetEmployees()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Employees
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new EmployeeListItem
                                {
                                    EmployeeId = e.EmployeeId,
                                    FirstName = e.FirstName,
                                    LastName = e.LastName,
                                    JobTitle = e.JobTitle,
                                    LevelOfEducation = e.LevelOfEducation,
                                    CreatedUtc = e.CreatedUtc
                                }
                        );

                return query.ToArray();
            }
        }

        public EmployeeDetail GetEmployeeById(int employeeId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Employees
                        .Single(e => e.EmployeeId == employeeId && e.OwnerId == _userId);
                return
                    new EmployeeDetail
                    {
                        EmployeeId = entity.EmployeeId,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        JobTitle = entity.JobTitle,
                        LevelOfEducation = entity.LevelOfEducation,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }

        public bool UpdateEmployee(EmployeeEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Employees
                        .Single(e => e.EmployeeId == model.EmployeeId && e.OwnerId == _userId);

                entity.EmployeeId = model.EmployeeId;
                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.JobTitle = model.JobTitle;
                entity.LevelOfEducation = model.LevelOfEducation;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteEmployee(int EmployeeId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Employees
                        .Single(e => e.EmployeeId == EmployeeId && e.OwnerId == _userId);

                ctx.Employees.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
