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
    public class JobTitleController : ApiController
    {
        // GET: api/JobTitle
        public List<JobTitleBO> Get()
        {
            using (HREntities db = new HREntities())
            {
                var allTitles = new List<JobTitles>();
                allTitles = db.JobTitles.ToList<JobTitles>();
                var titleList = new List<JobTitleBO>();

                foreach (var jobTitle in allTitles)
                {
                    var title = new JobTitleBO();
                    title.jobtitleId = jobTitle.JobTitleID;
                    title.jobTitle = jobTitle.JobTitleName;

                    titleList.Add(title);
                }
                return titleList;
            }
        }

        // GET: api/JobTitle/5
        public object Get(int id)
        {
            using (HREntities db = new HREntities())
            {
                var allTitles = new List<JobTitles>();
                allTitles = db.JobTitles.ToList<JobTitles>();
                JobTitles jobTitle = allTitles.Where(x => x.JobTitleID == id).FirstOrDefault();

                if (jobTitle == null) return NotFound();

                var title = new JobTitleBO();
                title.jobtitleId = jobTitle.JobTitleID;
                title.jobTitle = jobTitle.JobTitleName;

                return title;
            }
        }

        // POST: api/JobTitle
        public Object Post(JobTitles jobTitle)
        {
            using (HREntities db = new HREntities())
            {
                try
                {
                    var result = (from row in db.JobTitles
                                  where
                                  row.JobTitleName == jobTitle.JobTitleName
                                  select row).ToList();

                    if (result.Count != 0) return StatusCode((HttpStatusCode)409);

                    db.JobTitles.Add(jobTitle);
                    db.SaveChanges();
                    return StatusCode((HttpStatusCode)201);
                }
                catch (DbEntityValidationException ex)
                {
                    return ex.Message;
                }
            }
        }

        // PUT: api/JobTitle/5
        public object Put(int id, JobTitles jobTitle)
        {
            using (HREntities db = new HREntities())
            {
                try
                {
                    var resultCheck = (from row in db.JobTitles where row.JobTitleID == id select row).ToList();

                    if (resultCheck.Count == 0) return NotFound();

                    var result = (from row in db.JobTitles
                                  where
                                  row.JobTitleName == jobTitle.JobTitleName
                                  select row).ToList();

                    if (result.Count != 0) return StatusCode((HttpStatusCode)409);

                    var query = from JobTitle in db.JobTitles where JobTitle.JobTitleID == id select JobTitle;

                    foreach (JobTitles title in query) title.JobTitleName = jobTitle.JobTitleName;

                    db.SaveChanges();
                    return StatusCode((HttpStatusCode)204);
                }
                catch (DbEntityValidationException ex)
                {
                    return ex.Message;
                }
            }
        }

        // DELETE: api/JobTitle/5
        public object Delete(int id)
        {
            using (HREntities db = new HREntities())
            {
                var allJobtitles = new List<JobTitles>();
                allJobtitles = db.JobTitles.ToList<JobTitles>();

                try
                {
                    JobTitles jobTitle = allJobtitles.Where(x => x.JobTitleID == id).FirstOrDefault();
                    if (jobTitle == null) return NotFound();
                    else
                    {
                        db.JobTitles.Attach(jobTitle);
                        db.JobTitles.Remove(jobTitle);
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

        [Route("api/jobtitle/GetFullJobTitle")]
        public Dictionary<int, string> GetFullBranch()
        {
            using (HREntities db = new HREntities())
            {
                var allJobtitles = new List<JobTitles>();
                allJobtitles = db.JobTitles.ToList<JobTitles>();

                var jobTitles = new Dictionary<int, string>();

                foreach (var titl in allJobtitles) jobTitles.Add(titl.JobTitleID, titl.JobTitleName);

                return jobTitles;
            }
        }
    }
}
