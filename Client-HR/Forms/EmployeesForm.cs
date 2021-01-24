using Client_HR.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_HR.Forms
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
            FillAllComboxes();
            textBranchID.Enabled = false;
            textDepartmentID.Enabled = false;
            textTitleID.Enabled = false;
            textStatusID.Enabled = false;
        }

        private async void buttonDisplay_Click(object sender, EventArgs e)
        {
            async Task<string> DisplayEmployees()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/employee"))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();

                            if (data != null) return data;
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                var response = await DisplayEmployees();
                var records = JsonConvert.DeserializeObject<List<Employee>>(response);
                dgEmployees.DataSource = records;
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void FillAllComboxes()
        {
            FillDepartmentCombobox();
            FillBranchCombobox();
            FillJobTitleCombobox();
            FillStatusCombobox();
        }
       
        private async void FillBranchCombobox()
        {
            async Task<string> DisplayBranches()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/branch/GetFullBranch"))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();

                            if (data != null) return data;
                        }
                    }
                }
                return string.Empty;
            }
            try
            {
                var responseBranch = await DisplayBranches();
                var recordsBranch = JsonConvert.DeserializeObject<Dictionary<int, string>>(responseBranch);

                foreach (var rec in recordsBranch) boxBranch.Items.Add(rec.Value);
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void FillDepartmentCombobox()
        {
            async Task<string> DisplayDepartments()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/department/GetFullDepartment"))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();

                            if (data != null) return data;
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                var responseDept = await DisplayDepartments();
                var recordsDept = JsonConvert.DeserializeObject<Dictionary<int, string>>(responseDept);

                foreach (var rec in recordsDept) boxDepartment.Items.Add(rec.Value);
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void FillJobTitleCombobox()
        {
            async Task<string> DisplayJobTitles()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/jobtitle/GetFullJobTitle"))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();

                            if (data != null) return data;
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                var responseTitle = await DisplayJobTitles();
                var recordsTitle = JsonConvert.DeserializeObject<Dictionary<int, string>>(responseTitle);

                foreach (var rec in recordsTitle) boxJobTitle.Items.Add(rec.Value);

            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void FillStatusCombobox()
        {
            async Task<string> DisplayStatuses()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/status/GetFullStatus"))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();

                            if (data != null) return data;
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                var responseStatus = await DisplayStatuses();
                var recordsStatus = JsonConvert.DeserializeObject<Dictionary<int, string>>(responseStatus);

                foreach (var rec in recordsStatus) boxEmploymentStatus.Items.Add(rec.Value);
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void boxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            async Task<string> DisplayDepartments()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/department/GetFullDepartment"))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();

                            if (data != null) return data;
                        }
                    }
                }
                return string.Empty;
            }
            try
            {
                var response = await DisplayDepartments();
                var records = JsonConvert.DeserializeObject<Dictionary<int, string>>(response);

                var departmentID = records.FirstOrDefault(x => x.Value == boxDepartment.Text).Key;
                textDepartmentID.Text = departmentID.ToString();
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void boxJobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            async Task<string> DisplayJobTitles()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/jobtitle/GetFullJobTitle"))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();

                            if (data != null) return data;
                        }
                    }
                }
                return string.Empty;
            }
            try
            {
                var response = await DisplayJobTitles();
                var records = JsonConvert.DeserializeObject<Dictionary<int, string>>(response);

                var jobTitleID = records.FirstOrDefault(x => x.Value == boxJobTitle.Text).Key;
                textTitleID.Text = jobTitleID.ToString();
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void boxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            async Task<string> DisplayBranches()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/branch/GetFullBranch"))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();

                            if (data != null) return data;
                        }
                    }
                }
                return string.Empty;
            }
            try
            {
                var response = await DisplayBranches();
                var records = JsonConvert.DeserializeObject<Dictionary<int, string>>(response);

                var branchID = records.FirstOrDefault(x => x.Value == boxBranch.Text).Key;
                textBranchID.Text = branchID.ToString();
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void boxEmploymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            async Task<string> DisplayStatuses()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/status/GetFullStatus"))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();

                            if (data != null) return data;
                        }
                    }
                }
                return string.Empty;
            }
            try
            {
                var response = await DisplayStatuses();
                var records = JsonConvert.DeserializeObject<Dictionary<int, string>>(response);

                var statusID = records.FirstOrDefault(x => x.Value == boxEmploymentStatus.Text).Key;
                textStatusID.Text = statusID.ToString();
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void buttonInsert_Click(object sender, EventArgs e)
        {
            async Task<string> InsertEmployee()
            {
                string firstName = textFirstName.Text;
                string lastName = textLastName.Text;
                string oib = textOIB.Text;
                string gender = boxGender.Text;
                string birthdayDate = dateBirthday.Value.ToShortDateString();
                string address = textHomeAddress.Text;
                string city = textCity.Text;
                string postal = textPostalCode.Text;
                string birthPlace = textBirthPlace.Text;
                string telephone = textTelephone.Text;
                string mobile = textMobile.Text;
                string email = textEmail.Text;
                string branchID = textBranchID.Text;
                string departmentID = textDepartmentID.Text;
                string statusID = textStatusID.Text;
                string titleID = textTitleID.Text;
                string salary = textSalary.Text;
                string emplDate = dateEmployment.Value.ToShortDateString();

                if (firstName.Length == 0 || lastName.Length == 0 || oib.Length == 0 || gender.Length == 0 || birthdayDate.Length == 0 || 
                    address.Length == 0 || city.Length == 0 || postal.Length == 0 || birthPlace.Length == 0 || telephone.Length == 0 ||
                    mobile.Length == 0 || email.Length == 0 || branchID.Length == 0 || departmentID.Length == 0 ||
                    statusID.Length == 0 || titleID.Length == 0 || salary.Length == 0 || emplDate.Length == 0)
                {
                    MessageBox.Show("All fields must be filled!");
                    return null;
                }

                var filledRecords = new Dictionary<string, string>
                {
                    { "FirstName" , firstName  },
                    { "LastName", lastName },
                    { "OIB", oib },
                    { "Gender", gender },
                    { "BirthdayDate", birthdayDate },
                    { "HomeAdress", address },
                    { "City", city },
                    { "PostalCode", postal },
                    { "PlaceOfBirth", birthPlace },
                    { "Telephone", telephone },
                    { "Mobile", mobile },
                    { "Email", email },
                    { "BranchID", branchID },
                    { "DepartmentID", departmentID },
                    { "EmploymentStatusID", statusID },
                    { "JobTitleID", titleID },
                    { "Salary", salary },
                    { "EmploymentDate", emplDate }
                };

                var input = new FormUrlEncodedContent(filledRecords);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PostAsync("http://localhost:60973/api/employee/", input))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();

                            MessageBox.Show("New Employee Succsesfully Added!");

                            if (data != null) return data;
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                await InsertEmployee();
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
            catch (FormatException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            async Task<string> UpdateEmployee()
            {
                int id = int.Parse(textSearchID.Text.Trim());
                string firstName = textFirstName.Text;
                string lastName = textLastName.Text;
                string oib = textOIB.Text;
                string gender = boxGender.Text;
                string birthdayDate = dateBirthday.Value.ToShortDateString();
                string address = textHomeAddress.Text;
                string city = textCity.Text;
                string postal = textPostalCode.Text;
                string birthPlace = textBirthPlace.Text;
                string telephone = textTelephone.Text;
                string mobile = textMobile.Text;
                string email = textEmail.Text;
                string branchID = textBranchID.Text;
                string departmentID = textDepartmentID.Text;
                string statusID = textStatusID.Text;
                string titleID = textTitleID.Text;
                string salary = textSalary.Text;
                string emplDate = dateEmployment.Value.ToShortDateString();

                if (firstName.Length == 0 || lastName.Length == 0 || oib.Length == 0 || gender.Length == 0 || birthdayDate.Length == 0 ||
                    address.Length == 0 || city.Length == 0 || postal.Length == 0 || birthPlace.Length == 0 || telephone.Length == 0 ||
                    mobile.Length == 0 || email.Length == 0 || branchID.Length == 0 || departmentID.Length == 0 ||
                    statusID.Length == 0 || titleID.Length == 0 || salary.Length == 0 || emplDate.Length == 0)
                {
                    MessageBox.Show("All fields must be filled!");
                    return null;
                }

                var filledRecords = new Dictionary<string, string>
                {
                    { "FirstName" , firstName  },
                    { "LastName", lastName },
                    { "OIB", oib },
                    { "Gender", gender },
                    { "BirthdayDate", birthdayDate },
                    { "HomeAdress", address },
                    { "City", city },
                    { "PostalCode", postal },
                    { "PlaceOfBirth", birthPlace },
                    { "Telephone", telephone },
                    { "Mobile", mobile },
                    { "Email", email },
                    { "BranchID", branchID },
                    { "DepartmentID", departmentID },
                    { "EmploymentStatusID", statusID },
                    { "JobTitleID", titleID },
                    { "Salary", salary },
                    { "EmploymentDate", emplDate }
                };

                var input = new FormUrlEncodedContent(filledRecords);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PutAsync("http://localhost:60973/api/employee/" + id, input))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                MessageBox.Show("Employee Succsesfully Updated!");
                                return data;
                            }
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                await UpdateEmployee();
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
            catch (FormatException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Important - You are deleting Employee!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                async Task<string> DeleteEmployee(int id)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        using (HttpResponseMessage res = await client.DeleteAsync("http://localhost:60973/api/employee/" + id))
                        {
                            using (HttpContent content = res.Content)
                            {
                                string data = await content.ReadAsStringAsync();

                                if (data != null)
                                {
                                    MessageBox.Show("Employee Succsesfully Deleted!");
                                    return data;
                                }
                            }
                        }
                    }
                    return string.Empty;
                }

                try
                {
                    await DeleteEmployee(int.Parse(textSearchID.Text.Trim()));
                }
                catch (HttpRequestException x)
                {
                    MessageBox.Show(x.Message);
                }
                catch (System.FormatException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            else MessageBox.Show("Employee is NOT deleted!");
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            async Task<string> SearchEmmployee(string id)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/employee/" + id))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            MessageBox.Show(statusCode);

                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                var response = await SearchEmmployee(textSearchID.Text.Trim());

                var records = JsonConvert.DeserializeObject<List<Employee>>(response);
                dgEmployees.DataSource = records;
                //List<Employee> employeeList = new List<Employee>();
                //employeeList.Add(records);
                //dgEmployees.DataSource = employeeList;
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
            catch (System.FormatException x)
            {
                MessageBox.Show(x.Message);
            }
        }


        private void dgEmployees_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgEmployees.CurrentRow.Index != -1)
            {
                textSearchID.Text = Convert.ToInt32(dgEmployees.CurrentRow.Cells["employeeId"].Value).ToString();
                textFirstName.Text = (string)dgEmployees.CurrentRow.Cells["firstName"].Value.ToString();
                textLastName.Text = (string)dgEmployees.CurrentRow.Cells["lastName"].Value.ToString();
                textOIB.Text = (Convert.ToInt64(dgEmployees.CurrentRow.Cells["oib"].Value)).ToString();
                dateBirthday.Text = dgEmployees.CurrentRow.Cells["birthdayDate"].Value.ToString();
                textHomeAddress.Text = (string)dgEmployees.CurrentRow.Cells["homeAddress"].Value.ToString();
                textCity.Text = (string)dgEmployees.CurrentRow.Cells["city"].Value.ToString();
                textPostalCode.Text = Convert.ToUInt64(dgEmployees.CurrentRow.Cells["postalCode"].Value).ToString();
                textBirthPlace.Text = (string)dgEmployees.CurrentRow.Cells["placeOfBirth"].Value.ToString();
                textTelephone.Text = (string)dgEmployees.CurrentRow.Cells["telephone"].Value.ToString();
                textMobile.Text = (string)dgEmployees.CurrentRow.Cells["mobile"].Value.ToString();
                textEmail.Text = (string)dgEmployees.CurrentRow.Cells["email"].Value.ToString();
                textBranchID.Text = Convert.ToInt64(dgEmployees.CurrentRow.Cells["branchId"].Value).ToString();
                textDepartmentID.Text = Convert.ToInt64(dgEmployees.CurrentRow.Cells["departmentId"].Value).ToString();
                textStatusID.Text = Convert.ToInt64(dgEmployees.CurrentRow.Cells["employmentStatusId"].Value).ToString();
                textTitleID.Text = Convert.ToInt64(dgEmployees.CurrentRow.Cells["jobTitleId"].Value).ToString();
                textSalary.Text = (string)dgEmployees.CurrentRow.Cells["salary"].Value.ToString();
                dateEmployment.Text = (string)dgEmployees.CurrentRow.Cells["employmentDate"].Value.ToString();
            }
        }
    }
}
