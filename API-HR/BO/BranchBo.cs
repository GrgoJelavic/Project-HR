using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_HR.BO
{
    public class BranchBO
    {
        public int branchId { get; set; }

        public string branch { get; set; }

        public string address { get; set; }

        public string city { get; set; }

        public string postal { get; set; }

        public string telephone { get; set; }
    }
}