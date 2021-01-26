using Client_HR.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                            //string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            //MessageBox.Show(statusCode);

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
                    MessageBox.Show("Department Name field must be filled!");
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
                            //string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            //MessageBox.Show(statusCode);

                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                MessageBox.Show("Department Succsesfully Created!");
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
                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                MessageBox.Show("Department Succsesfully Edited!");
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
            if (MessageBox.Show("Are You Sure?", "Important - You are Deleting Department!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                async Task<string> DeleteDepartment(int id)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        using (HttpResponseMessage res = await client.DeleteAsync("http://localhost:60973/api/department/" + id))
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
                            string data = await content.ReadAsStringAsync();

                            if (data != null) return data;                         
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

        private void dgDepartments_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgDepartments.CurrentRow.Index != -1)
            {
                textSearchID.Text = (Convert.ToInt32(dgDepartments.CurrentRow.Cells["departmentId"].Value)).ToString();
                textDepartmentName.Text = (string)dgDepartments.CurrentRow.Cells["departmentName"].Value.ToString();
            }
        }

        private async void buttonDepartmentEmployees_Click(object sender, EventArgs e)
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

                var employeeList = JsonConvert.DeserializeObject<List<EmployeeByAttribute>>(response);

                var departmentEmployees = employeeList.Where(x => x.dID == int.Parse(textSearchID.Text)).ToList();

                dgDepartmentByid.DataSource = departmentEmployees;
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
                string path = $"C:\\PDF-HR\\PDF reports\\departments.pdf";

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

                var columnCount = dgDepartments.ColumnCount;
                var columnWidths = new[] { 1f, 3f };

                var table = new PdfPTable(columnWidths)
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 100,
                    DefaultCell = { MinimumHeight = 22f }
                };

                var cell = new PdfPCell(new Phrase("Departments list"))
                {
                    Colspan = columnCount,
                    HorizontalAlignment = 1,
                    MinimumHeight = 30f
                };

                table.AddCell(cell);

                //header
                dgDepartments.Columns
                    .OfType<DataGridViewColumn>()
                    .ToList()
                    .ForEach(c => table.AddCell(c.Name));

                // rows
                dgDepartments.Rows
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

                string path = $"C:\\PDF-HR\\PDF reports\\employeesByDepartmentID.pdf";

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

                var columnCount = dgDepartmentByid.ColumnCount;
                var columnWidths = new[] { 1f, 1f, 1f, 0.5f, 1f, 0.5f, 1f, 0.5f, 1f, 0.5f, 1f };

                var table = new PdfPTable(columnWidths)
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 100,
                    DefaultCell = { MinimumHeight = 22f }
                };

                var cell = new PdfPCell(new Phrase("Department Employees"))
                {
                    Colspan = columnCount,
                    HorizontalAlignment = 1,
                    MinimumHeight = 30f
                };

                table.AddCell(cell);

                //header
                dgDepartmentByid.Columns
                    .OfType<DataGridViewColumn>()
                    .ToList()
                    .ForEach(c => table.AddCell(c.Name));

                // rows
                dgDepartmentByid.Rows
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
