using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_HR.Models
{
    class Employee
    {
        public int employeeId { get; set; }

        public string firstName { get; set; }

        public string LastName { get; set; }

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

        public long branchId { get; set; }

        public long departmentId { get; set; }

        public long employmentStatusId { get; set; }

        public long jobTitleId { get; set; }

        public decimal salary { get; set; }

        public DateTime employmentDate { get; set; }
    }
}
