using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_HR.Models
{
    class EmployeeFull
    {
        public int employeeId { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public long oib { get; set; }

        public string gender { get; set; }

        public DateTime birthdayDate { get; set; }

        public string homeAddress { get; set; }

        public string city { get; set; }

        public long postalCode { get; set; }

        public string placeOfBirth { get; set; }

        public string telephone { get; set; }

        public string mobile { get; set; }

        public string email { get; set; }


        public int branchId { get; set; }

        public string branchName { get; set; }

        public int departmentId { get; set; }

        public string departmentName { get; set; }

        public int employmentStatusId { get; set; }

        public string employmentStatusName { get; set; }

        public int jobTitleId { get; set; }

        public string jobTitleName { get; set; }


        public decimal salary { get; set; }

        public DateTime employmentDate { get; set; }
    }
}
