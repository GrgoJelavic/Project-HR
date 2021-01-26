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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void eMPLOYEESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesForm employees = new EmployeesForm();
            employees.ShowDialog();
        }

        private void branchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Branches branches = new Branches();
            branches.ShowDialog();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentsForm departments = new DepartmentsForm();
            departments.ShowDialog();
        }

        private void titlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobTitlesForm titles = new JobTitlesForm();
            titles.ShowDialog();
        }

        private void statusesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmploymentStatusForm statuses = new EmploymentStatusForm();
            statuses.ShowDialog();
        }

        private async void buttonDisplay_Click(object sender, EventArgs e)
        {
            async Task<string> DisplayEmployees()
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
                var response = await DisplayEmployees();
                var records = JsonConvert.DeserializeObject<List<EmployeeByAttribute>>(response);
                dgMain.DataSource = records;
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
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

                var columnCount = dgMain.ColumnCount;
                var columnWidths = new[] { 0.7f, 1f, 1f, 0.5f, 1f, 0.5f, 1f, 0.5f, 1f, 0.5f, 1f };

                var table = new PdfPTable(columnWidths)
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 100,
                    DefaultCell = { MinimumHeight = 22f }
                };

                var cell = new PdfPCell(new Phrase("Employees List"))
                {
                    Colspan = columnCount,
                    HorizontalAlignment = 1,
                    MinimumHeight = 30f
                };

                table.AddCell(cell);

                //header
                dgMain.Columns
                    .OfType<DataGridViewColumn>()
                    .ToList()
                    .ForEach(c => table.AddCell(c.Name));

                // rows
                dgMain.Rows
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
