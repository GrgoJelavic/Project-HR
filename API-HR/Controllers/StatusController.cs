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
    public class StatusController : ApiController
    {
        // GET: api/Status
        public List<StatusBO> Get()
        {
            using (HREntities db = new HREntities())
            {
                var allStatuses = new List<EmploymentStatuses>();
                allStatuses = db.EmploymentStatuses.ToList();
                var titleList = new List<StatusBO>();

                foreach (var employStatus in allStatuses)
                {
                    var status = new StatusBO();
                    status.employmentStatusID = employStatus.EmploymentStatusID;
                    status.statusName = employStatus.StatusName;

                    titleList.Add(status);
                }
                return titleList;
            }
        }

        // GET: api/Status/5
        public object Get(int id)
        {
            using (HREntities db = new HREntities())
            {
                var allStatusess = new List<EmploymentStatuses>();
                allStatusess = db.EmploymentStatuses.ToList();
                EmploymentStatuses status = allStatusess.Where(x => x.EmploymentStatusID == id).FirstOrDefault();

                if (status == null) return NotFound();

                var employStatus = new StatusBO();
                employStatus.employmentStatusID = status.EmploymentStatusID;
                employStatus.statusName = status.StatusName;

                return employStatus;
            }
        }

        // POST: api/Status
        public object Post(EmploymentStatuses status)
        {
            using (HREntities db = new HREntities())
            {
                try
                {
                    var result = (from row in db.EmploymentStatuses
                                  where
                                  row.StatusName == status.StatusName
                                  select row).ToList();

                    if (result.Count != 0) return StatusCode((HttpStatusCode)409);

                    db.EmploymentStatuses.Add(status);
                    db.SaveChanges();
                    return StatusCode((HttpStatusCode)201);
                }
                catch (DbEntityValidationException ex)
                {
                    return ex.Message;
                }
            }
        }

        // PUT: api/Status/5
        public object Put(int id, EmploymentStatuses status)
        {
            using (HREntities db = new HREntities())
            {
                try
                {
                    var resultCheck = (from row in db.EmploymentStatuses where row.EmploymentStatusID == id select row).ToList();

                    if (resultCheck.Count == 0) return NotFound();

                    var result = (from row in db.EmploymentStatuses
                                  where
                                  row.StatusName == status.StatusName
                                  select row).ToList();

                    if (result.Count != 0) return StatusCode((HttpStatusCode)409);

                    var query = from EmploymentStatus in db.EmploymentStatuses where EmploymentStatus.EmploymentStatusID == id select EmploymentStatus;

                    foreach (EmploymentStatuses statuss in query) statuss.StatusName = status.StatusName;

                    db.SaveChanges();
                    return StatusCode((HttpStatusCode)204);
                }
                catch (DbEntityValidationException ex)
                {
                    return ex.Message;
                }
            }
        }

        // DELETE: api/Status/5
        public object Delete(int id)
        {
            using (HREntities db = new HREntities())
            {
                var allStatuses = new List<EmploymentStatuses>();
                allStatuses = db.EmploymentStatuses.ToList();

                try
                {
                    EmploymentStatuses emplyStatus = allStatuses.Where(x => x.EmploymentStatusID == id).FirstOrDefault();
                    if (emplyStatus == null) return NotFound();
                    else
                    {
                        db.EmploymentStatuses.Attach(emplyStatus);
                        db.EmploymentStatuses.Remove(emplyStatus);
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

        [Route("api/Status/GetFullStatus")]
        public Dictionary<int, string> GetFullStatus()
        {
            using (HREntities db = new HREntities())
            {
                var allStatuses = new List<EmploymentStatuses>();
                allStatuses = db.EmploymentStatuses.ToList();

                var statuses = new Dictionary<int, string>();

                foreach (var status in allStatuses) statuses.Add(status.EmploymentStatusID, status.StatusName);

                return statuses;
            }
        }
    }
}
