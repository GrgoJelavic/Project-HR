//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_HR.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employees
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<long> OIB { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> BirthdayDate { get; set; }
        public string HomeAdress { get; set; }
        public string City { get; set; }
        public Nullable<long> PostalCode { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public Nullable<int> BranchID { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<int> EmploymentStatusID { get; set; }
        public Nullable<int> JobTitleID { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<System.DateTime> EmploymentDate { get; set; }
    
        public virtual Branches Branches { get; set; }
        public virtual Departments Departments { get; set; }
        public virtual EmploymentStatuses EmploymentStatuses { get; set; }
        public virtual JobTitles JobTitles { get; set; }
    }
}
