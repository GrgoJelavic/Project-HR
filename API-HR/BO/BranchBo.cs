using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_HR.BO
{
    public class BranchBO
    {
        public int branchId { get; set; }

        public string branchName { get; set; }

        public string branchAddress { get; set; }

        public string branchCity { get; set; }

        public string branchPostal { get; set; }

        public string branchTelephone { get; set; }
    }
}