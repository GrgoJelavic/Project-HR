
namespace Client_HR.Forms
{
    partial class EmployeesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.dgEmployees = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.boxEmploymentStatus = new System.Windows.Forms.ComboBox();
            this.boxBranch = new System.Windows.Forms.ComboBox();
            this.boxDepartment = new System.Windows.Forms.ComboBox();
            this.boxJobTitle = new System.Windows.Forms.ComboBox();
            this.boxGender = new System.Windows.Forms.ComboBox();
            this.dateEmployment = new System.Windows.Forms.DateTimePicker();
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textBirthPlace = new System.Windows.Forms.TextBox();
            this.textPostalCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textMobile = new System.Windows.Forms.TextBox();
            this.textTelephone = new System.Windows.Forms.TextBox();
            this.textHomeAddress = new System.Windows.Forms.TextBox();
            this.textOIB = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textSearchID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textTitleID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textStatusID = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textDepartmentID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBranchID = new System.Windows.Forms.TextBox();
            this.buttonPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 845);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 37);
            this.label3.TabIndex = 146;
            this.label3.Text = "Salary:";
            // 
            // textSalary
            // 
            this.textSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSalary.Location = new System.Drawing.Point(446, 886);
            this.textSalary.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(286, 44);
            this.textSalary.TabIndex = 147;
            // 
            // dgEmployees
            // 
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Location = new System.Drawing.Point(120, 80);
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.RowHeadersWidth = 82;
            this.dgEmployees.RowTemplate.Height = 33;
            this.dgEmployees.Size = new System.Drawing.Size(1484, 446);
            this.dgEmployees.TabIndex = 143;
            this.dgEmployees.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgEmployees_MouseClick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(777, 747);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 37);
            this.label20.TabIndex = 142;
            this.label20.Text = "City:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(777, 554);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 37);
            this.label19.TabIndex = 141;
            this.label19.Text = "OIB:";
            // 
            // boxEmploymentStatus
            // 
            this.boxEmploymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxEmploymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxEmploymentStatus.FormattingEnabled = true;
            this.boxEmploymentStatus.Location = new System.Drawing.Point(118, 1174);
            this.boxEmploymentStatus.Name = "boxEmploymentStatus";
            this.boxEmploymentStatus.Size = new System.Drawing.Size(286, 45);
            this.boxEmploymentStatus.TabIndex = 140;
            this.boxEmploymentStatus.SelectedIndexChanged += new System.EventHandler(this.boxEmploymentStatus_SelectedIndexChanged);
            // 
            // boxBranch
            // 
            this.boxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxBranch.FormattingEnabled = true;
            this.boxBranch.Location = new System.Drawing.Point(585, 1174);
            this.boxBranch.Name = "boxBranch";
            this.boxBranch.Size = new System.Drawing.Size(286, 45);
            this.boxBranch.TabIndex = 138;
            this.boxBranch.SelectedIndexChanged += new System.EventHandler(this.boxBranch_SelectedIndexChanged);
            // 
            // boxDepartment
            // 
            this.boxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDepartment.FormattingEnabled = true;
            this.boxDepartment.Location = new System.Drawing.Point(583, 1075);
            this.boxDepartment.Name = "boxDepartment";
            this.boxDepartment.Size = new System.Drawing.Size(288, 45);
            this.boxDepartment.TabIndex = 137;
            this.boxDepartment.Tag = "";
            this.boxDepartment.SelectedIndexChanged += new System.EventHandler(this.boxDepartment_SelectedIndexChanged);
            // 
            // boxJobTitle
            // 
            this.boxJobTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxJobTitle.FormattingEnabled = true;
            this.boxJobTitle.Location = new System.Drawing.Point(111, 1075);
            this.boxJobTitle.Name = "boxJobTitle";
            this.boxJobTitle.Size = new System.Drawing.Size(292, 45);
            this.boxJobTitle.TabIndex = 136;
            this.boxJobTitle.SelectedIndexChanged += new System.EventHandler(this.boxJobTitle_SelectedIndexChanged);
            // 
            // boxGender
            // 
            this.boxGender.DisplayMember = "select";
            this.boxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxGender.FormattingEnabled = true;
            this.boxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.boxGender.Location = new System.Drawing.Point(113, 686);
            this.boxGender.Name = "boxGender";
            this.boxGender.Size = new System.Drawing.Size(286, 45);
            this.boxGender.TabIndex = 112;
            // 
            // dateEmployment
            // 
            this.dateEmployment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEmployment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEmployment.Location = new System.Drawing.Point(775, 886);
            this.dateEmployment.Name = "dateEmployment";
            this.dateEmployment.Size = new System.Drawing.Size(286, 44);
            this.dateEmployment.TabIndex = 139;
            this.dateEmployment.Value = new System.DateTime(2021, 1, 23, 0, 0, 0, 0);
            // 
            // dateBirthday
            // 
            this.dateBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirthday.Location = new System.Drawing.Point(775, 690);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(286, 44);
            this.dateBirthday.TabIndex = 113;
            this.dateBirthday.Value = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 554);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 37);
            this.label1.TabIndex = 129;
            this.label1.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 646);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 128;
            this.label2.Text = "Gender:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(441, 646);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(213, 37);
            this.label16.TabIndex = 127;
            this.label16.Text = "Place of birth:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(111, 845);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 37);
            this.label8.TabIndex = 126;
            this.label8.Text = "Postal code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(768, 646);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 37);
            this.label5.TabIndex = 125;
            this.label5.Text = "Birthday date:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(113, 1134);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(298, 37);
            this.label18.TabIndex = 130;
            this.label18.Text = "Employment status:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(591, 1134);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 37);
            this.label15.TabIndex = 123;
            this.label15.Text = "Branch:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(777, 937);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 37);
            this.label12.TabIndex = 124;
            this.label12.Text = "E-mail:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(578, 1035);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 37);
            this.label14.TabIndex = 122;
            this.label14.Text = "Department:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(441, 937);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 37);
            this.label11.TabIndex = 121;
            this.label11.Text = "Mobile:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(777, 845);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(274, 37);
            this.label17.TabIndex = 120;
            this.label17.Text = "Employment date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(111, 1038);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 37);
            this.label13.TabIndex = 119;
            this.label13.Text = "Job title:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(111, 937);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 37);
            this.label10.TabIndex = 118;
            this.label10.Text = "Telephone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 747);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 37);
            this.label4.TabIndex = 117;
            this.label4.Text = "Home address:";
            // 
            // textCity
            // 
            this.textCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCity.Location = new System.Drawing.Point(775, 788);
            this.textCity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(286, 44);
            this.textCity.TabIndex = 116;
            // 
            // textBirthPlace
            // 
            this.textBirthPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBirthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBirthPlace.Location = new System.Drawing.Point(446, 687);
            this.textBirthPlace.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBirthPlace.Name = "textBirthPlace";
            this.textBirthPlace.Size = new System.Drawing.Size(286, 44);
            this.textBirthPlace.TabIndex = 132;
            // 
            // textPostalCode
            // 
            this.textPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPostalCode.Location = new System.Drawing.Point(113, 886);
            this.textPostalCode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textPostalCode.Name = "textPostalCode";
            this.textPostalCode.Size = new System.Drawing.Size(290, 44);
            this.textPostalCode.TabIndex = 131;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(106, 554);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 37);
            this.label9.TabIndex = 115;
            this.label9.Text = "First name:";
            // 
            // textEmail
            // 
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(775, 975);
            this.textEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(286, 44);
            this.textEmail.TabIndex = 135;
            // 
            // textMobile
            // 
            this.textMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMobile.Location = new System.Drawing.Point(446, 975);
            this.textMobile.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textMobile.Name = "textMobile";
            this.textMobile.Size = new System.Drawing.Size(286, 44);
            this.textMobile.TabIndex = 134;
            // 
            // textTelephone
            // 
            this.textTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelephone.Location = new System.Drawing.Point(111, 978);
            this.textTelephone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textTelephone.Name = "textTelephone";
            this.textTelephone.Size = new System.Drawing.Size(292, 44);
            this.textTelephone.TabIndex = 133;
            // 
            // textHomeAddress
            // 
            this.textHomeAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textHomeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHomeAddress.Location = new System.Drawing.Point(111, 788);
            this.textHomeAddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textHomeAddress.Name = "textHomeAddress";
            this.textHomeAddress.Size = new System.Drawing.Size(621, 44);
            this.textHomeAddress.TabIndex = 114;
            // 
            // textOIB
            // 
            this.textOIB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textOIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOIB.Location = new System.Drawing.Point(775, 595);
            this.textOIB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textOIB.Name = "textOIB";
            this.textOIB.Size = new System.Drawing.Size(286, 44);
            this.textOIB.TabIndex = 111;
            // 
            // textLastName
            // 
            this.textLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLastName.Location = new System.Drawing.Point(448, 595);
            this.textLastName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(286, 44);
            this.textLastName.TabIndex = 110;
            // 
            // textFirstName
            // 
            this.textFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFirstName.Location = new System.Drawing.Point(113, 595);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(290, 44);
            this.textFirstName.TabIndex = 109;
            // 
            // textSearchID
            // 
            this.textSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchID.Location = new System.Drawing.Point(1416, 698);
            this.textSearchID.Name = "textSearchID";
            this.textSearchID.Size = new System.Drawing.Size(187, 40);
            this.textSearchID.TabIndex = 155;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(1103, 679);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(243, 77);
            this.buttonSearch.TabIndex = 154;
            this.buttonSearch.Text = "SEARCH by ID";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(1103, 554);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(500, 90);
            this.buttonDisplay.TabIndex = 153;
            this.buttonDisplay.Text = "DISPLAY LIST";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(1103, 1113);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(500, 106);
            this.buttonDelete.TabIndex = 151;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(1103, 955);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(500, 108);
            this.buttonEdit.TabIndex = 150;
            this.buttonEdit.Text = "UPDATE";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(1103, 806);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(500, 94);
            this.buttonInsert.TabIndex = 149;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(415, 1035);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 31);
            this.label6.TabIndex = 156;
            this.label6.Text = "ID";
            // 
            // textTitleID
            // 
            this.textTitleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTitleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitleID.Location = new System.Drawing.Point(411, 1076);
            this.textTitleID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textTitleID.Name = "textTitleID";
            this.textTitleID.Size = new System.Drawing.Size(52, 44);
            this.textTitleID.TabIndex = 157;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(415, 1134);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 31);
            this.label7.TabIndex = 158;
            this.label7.Text = "ID";
            // 
            // textStatusID
            // 
            this.textStatusID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textStatusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatusID.Location = new System.Drawing.Point(411, 1175);
            this.textStatusID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textStatusID.Name = "textStatusID";
            this.textStatusID.Size = new System.Drawing.Size(52, 44);
            this.textStatusID.TabIndex = 159;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.Location = new System.Drawing.Point(883, 1034);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 31);
            this.label21.TabIndex = 160;
            this.label21.Text = "ID";
            // 
            // textDepartmentID
            // 
            this.textDepartmentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDepartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDepartmentID.Location = new System.Drawing.Point(879, 1075);
            this.textDepartmentID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textDepartmentID.Name = "textDepartmentID";
            this.textDepartmentID.Size = new System.Drawing.Size(52, 44);
            this.textDepartmentID.TabIndex = 161;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label22.Location = new System.Drawing.Point(883, 1133);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 31);
            this.label22.TabIndex = 162;
            this.label22.Text = "ID";
            // 
            // textBranchID
            // 
            this.textBranchID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBranchID.Location = new System.Drawing.Point(879, 1174);
            this.textBranchID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBranchID.Name = "textBranchID";
            this.textBranchID.Size = new System.Drawing.Size(52, 44);
            this.textBranchID.TabIndex = 163;
            // 
            // buttonPdf
            // 
            this.buttonPdf.Location = new System.Drawing.Point(1240, 12);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(363, 51);
            this.buttonPdf.TabIndex = 164;
            this.buttonPdf.Text = "PDF";
            this.buttonPdf.UseVisualStyleBackColor = true;
            this.buttonPdf.Click += new System.EventHandler(this.buttonPdf_Click_1);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1802, 1947);
            this.Controls.Add(this.buttonPdf);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBranchID);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textDepartmentID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textStatusID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textTitleID);
            this.Controls.Add(this.textSearchID);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSalary);
            this.Controls.Add(this.dgEmployees);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.boxEmploymentStatus);
            this.Controls.Add(this.boxBranch);
            this.Controls.Add(this.boxDepartment);
            this.Controls.Add(this.boxJobTitle);
            this.Controls.Add(this.boxGender);
            this.Controls.Add(this.dateEmployment);
            this.Controls.Add(this.dateBirthday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textBirthPlace);
            this.Controls.Add(this.textPostalCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textMobile);
            this.Controls.Add(this.textTelephone);
            this.Controls.Add(this.textHomeAddress);
            this.Controls.Add(this.textOIB);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.MinimumSize = new System.Drawing.Size(1828, 2018);
            this.Name = "EmployeesForm";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.DataGridView dgEmployees;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox boxEmploymentStatus;
        private System.Windows.Forms.ComboBox boxBranch;
        private System.Windows.Forms.ComboBox boxDepartment;
        private System.Windows.Forms.ComboBox boxJobTitle;
        private System.Windows.Forms.ComboBox boxGender;
        private System.Windows.Forms.DateTimePicker dateEmployment;
        private System.Windows.Forms.DateTimePicker dateBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textBirthPlace;
        private System.Windows.Forms.TextBox textPostalCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textMobile;
        private System.Windows.Forms.TextBox textTelephone;
        private System.Windows.Forms.TextBox textHomeAddress;
        private System.Windows.Forms.TextBox textOIB;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textSearchID;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTitleID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textStatusID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textDepartmentID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBranchID;
        private System.Windows.Forms.Button buttonPdf;
    }
}