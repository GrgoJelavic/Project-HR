﻿
namespace Client_HR.Forms
{
    partial class JobTitlesForm
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
            this.textJobTitleName = new System.Windows.Forms.TextBox();
            this.dgJobTitles = new System.Windows.Forms.DataGridView();
            this.buttonPdf = new System.Windows.Forms.Button();
            this.buttonTitleEmployees = new System.Windows.Forms.Button();
            this.textSearchID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dgById = new System.Windows.Forms.DataGridView();
            this.buttonPdfById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgJobTitles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgById)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(53, 217);
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
            this.label1.Location = new System.Drawing.Point(61, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 33);
            this.label1.TabIndex = 47;
            this.label1.Text = "Job Title";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(432, 523);
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
            this.buttonEdit.Location = new System.Drawing.Point(247, 523);
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
            this.buttonInsert.Location = new System.Drawing.Point(55, 523);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(159, 124);
            this.buttonInsert.TabIndex = 44;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textJobTitleName
            // 
            this.textJobTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textJobTitleName.Location = new System.Drawing.Point(229, 423);
            this.textJobTitleName.Name = "textJobTitleName";
            this.textJobTitleName.Size = new System.Drawing.Size(362, 40);
            this.textJobTitleName.TabIndex = 43;
            // 
            // dgJobTitles
            // 
            this.dgJobTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJobTitles.Location = new System.Drawing.Point(651, 115);
            this.dgJobTitles.Name = "dgJobTitles";
            this.dgJobTitles.RowHeadersWidth = 82;
            this.dgJobTitles.RowTemplate.Height = 33;
            this.dgJobTitles.Size = new System.Drawing.Size(678, 404);
            this.dgJobTitles.TabIndex = 42;
            this.dgJobTitles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgJobTitles_MouseClick);
            // 
            // buttonPdf
            // 
            this.buttonPdf.Location = new System.Drawing.Point(651, 36);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(319, 51);
            this.buttonPdf.TabIndex = 72;
            this.buttonPdf.Text = "PDF Job Titles";
            this.buttonPdf.UseVisualStyleBackColor = true;
            this.buttonPdf.Click += new System.EventHandler(this.buttonPdf_Click);
            // 
            // buttonTitleEmployees
            // 
            this.buttonTitleEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTitleEmployees.Location = new System.Drawing.Point(408, 330);
            this.buttonTitleEmployees.Name = "buttonTitleEmployees";
            this.buttonTitleEmployees.Size = new System.Drawing.Size(181, 51);
            this.buttonTitleEmployees.TabIndex = 76;
            this.buttonTitleEmployees.Text = "Employees";
            this.buttonTitleEmployees.UseVisualStyleBackColor = true;
            this.buttonTitleEmployees.Click += new System.EventHandler(this.buttonTitleEmployees_Click);
            // 
            // textSearchID
            // 
            this.textSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchID.Location = new System.Drawing.Point(229, 336);
            this.textSearchID.Name = "textSearchID";
            this.textSearchID.Size = new System.Drawing.Size(151, 40);
            this.textSearchID.TabIndex = 75;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(53, 330);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(151, 51);
            this.buttonSearch.TabIndex = 74;
            this.buttonSearch.Text = "Get by ID:";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // dgById
            // 
            this.dgById.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgById.Location = new System.Drawing.Point(651, 565);
            this.dgById.Name = "dgById";
            this.dgById.RowHeadersWidth = 82;
            this.dgById.RowTemplate.Height = 33;
            this.dgById.Size = new System.Drawing.Size(678, 237);
            this.dgById.TabIndex = 77;
            // 
            // buttonPdfById
            // 
            this.buttonPdfById.Location = new System.Drawing.Point(1010, 36);
            this.buttonPdfById.Name = "buttonPdfById";
            this.buttonPdfById.Size = new System.Drawing.Size(319, 51);
            this.buttonPdfById.TabIndex = 78;
            this.buttonPdfById.Text = "PDF Employees by Title";
            this.buttonPdfById.UseVisualStyleBackColor = true;
            this.buttonPdfById.Click += new System.EventHandler(this.buttonPdfById_Click);
            // 
            // JobTitlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 874);
            this.Controls.Add(this.buttonPdfById);
            this.Controls.Add(this.dgById);
            this.Controls.Add(this.buttonTitleEmployees);
            this.Controls.Add(this.textSearchID);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonPdf);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textJobTitleName);
            this.Controls.Add(this.dgJobTitles);
            this.Name = "JobTitlesForm";
            this.Text = "Job Titles ";
            ((System.ComponentModel.ISupportInitialize)(this.dgJobTitles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgById)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textJobTitleName;
        private System.Windows.Forms.DataGridView dgJobTitles;
        private System.Windows.Forms.Button buttonPdf;
        private System.Windows.Forms.Button buttonTitleEmployees;
        private System.Windows.Forms.TextBox textSearchID;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dgById;
        private System.Windows.Forms.Button buttonPdfById;
    }
}