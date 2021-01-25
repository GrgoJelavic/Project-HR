
namespace Client_HR.Forms
{
    partial class DepartmentsForm
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
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textDepartmentName = new System.Windows.Forms.TextBox();
            this.dgDepartments = new System.Windows.Forms.DataGridView();
            this.buttonPdf = new System.Windows.Forms.Button();
            this.buttonDepartmentEmployees = new System.Windows.Forms.Button();
            this.textSearchID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dgDepartmentByid = new System.Windows.Forms.DataGridView();
            this.buttonPdfById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartmentByid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(28, 198);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(536, 65);
            this.buttonDisplay.TabIndex = 39;
            this.buttonDisplay.Text = "DISPLAY LIST";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Department";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(407, 504);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(159, 124);
            this.buttonDelete.TabIndex = 33;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(222, 504);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(159, 124);
            this.buttonEdit.TabIndex = 32;
            this.buttonEdit.Text = "UPDATE";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(28, 504);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(159, 124);
            this.buttonInsert.TabIndex = 31;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textDepartmentName
            // 
            this.textDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDepartmentName.Location = new System.Drawing.Point(204, 404);
            this.textDepartmentName.Name = "textDepartmentName";
            this.textDepartmentName.Size = new System.Drawing.Size(362, 40);
            this.textDepartmentName.TabIndex = 26;
            // 
            // dgDepartments
            // 
            this.dgDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartments.Location = new System.Drawing.Point(602, 138);
            this.dgDepartments.Name = "dgDepartments";
            this.dgDepartments.RowHeadersWidth = 82;
            this.dgDepartments.RowTemplate.Height = 33;
            this.dgDepartments.Size = new System.Drawing.Size(744, 362);
            this.dgDepartments.TabIndex = 25;
            this.dgDepartments.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgDepartments_MouseClick);
            // 
            // buttonPdf
            // 
            this.buttonPdf.Location = new System.Drawing.Point(602, 54);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(357, 51);
            this.buttonPdf.TabIndex = 70;
            this.buttonPdf.Text = "PDF Departments";
            this.buttonPdf.UseVisualStyleBackColor = true;
            this.buttonPdf.Click += new System.EventHandler(this.buttonPdf_Click);
            // 
            // buttonDepartmentEmployees
            // 
            this.buttonDepartmentEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepartmentEmployees.Location = new System.Drawing.Point(383, 310);
            this.buttonDepartmentEmployees.Name = "buttonDepartmentEmployees";
            this.buttonDepartmentEmployees.Size = new System.Drawing.Size(181, 51);
            this.buttonDepartmentEmployees.TabIndex = 73;
            this.buttonDepartmentEmployees.Text = "Employees";
            this.buttonDepartmentEmployees.UseVisualStyleBackColor = true;
            this.buttonDepartmentEmployees.Click += new System.EventHandler(this.buttonDepartmentEmployees_Click);
            // 
            // textSearchID
            // 
            this.textSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchID.Location = new System.Drawing.Point(204, 316);
            this.textSearchID.Name = "textSearchID";
            this.textSearchID.Size = new System.Drawing.Size(151, 40);
            this.textSearchID.TabIndex = 72;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(28, 310);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(151, 51);
            this.buttonSearch.TabIndex = 71;
            this.buttonSearch.Text = "Get by ID:";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // dgDepartmentByid
            // 
            this.dgDepartmentByid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartmentByid.Location = new System.Drawing.Point(602, 542);
            this.dgDepartmentByid.Name = "dgDepartmentByid";
            this.dgDepartmentByid.RowHeadersWidth = 82;
            this.dgDepartmentByid.RowTemplate.Height = 33;
            this.dgDepartmentByid.Size = new System.Drawing.Size(744, 218);
            this.dgDepartmentByid.TabIndex = 74;
            // 
            // buttonPdfById
            // 
            this.buttonPdfById.Location = new System.Drawing.Point(989, 52);
            this.buttonPdfById.Name = "buttonPdfById";
            this.buttonPdfById.Size = new System.Drawing.Size(357, 53);
            this.buttonPdfById.TabIndex = 75;
            this.buttonPdfById.Text = "PDF Department Employees";
            this.buttonPdfById.UseVisualStyleBackColor = true;
            this.buttonPdfById.Click += new System.EventHandler(this.buttonPdfById_Click);
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 786);
            this.Controls.Add(this.buttonPdfById);
            this.Controls.Add(this.dgDepartmentByid);
            this.Controls.Add(this.buttonDepartmentEmployees);
            this.Controls.Add(this.textSearchID);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonPdf);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textDepartmentName);
            this.Controls.Add(this.dgDepartments);
            this.Name = "DepartmentsForm";
            this.Text = "Department";
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartmentByid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textDepartmentName;
        private System.Windows.Forms.DataGridView dgDepartments;
        private System.Windows.Forms.Button buttonPdf;
        private System.Windows.Forms.Button buttonDepartmentEmployees;
        private System.Windows.Forms.TextBox textSearchID;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dgDepartmentByid;
        private System.Windows.Forms.Button buttonPdfById;
    }
}