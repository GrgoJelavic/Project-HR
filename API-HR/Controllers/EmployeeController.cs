using API_HR.Models;
using API_HR.ModelsFull;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_HR.Controllers
{
    public class EmployeeController : ApiController
    {
        List<Employees> employees = new List<Employees>();

        public EmployeeController()
        {
            using (HREntities db = new HREntities())
            {
                employees = db.Employees.ToList();
            }
        }

        // GET: api/Employee
        public Object Get()
        {
            List<EmployeeFull> allEmployees = new List<EmployeeFull>();

            using (HREntities db = new HREntities())
            {
                var result = (from empl in db.Employees
                              join branch in db.Branches on empl.BranchID equals branch.BranchID
                              join dept in db.Departments on empl.DepartmentID equals dept.DepartmentID
                              join title in db.JobTitles on empl.JobTitleID equals title.JobTitleID
                              join status in db.EmploymentStatuses on empl.EmploymentStatusID equals status.EmploymentStatusID
                              select new
                              {
                                  empl.EmployeeID,
                                  fName = empl.FirstName,
                                  lName = empl.LastName,
                                  oib = empl.OIB,
                                  gender = empl.Gender,
                                  bDate = empl.BirthdayDate,
                                  address = empl.HomeAdress,
                                  city = empl.City,
                                  postal = empl.PostalCode,
                                  bPlace = empl.PlaceOfBirth,
                                  tel = empl.Telephone,
                                  mob = empl.Mobile,
                                  mail = empl.Email,
                                  emplDate = empl.EmploymentDate,
                                  salary = empl.Salary,
                                  branchID = empl.BranchID,
                                  branch = branch.BranchName,
                                  deptID = empl.DepartmentID,
                                  department = dept.DepartmentName,
                                  titleID = empl.JobTitleID,
                                  title = title.JobTitleName,
                                  statusID = empl.EmploymentStatusID,
                                  status = status.StatusName
                              }).ToList();

                foreach (var elem in result)
                {
                    allEmployees.Add(new EmployeeFull
                    {
                        employeeId = elem.EmployeeID,
                        firstName = elem.fName,
                        lastName = elem.lName,
                        oib = elem.oib.Value,
                        gender = elem.gender,
                        birthdayDate = elem.bDate.Value,
                        homeAddress = elem.address,
                        city = elem.city,
                        postalCode = elem.postal.Value,
                        placeOfBirth = elem.bPlace,
                        telephone = elem.tel,
                        mobile = elem.mob,
                        email = elem.mail,
                        employmentDate = elem.emplDate.Value,
                        salary = elem.salary.Value,
                        branchId = elem.branchID.Value,
                        branchName = elem.branch,
                        departmentId = elem.deptID.Value,
                        departmentName = elem.department,
                        jobTitleId = elem.titleID.Value,
                        jobTitleName = elem.tel,
                        employmentStatusId = elem.statusID.Value,
                        employmentStatusName = elem.status
                    });
                };
            }
            if (allEmployees.Count == 0) return NotFound();
            else return allEmployees;
        }

        // GET: api/Employee/5
        public object Get(int id)
        {
            List<EmployeeFull> employee = new List<EmployeeFull>();

            using (HREntities db = new HREntities())
            {
                var result = (from empl in db.Employees
                              join branch in db.Branches on empl.BranchID equals branch.BranchID
                              join dept in db.Departments on empl.DepartmentID equals dept.DepartmentID
                              join title in db.JobTitles on empl.JobTitleID equals title.JobTitleID
                              join status in db.EmploymentStatuses on empl.EmploymentStatusID equals status.EmploymentStatusID
                              where empl.EmployeeID == id
                              select new
                              {
                                  empl.EmployeeID,
                                  fName = empl.FirstName,
                                  lName = empl.LastName,
                                  oib = empl.OIB,
                                  gender = empl.Gender,
                                  bDate = empl.BirthdayDate,
                                  address = empl.HomeAdress,
                                  city = empl.City,
                                  postal = empl.PostalCode,
                                  bPlace = empl.PlaceOfBirth,
                                  tel = empl.Telephone,
                                  mob = empl.Mobile,
                                  mail = empl.Email,
                                  emplDate = empl.EmploymentDate,
                                  salary = empl.Salary,
                                  branchID = empl.BranchID,
                                  branch = branch.BranchName,
                                  deptID = empl.DepartmentID,
                                  department = dept.DepartmentName,
                                  titleID = empl.JobTitleID,
                                  title = title.JobTitleName,
                                  statusID = empl.EmploymentStatusID,
                                  status = status.StatusName
                              }).ToList();

                foreach (var elem in result)
                {
                    employee.Add(new EmployeeFull
                    {
                        employeeId = elem.EmployeeID,
                        firstName = elem.fName,
                        lastName = elem.lName,
                        oib = elem.oib.Value,
                        gender = elem.gender,
                        birthdayDate = elem.bDate.Value,
                        homeAddress = elem.address,
                        city = elem.city,
                        postalCode = elem.postal.Value,
                        placeOfBirth = elem.bPlace,
                        telephone = elem.tel,
                        mobile = elem.mob,
                        email = elem.mail,
                        employmentDate = elem.emplDate.Value,
                        salary = elem.salary.Value,

                        branchId = elem.branchID.Value,
                        branchName = elem.branch,
                        departmentId = elem.deptID.Value,
                        departmentName = elem.department,
                        jobTitleId = elem.titleID.Value,
                        jobTitleName = elem.title,
                        employmentStatusId = elem.statusID.Value,
                        employmentStatusName = elem.status
                    });
                };
            }
            if (employee.Count == 0) return NotFound();
            else return employee;
        }

        // POST: api/Employee
        public Object Post(Employees employee)
        {
            using (HREntities db = new HREntities())
            {
                try
                {
                    var result = (from row in db.Employees
                                  where row.OIB == employee.OIB
                                  select row).ToList();

                    if (result.Count != 0) return StatusCode((HttpStatusCode)409);

                    db.Employees.Add(employee);
                    db.SaveChanges();

                    return StatusCode((HttpStatusCode)201);
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    return ex.Message;
                }
            }
        }

        // PUT: api/Employee/5
        public Object Put(int id, Employees employee)
        {
            using (HREntities db = new HREntities())
            {
                try
                {
                    var resultCheck = (from row in db.Employees where row.EmployeeID == id select row).ToList();

                    if (resultCheck.Count == 0) return NotFound();

                    var result = (from row in db.Employees
                                  where row.OIB == employee.OIB
                                  select row).ToList();

                    if (result.Count != 0) return StatusCode((HttpStatusCode)409);

                    var query = from Employee in db.Employees where Employee.EmployeeID == id select Employee;

                    foreach (Employees empl in query)
                    {
                        empl.FirstName = employee.FirstName;
                        empl.LastName = employee.LastName;
                        empl.OIB = employee.OIB;
                        empl.Gender = employee.Gender;
                        empl.BirthdayDate = employee.BirthdayDate;
                        empl.HomeAdress = employee.HomeAdress;
                        empl.City = employee.City;
                        empl.PostalCode = employee.PostalCode;
                        empl.Telephone = employee.Telephone;
                        empl.Mobile = employee.Mobile;
                        empl.Email = employee.Email;
                        empl.EmploymentDate = employee.EmploymentDate;
                        empl.Salary = employee.Salary;
                        empl.BranchID = employee.BranchID;
                        empl.DepartmentID = employee.DepartmentID;
                        empl.JobTitleID = employee.JobTitleID;
                        empl.EmploymentStatusID = employee.EmploymentStatusID;
                        empl.OIB = employee.OIB;
                    }
                    db.SaveChanges();

                    return StatusCode((HttpStatusCode)204);
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException x)
                {
                    return x.Message;
                }
            }
        }

        // DELETE: api/Employee/5
        public Object Delete(int id)
        {
            using (HREntities db = new HREntities())
            {
                try
                {
                    Employees employee = employees.Where(x => x.EmployeeID == id).FirstOrDefault();

                    if (employee == null) return NotFound();
                    else
                    {
                        db.Employees.Attach(employee);
                        db.Employees.Remove(employee);
                        db.SaveChanges();
                        return StatusCode((HttpStatusCode)204);
                    }
                }
                catch (System.ArgumentNullException e)
                {
                    return e.Message;
                }
            }
        }
    }
}
