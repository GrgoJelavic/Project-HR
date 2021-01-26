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
    public class ValuesController : ApiController
    {
        public ValuesController()
        {
            using (HREntities db = new HREntities())
            {
                List<Employees> employees = db.Employees.ToList<Employees>();
            }
        }

        [HttpGet]
        [Route("api/values")]
        // GET api/values
        public object Get()
        {
            List<EmployeesByAttribute> allEmployees = new List<EmployeesByAttribute>();

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
                                  bID = empl.BranchID,
                                  branch = branch.BranchName,
                                  dID = empl.DepartmentID,
                                  department = dept.DepartmentName,
                                  tID = empl.JobTitleID,
                                  title = title.JobTitleName,
                                  sID = empl.EmploymentStatusID,
                                  status = status.StatusName
                              }).ToList();

                foreach (var elem in result)
                {
                    allEmployees.Add(new EmployeesByAttribute
                    {
                        employeeId = elem.EmployeeID,
                        firstName = elem.fName,
                        lastName = elem.lName,
                        bID = (int)elem.bID,
                        branch = elem.branch,
                        dID = (int)elem.dID,
                        department = elem.department,
                        tID = (int)elem.tID,
                        title = elem.title,
                        sID = (int)elem.sID,
                        status = elem.status
                    });
                };
            }
            if (allEmployees.Count == 0) return NotFound();
            else return allEmployees;

            // GET api/values/5
            //public string Get(int id)
            //{
            //    return "value";
            //}

            //// POST api/values
            //public void Post([FromBody]string value)
            //{
            //}

            //// PUT api/values/5
            //public void Put(int id, [FromBody]string value)
            //{
            //}

            //// DELETE api/values/5
            //public void Delete(int id)
            //{
            //}
        }
    }
}
