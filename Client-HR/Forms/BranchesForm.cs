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
    public partial class Branches : Form
    {
        public Branches()
        {
            InitializeComponent();
        }

        private async void buttonDisplay_Click(object sender, EventArgs e)
        {
            async Task<string> DisplayBranches()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/branch"))
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
                var response = await DisplayBranches();
                var records = JsonConvert.DeserializeObject<List<Branch>>(response);
                dgBranches.DataSource = records;
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void buttonInsert_Click(object sender, EventArgs e)
        {
            async Task<string> InsertBranch()
            {
                string branchName = textBranchName.Text.Trim();
                string branchAddress = textAddress.Text;
                string branchCity = textCity.Text;
                string branchPostal = textPostalCode.Text;
                string branchTelephone = textTelephone.Text;

                if (branchName.Length == 0 || branchAddress.Length == 0 || branchCity.Length == 0 ||
                    branchPostal.Length == 0 || branchTelephone.Length == 0)
                {
                    MessageBox.Show("All fields must be filled!");
                    return null;
                }

                var filledRecords = new Dictionary<string, string>
                {
                    { "BranchName" , branchName  },
                    { "Address", branchAddress },
                    { "City", branchCity },
                    { "PostalCode", branchPostal },
                    { "Telephone", branchTelephone }
                };

                var input = new FormUrlEncodedContent(filledRecords);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PostAsync("http://localhost:60973/api/branch", input))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            MessageBox.Show(statusCode);

                            string data = await content.ReadAsStringAsync();

                            if (data != null) return data;
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                await InsertBranch();
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
            async Task<string> EditBranch()
            {
                int id = int.Parse(textSearchID.Text.Trim());

                string branchName = textBranchName.Text.Trim();
                string branchAddress = textAddress.Text;
                string branchCity = textCity.Text;
                string branchPostal = textPostalCode.Text;
                string branchTelephone = textTelephone.Text;

                if (branchName.Length == 0 || branchAddress.Length == 0 || branchCity.Length == 0 ||
                                    branchPostal.Length == 0 || branchTelephone.Length == 0)
                {
                    MessageBox.Show("All fields must be filled!");
                    return null;
                }

                var filledRecords = new Dictionary<string, string>
                {
                    { "BranchName" , branchName  },
                    { "Address", branchAddress },
                    { "City", branchCity },
                    { "PostalCode", branchPostal },
                    { "Telephone", branchTelephone }
                };

                var input = new FormUrlEncodedContent(filledRecords);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PutAsync("http://localhost:60973/api/branch/" + id, input))
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
                await EditBranch();
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
                async Task<string> DeleteBranch(int id)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        using (HttpResponseMessage res = await client.DeleteAsync("http://localhost:60973/api/branch/" + id))
                        {
                            using (HttpContent content = res.Content)
                            {
                                string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                                MessageBox.Show(statusCode);

                                string data = await content.ReadAsStringAsync();

                                if (data != null) return data;
                            }
                        }
                    }
                    MessageBox.Show("Branch is deleted!");
                    return string.Empty;
                }

                try
                {
                    await DeleteBranch(int.Parse(textSearchID.Text.Trim()));
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
            else MessageBox.Show("Branch is NOT deleted!");
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            async Task<string> SearchBranch(int id)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/branch/" + id))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            MessageBox.Show(statusCode);

                            string data = await content.ReadAsStringAsync();

                            if (data != null) return data;

                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                var response = await SearchBranch(int.Parse(textSearchID.Text.Trim()));

                Branch branch = JsonConvert.DeserializeObject<Branch>(response);
                List<Branch> branchList = new List<Branch>();
                branchList.Add(branch);

                dgBranches.DataSource = branchList;
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



        //private void dgvKategorije_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (dgvKategorije.CurrentRow.Index != -1)
        //    {
        //        txtIdPretragaKategorije.Text = (Convert.ToInt32(dgvKategorije.CurrentRow.Cells["kategorijaId"].Value)).ToString();
        //        txtNazivKategorije.Text = (string)dgvKategorije.CurrentRow.Cells["kategorijaNaziv"].Value.ToString();
        //        txtProizvodacKategorija.Text = (string)dgvKategorije.CurrentRow.Cells["kategorijaProizvodac"].Value.ToString();
        //    }
        //}
    }
}

