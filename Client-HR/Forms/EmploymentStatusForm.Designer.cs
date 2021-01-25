
namespace Client_HR.Forms
{
    partial class EmploymentStatusForm
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
            this.textSearchID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textStatusName = new System.Windows.Forms.TextBox();
            this.dgStatuses = new System.Windows.Forms.DataGridView();
            this.buttonPdf = new System.Windows.Forms.Button();
            this.buttonStatusEmployees = new System.Windows.Forms.Button();
            this.buttonPdfById = new System.Windows.Forms.Button();
            this.dgById = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgStatuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgById)).BeginInit();
            this.SuspendLayout();
            // 
            // textSearchID
            // 
            this.textSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchID.Location = new System.Drawing.Point(226, 305);
            this.textSearchID.Name = "textSearchID";
            this.textSearchID.Size = new System.Drawing.Size(159, 40);
            this.textSearchID.TabIndex = 50;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(52, 299);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(159, 51);
            this.buttonSearch.TabIndex = 49;
            this.buttonSearch.Text = "Get by ID";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(50, 198);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(536, 65);
            this.buttonDisplay.TabIndex = 48;
            this.buttonDisplay.Text = "DISPLAY LIST";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 47;
            this.label1.Text = "Status";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(429, 504);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(159, 124);
            this.buttonDelete.TabIndex = 46;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(244, 504);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(159, 124);
            this.buttonEdit.TabIndex = 45;
            this.buttonEdit.Text = "UPDATE";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(52, 504);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(159, 124);
            this.buttonInsert.TabIndex = 44;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textStatusName
            // 
            this.textStatusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatusName.Location = new System.Drawing.Point(226, 404);
            this.textStatusName.Name = "textStatusName";
            this.textStatusName.Size = new System.Drawing.Size(362, 40);
            this.textStatusName.TabIndex = 43;
            // 
            // dgStatuses
            // 
            this.dgStatuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStatuses.Location = new System.Drawing.Point(626, 136);
            this.dgStatuses.Name = "dgStatuses";
            this.dgStatuses.RowHeadersWidth = 82;
            this.dgStatuses.RowTemplate.Height = 33;
            this.dgStatuses.Size = new System.Drawing.Size(782, 342);
            this.dgStatuses.TabIndex = 42;
            this.dgStatuses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgStatuses_MouseClick);
            // 
            // buttonPdf
            // 
            this.buttonPdf.Location = new System.Drawing.Point(626, 52);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(371, 51);
            this.buttonPdf.TabIndex = 71;
            this.buttonPdf.Text = "PDF Statuses";
            this.buttonPdf.UseVisualStyleBackColor = true;
            this.buttonPdf.Click += new System.EventHandler(this.buttonPdf_Click);
            // 
            // buttonStatusEmployees
            // 
            this.buttonStatusEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatusEmployees.Location = new System.Drawing.Point(407, 299);
            this.buttonStatusEmployees.Name = "buttonStatusEmployees";
            this.buttonStatusEmployees.Size = new System.Drawing.Size(181, 51);
            this.buttonStatusEmployees.TabIndex = 76;
            this.buttonStatusEmployees.Text = "Employees";
            this.buttonStatusEmployees.UseVisualStyleBackColor = true;
            this.buttonStatusEmployees.Click += new System.EventHandler(this.buttonStatusEmployees_Click);
            // 
            // buttonPdfById
            // 
            this.buttonPdfById.Location = new System.Drawing.Point(1029, 50);
            this.buttonPdfById.Name = "buttonPdfById";
            this.buttonPdfById.Size = new System.Drawing.Size(379, 53);
            this.buttonPdfById.TabIndex = 77;
            this.buttonPdfById.Text = "PDF Employees by Status";
            this.buttonPdfById.UseVisualStyleBackColor = true;
            this.buttonPdfById.Click += new System.EventHandler(this.buttonPdfById_Click);
            // 
            // dgById
            // 
            this.dgById.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgById.Location = new System.Drawing.Point(626, 504);
            this.dgById.Name = "dgById";
            this.dgById.RowHeadersWidth = 82;
            this.dgById.RowTemplate.Height = 33;
            this.dgById.Size = new System.Drawing.Size(782, 260);
            this.dgById.TabIndex = 78;
            // 
            // EmploymentStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 810);
            this.Controls.Add(this.dgById);
            this.Controls.Add(this.buttonPdfById);
            this.Controls.Add(this.buttonStatusEmployees);
            this.Controls.Add(this.buttonPdf);
            this.Controls.Add(this.textSearchID);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textStatusName);
            this.Controls.Add(this.dgStatuses);
            this.Name = "EmploymentStatusForm";
            this.Text = "Employment Statuses";
            ((System.ComponentModel.ISupportInitialize)(this.dgStatuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgById)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSearchID;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textStatusName;
        private System.Windows.Forms.DataGridView dgStatuses;
        private System.Windows.Forms.Button buttonPdf;
        private System.Windows.Forms.Button buttonStatusEmployees;
        private System.Windows.Forms.Button buttonPdfById;
        private System.Windows.Forms.DataGridView dgById;
    }
}