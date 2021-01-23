using Client_HR.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_HR.Forms
{
    public partial class DepartmentsForm : Form
    {
        public DepartmentsForm()
        {
            InitializeComponent();
        }

        private async void buttonDisplay_Click(object sender, EventArgs e)
        {
            async Task<string> DisplayDepartments()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/department"))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
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
                var records = JsonConvert.DeserializeObject<List<Department>>(response);
                dgDepartments.DataSource = records;
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private async void buttonInsert_Click(object sender, EventArgs e)
        {
            async Task<string> InsertDepartment()
            {
                string deptName = textDepartmentName.Text.Trim();

                if (deptName.Length == 0)
                {
                    MessageBox.Show("All fields must be filled!");
                    return null;
                }

                var filledRecords = new Dictionary<string, string>
                {
                    { "DepartmentName" , deptName  }
                };

                var input = new FormUrlEncodedContent(filledRecords);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PostAsync("http://localhost:60973/api/department", input))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();

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
                await InsertDepartment();
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
            async Task<string> EditDepartment()
            {
                int id = int.Parse(textSearchID.Text.Trim());

                string departmentName = textDepartmentName.Text.Trim();

                if (departmentName.Length == 0)
                {
                    MessageBox.Show("All fields must be filled!");
                    return null;
                }

                var filledRecords = new Dictionary<string, string>
                {
                    { "DepartmentName" , departmentName  }
                };

                var input = new FormUrlEncodedContent(filledRecords);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PutAsync("http://localhost:60973/api/department/" + id, input))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();

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
                await EditDepartment();
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
            if (MessageBox.Show("Are You Sure?", "Important - You are deleting branch!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                async Task<string> DeleteDepartment(int id)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        using (HttpResponseMessage res = await client.DeleteAsync("http://localhost:60973/api/department/" + id))
                        {
                            using (HttpContent content = res.Content)
                            {
                                string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();

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
                    await DeleteDepartment(int.Parse(textSearchID.Text.Trim()));
                }
                catch (HttpRequestException x)
                {
                    MessageBox.Show(x.Message);
                }
                catch (System.FormatException x)
                {
                    MessageBox.Show(x.Message);
                }
                MessageBox.Show("Department is Deleted!");
            }
            else
            {
                MessageBox.Show("Department is NOT Deleted!");
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            async Task<string> SearchDepartment(int id)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/department/" + id))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();

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
                var response = await SearchDepartment(int.Parse(textSearchID.Text.Trim()));

                Department records = JsonConvert.DeserializeObject<Department>(response);
                List<Department> deptList = new List<Department>();
                deptList.Add(records);

                dgDepartments.DataSource = deptList;
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

    }
}
