using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_HR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Forms.DepartmentsForm());
            Application.Run(new Forms.Branches());
            //Application.Run(new Forms.JobTitlesForm());
            //Application.Run(new Forms.EmploymentStatusForm());
            //Application.Run(new Forms.EmployeesForm());

        }
    }
}
