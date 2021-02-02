using API_HR.BO;
using API_HR.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_HR.Controllers
{
    public class DepartmentController : ApiController
    {
        // GET: api/Department
        public List<DepartmentBO> Get()
        {
            using (HREntities db = new HREntities())
            {
                var allDepartments = new List<Departments>();
                allDepartments = db.Departments.ToList();
                var departmentList = new List<DepartmentBO>();

                foreach (var department in allDepartments)
                {
                    var dept = new DepartmentBO();
                    dept.departmentID = department.DepartmentID;
                    dept.departmentName = department.DepartmentName;

                    departmentList.Add(dept);
                }
                return departmentList;
            }
        }

        // GET: api/Department/5
        public object Get(int id)
        {
            using (HREntities db = new HREntities())
            {
                var allDepartments = new List<Departments>();
                allDepartments = db.Departments.ToList();
                Departments department = allDepartments.Where(x => x.DepartmentID == id).FirstOrDefault();

                if (department == null) return NotFound();

                var dept = new DepartmentBO();
                dept.departmentID = department.DepartmentID;
                dept.departmentName = department.DepartmentName;

                return dept;
            }
        }

        // POST: api/Department
        public object Post(Departments department)
        {
            using (HREntities db = new HREntities())
            {
                try
                {
                    var result = (from row in db.Departments
                                  where
                                  row.DepartmentName == department.DepartmentName
                                  select row).ToList();

                    if (result.Count != 0) return StatusCode((HttpStatusCode)409);

                    db.Departments.Add(department);
                    db.SaveChanges();
                    return StatusCode((HttpStatusCode)201);
                }
                catch (DbEntityValidationException e)
                {
                    return e.Message;
                }
            }
        }

        // PUT: api/Department/5
        public object Put(int id, Departments department)
        {
            using (HREntities db = new HREntities())
            {
                try
                {
                    var resultCheck = (from row in db.Departments where row.DepartmentID == id select row).ToList();

                    if (resultCheck.Count == 0) return NotFound();

                    var result = (from row in db.Departments
                                   where
                                   row.DepartmentName == department.DepartmentName
                                   select row).ToList();

                    if (result.Count != 0) return StatusCode((HttpStatusCode)409);

                    var query = from Department in db.Departments where Department.DepartmentID == id select Department;

                    foreach (Departments dept in query) dept.DepartmentName = department.DepartmentName;

                    db.SaveChanges();
                    return StatusCode((HttpStatusCode)204);
                }
                catch (DbEntityValidationException ex)
                {
                    return ex.Message;
                }
            }
        }

        // DELETE: api/Department/5
        public object Delete(int id)
        {
            using (HREntities db = new HREntities())
            {
                var allDepartments = new List<Departments>();
                allDepartments = db.Departments.ToList<Departments>();

                try
                {
                    Departments department = allDepartments.Where(x => x.DepartmentID == id).FirstOrDefault();
                    if (department == null) return NotFound();
                    else
                    {
                        db.Departments.Attach(department);
                        db.Departments.Remove(department);
                        db.SaveChanges();
                        return StatusCode((HttpStatusCode)204);
                    }
                }
                catch (ArgumentNullException e)
                {
                    return e.Message;
                }
            }
        }

        [Route("api/department/GetFullDepartment")]
        public Dictionary<int, string> GetFullBranch()
        {
            using (HREntities db = new HREntities())
            {
                var allDepartments = new List<Departments>();
                allDepartments = db.Departments.ToList<Departments>();

                var departments = new Dictionary<int, string>();

                foreach (var dept in allDepartments) departments.Add(dept.DepartmentID, dept.DepartmentName);

                return departments;
            }
        }
    }
}
