using Client_HR.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_HR.Forms
{
    public partial class JobTitlesForm : Form
    {
        public JobTitlesForm()
        {
            InitializeComponent();
        }

        private async void buttonDisplay_Click(object sender, EventArgs e)
        {
            async Task<string> DisplayJobTitles()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/jobtitle"))
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
                var records = JsonConvert.DeserializeObject<List<JobTitle>>(response);
                dgJobTitles.DataSource = records;
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void buttonInsert_Click(object sender, EventArgs e)
        {
            async Task<string> InsertJobtitle()
            {
                string jobTitle = textJobTitleName.Text.Trim();

                if (jobTitle.Length == 0)
                {
                    MessageBox.Show("Job Title Name field must be filled!");
                    return null;
                }

                var filledRecords = new Dictionary<string, string>
                {
                    { "JobTitleName" , jobTitle}
                };

                var input = new FormUrlEncodedContent(filledRecords);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PostAsync("http://localhost:60973/api/jobtitle", input))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                MessageBox.Show("Job Title Succsesfully Created!");
                                return data;
                            }
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                await InsertJobtitle();
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
            async Task<string> EditJobtitle()
            {
                int id = int.Parse(textSearchID.Text.Trim());

                string jobTitle = textJobTitleName.Text.Trim();

                if (jobTitle.Length == 0)
                {
                    MessageBox.Show("Job Title Name must be filled!");
                    return null;
                }

                var filledRecords = new Dictionary<string, string>
                {
                    {"JobTitleName" , jobTitle}
                };

                var input = new FormUrlEncodedContent(filledRecords);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PutAsync("http://localhost:60973/api/jobtitle/" + id, input))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                MessageBox.Show("Job Title Succsesfully Edited!");
                                return data;
                            }
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                await EditJobtitle();
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
            if (MessageBox.Show("Are You Sure?", "Important - You are Deleting Title!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                async Task<string> DeleteJobTitle(int id)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        using (HttpResponseMessage res = await client.DeleteAsync("http://localhost:60973/api/jobtitle/" + id))
                        {
                            using (HttpContent content = res.Content)
                            {
                                string data = await content.ReadAsStringAsync();

                                if (data != null)
                                {
                                    MessageBox.Show("Job Title Succsesfully Deleted!");
                                    return data;
                                }
                            }
                        }
                    }
                    return string.Empty;
                }

                try
                {
                    await DeleteJobTitle(int.Parse(textSearchID.Text.Trim()));
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
                MessageBox.Show("Job Title is NOT Deleted!");
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            async Task<string> SearchJobTitle(int id)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/jobtitle/" + id))
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
                var response = await SearchJobTitle(int.Parse(textSearchID.Text.Trim()));

                JobTitle records = JsonConvert.DeserializeObject<JobTitle>(response);
                List<JobTitle> jobTitleList = new List<JobTitle>();
                jobTitleList.Add(records);

                dgJobTitles.DataSource = jobTitleList;
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

        private void dgJobTitles_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgJobTitles.CurrentRow.Index != -1)
            {
                textSearchID.Text = (Convert.ToInt32(dgJobTitles.CurrentRow.Cells["jobTitleId"].Value)).ToString();
                textJobTitleName.Text = (string)dgJobTitles.CurrentRow.Cells["jobTitleName"].Value.ToString();
            }
        }

        private async void buttonTitleEmployees_Click(object sender, EventArgs e)
        {
            async Task<string> DepartmentEmployees(int id)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:60973/api/values"))
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
                var response = await DepartmentEmployees(int.Parse(textSearchID.Text.Trim()));

                var employeesList = JsonConvert.DeserializeObject<List<EmployeeByAttribute>>(response);

                var departmentEmployees = employeesList.Where(x => x.tID == int.Parse(textSearchID.Text)).ToList();


                dgById.DataSource = departmentEmployees;
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

        private void buttonPdf_Click(object sender, EventArgs e)
        {
            void ExportToPdf()
            {
                var pdfDoc = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
                string path = $"C:\\PDF-HR\\PDF reports\\jobTitles.pdf";

                PdfWriter.GetInstance(pdfDoc, new FileStream(path, FileMode.OpenOrCreate));
                pdfDoc.Open();

                var title = new Paragraph(" .NET Project - Human Resources ");
                pdfDoc.Add(title);

                var spacer = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f,
                };

                pdfDoc.Add(spacer);

                var headerTable = new PdfPTable(new[] { .75f, 2f })
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 75,
                    DefaultCell = { MinimumHeight = 22f }
                };

                pdfDoc.Add(headerTable);
                pdfDoc.Add(spacer);

                var columnCount = dgJobTitles.ColumnCount;
                var columnWidths = new[] { 1f, 3f };

                var table = new PdfPTable(columnWidths)
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 100,
                    DefaultCell = { MinimumHeight = 22f }
                };

                var cell = new PdfPCell(new Phrase("Job Titles list"))
                {
                    Colspan = columnCount,
                    HorizontalAlignment = 1,
                    MinimumHeight = 30f
                };

                table.AddCell(cell);

                //header
                dgJobTitles.Columns
                    .OfType<DataGridViewColumn>()
                    .ToList()
                    .ForEach(c => table.AddCell(c.Name));

                // rows
                dgJobTitles.Rows
                    .OfType<DataGridViewRow>()
                    .ToList()
                    .ForEach(r =>
                    {
                        var cells = r.Cells.OfType<DataGridViewCell>().ToList();
                        cells.ForEach(c => table.AddCell(c.Value.ToString()));
                    });

                pdfDoc.Add(table);

                pdfDoc.Close();
                System.Diagnostics.Process.Start(path);
            }
            ExportToPdf();
        }

        private void buttonPdfById_Click(object sender, EventArgs e)
        {
            void ExportToPdf()
            {
                var pdfDoc = new Document(new iTextSharp.text.Rectangle(288f, 144f), 10, 10, 10, 10);
                pdfDoc.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());

                string path = $"C:\\PDF-HR\\PDF reports\\employeesByTitles.pdf";

                PdfWriter.GetInstance(pdfDoc, new FileStream(path, FileMode.OpenOrCreate));
                pdfDoc.Open();

                var title = new Paragraph(" .NET Project - Human Resources ");
                pdfDoc.Add(title);

                var spacer = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f,
                };

                pdfDoc.Add(spacer);

                var headerTable = new PdfPTable(new[] { .75f, 2f })
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 75,
                    DefaultCell = { MinimumHeight = 22f }
                };

                pdfDoc.Add(headerTable);
                pdfDoc.Add(spacer);

                var columnCount = dgById.ColumnCount;
                var columnWidths = new[] { 1f, 1f, 1f, 0.5f, 1f, 0.5f, 1f, 0.5f, 1f, 0.5f, 1f };

                var table = new PdfPTable(columnWidths)
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 100,
                    DefaultCell = { MinimumHeight = 22f }
                };

                var cell = new PdfPCell(new Phrase("Employees by Job Title"))
                {
                    Colspan = columnCount,
                    HorizontalAlignment = 1,
                    MinimumHeight = 30f
                };

                table.AddCell(cell);

                //header
                dgById.Columns
                    .OfType<DataGridViewColumn>()
                    .ToList()
                    .ForEach(c => table.AddCell(c.Name));

                // rows
                dgById.Rows
                    .OfType<DataGridViewRow>()
                    .ToList()
                    .ForEach(r =>
                    {
                        var cells = r.Cells.OfType<DataGridViewCell>().ToList();
                        cells.ForEach(c => table.AddCell(c.Value.ToString()));
                    });

                pdfDoc.Add(table);

                pdfDoc.Close();
                System.Diagnostics.Process.Start(path);
            }
            ExportToPdf();
        }
    }
}
