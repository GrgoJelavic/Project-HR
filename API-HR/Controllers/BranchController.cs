using API_HR.BO;
using API_HR.Models;
using API_HR.ModelsFull;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_HR.Controllers
{
    public class BranchController : ApiController
    {
        // GET: api/Branch
        public List<BranchBO> Get()
        {
            using (HREntities db = new HREntities())
            {
                var allBranches = new List<Branches>();
                allBranches = db.Branches.ToList<Branches>();
                var branchList = new List<BranchBO>();

                foreach (var branch in allBranches)
                {
                    var br = new BranchBO();
                    br.branchId = branch.BranchID;
                    br.branch = branch.BranchName;
                    br.address = branch.Address;
                    br.city = branch.City;
                    br.postal = branch.PostalCode;
                    br.telephone = branch.Telephone;

                    branchList.Add(br);
                }
                return branchList;
            }
  
        }

        // GET: api/Branch/5
        public object Get(int id)
        {
            using (HREntities db = new HREntities())
            {

                var allBranches = new List<Branches>();
                allBranches = db.Branches.ToList<Branches>();
                Branches branch = allBranches.Where(x => x.BranchID == id).FirstOrDefault();

                if (branch == null) return NotFound();

                var br = new BranchBO();
                br.branchId = branch.BranchID;
                br.branch = branch.BranchName;
                br.address = branch.Address;
                br.city = branch.City;
                br.postal = branch.PostalCode;
                br.telephone = branch.Telephone;

                return br;
            }
        }

        // POST: api/Branch
        public object Post(Branches branch)
        {
            using (HREntities db = new HREntities())
            {
                try
                {
                    var result = (from row in db.Branches
                                  where
                                  row.BranchName == branch.BranchName
                                  && row.Address == branch.Address
                                  && row.City == branch.City
                                  && row.PostalCode == branch.PostalCode
                                  && row.Telephone == branch.Telephone
                                  select row).ToList();

                    if (result.Count != 0) return StatusCode((HttpStatusCode)409);

                    db.Branches.Add(branch);
                    db.SaveChanges();
                    return StatusCode((HttpStatusCode)201);
                }
                catch (DbEntityValidationException x)
                {
                    return x.Message;
                }
            }
        }

        // PUT: api/Branch/5
        public object Put(int id, Branches branch)
        {
            using (HREntities db = new HREntities())
            {
                try
                {
                    var result = (from row in db.Branches where row.BranchID == id select row).ToList();

                    if (result.Count == 0) return NotFound();

                    var result2 = (from row in db.Branches
                                   where
                                     row.BranchName == branch.BranchName
                                     && row.Address == branch.Address
                                     && row.City == branch.City
                                     && row.PostalCode == branch.PostalCode
                                     && row.Telephone == branch.Telephone
                                   select row).ToList();

                    if (result2.Count != 0) return StatusCode((HttpStatusCode)409);

                    var query = from Branch in db.Branches where Branch.BranchID == id select Branch;
                    foreach (Branches br in query)
                    {
                        br.BranchName = branch.BranchName;
                        br.Address = branch.Address;
                        br.City = branch.City;
                        br.PostalCode = branch.PostalCode;
                        br.Telephone = branch.Telephone;
                    }

                    db.SaveChanges();
                    return StatusCode((HttpStatusCode)204);
                }
                catch (DbEntityValidationException x)
                {
                    return x.Message;
                }
            }
        }

        // DELETE: api/Branch/5
        public object Delete(int id)
        {
            using (HREntities db = new HREntities())
            {
                var allBranches = new List<Branches>();
                allBranches = db.Branches.ToList<Branches>();

                try
                {
                    Branches branch = allBranches.Where(x => x.BranchID == id).FirstOrDefault();
                    if (branch == null) return NotFound();
                    else
                    {
                        db.Branches.Attach(branch);
                        db.Branches.Remove(branch);
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

        [Route("api/Branch/GetFullBranch")]
        public Dictionary<int, string> GetFullBranch()
        {
            using (HREntities db = new HREntities())
            {
                var allBranches = new List<Branches>();
                allBranches = db.Branches.ToList<Branches>();

                var branches = new Dictionary<int, string>();

                foreach (var branch in allBranches)
                {
                    branches.Add(branch.BranchID, branch.BranchName);
                }
                return branches;
            }
        }
    }
}
