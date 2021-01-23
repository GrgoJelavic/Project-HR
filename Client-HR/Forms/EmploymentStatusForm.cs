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
    public partial class EmploymentStatusForm : Form
    {
        public EmploymentStatusForm()
        {
            InitializeComponent();
        }

        private async void buttonDisplay_Click(object sender, EventArgs e)
        {
            async Task<string> DisplayStatuses()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/status"))
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
                var records = JsonConvert.DeserializeObject<List<Status>>(response);
                dgStatuses.DataSource = records;
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void buttonInsert_Click(object sender, EventArgs e)
        {
            async Task<string> InserStatus()
            {
                string statusName = textStatusName.Text.Trim();

                if (statusName.Length == 0)
                {
                    MessageBox.Show("Employments Status field must be filled!");
                    return null;
                }

                var filledRecords = new Dictionary<string, string>
                {
                    { "StatusName" , statusName }
                };

                var input = new FormUrlEncodedContent(filledRecords);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PostAsync("http://localhost:60973/api/status", input))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                MessageBox.Show("Employment Status Succsesfully Created!");
                                return data;
                            }
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                await InserStatus();
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
            async Task<string> EditStatus()
            {
                int id = int.Parse(textSearchID.Text.Trim());

                string statusName = textStatusName.Text.Trim();

                if (statusName.Length == 0)
                {
                    MessageBox.Show("Employment Status Name must be filled!");
                    return null;
                }

                var filledRecords = new Dictionary<string, string>
                {
                    { "StatusName" , statusName  }
                };

                var input = new FormUrlEncodedContent(filledRecords);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PutAsync("http://localhost:60973/api/status/" + id, input))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                MessageBox.Show("Employment Status Succsesfully Edited!");
                                return data;
                            }
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                await EditStatus();
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
            if (MessageBox.Show("Are You Sure?", "Important - You are Deleting Status!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                async Task<string> DeleteStatus(int id)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        using (HttpResponseMessage res = await client.DeleteAsync("http://localhost:60973/api/status/" + id))
                        {
                            using (HttpContent content = res.Content)
                            {
                                string data = await content.ReadAsStringAsync();

                                if (data != null)
                                {
                                    MessageBox.Show("Department Succsesfully Deleted!");
                                    return data;
                                }
                            }
                        }
                    }
                    return string.Empty;
                }

                try
                {
                    await DeleteStatus(int.Parse(textSearchID.Text.Trim()));
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
            else
            {
                MessageBox.Show("Employment Status is NOT Deleted!");
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            async Task<string> SearchStatus(int id)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/status/" + id))
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
                var response = await SearchStatus(int.Parse(textSearchID.Text));

                Status records = JsonConvert.DeserializeObject<Status>(response);
                List<Status> deptList = new List<Status>();
                deptList.Add(records);

                dgStatuses.DataSource = deptList;
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

        private void dgStatuses_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgStatuses.CurrentRow.Index != -1)
            {
                textSearchID.Text = (Convert.ToInt32(dgStatuses.CurrentRow.Cells["employmentStatusID"].Value)).ToString();
                textStatusName.Text = (string)dgStatuses.CurrentRow.Cells["statusName"].Value.ToString();
            }
        }
    }
}
