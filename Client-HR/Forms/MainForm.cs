using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
