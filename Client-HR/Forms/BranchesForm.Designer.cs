
namespace Client_HR.Forms
{
    partial class Branches
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textSearchID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textTelephone = new System.Windows.Forms.TextBox();
            this.textPostalCode = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textBranchName = new System.Windows.Forms.TextBox();
            this.dgBranches = new System.Windows.Forms.DataGridView();
            this.buttonBranchEmployees = new System.Windows.Forms.Button();
            this.buttonPdf = new System.Windows.Forms.Button();
            this.dgByID = new System.Windows.Forms.DataGridView();
            this.buttonPdfByID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBranches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgByID)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(378, 839);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(151, 124);
            this.buttonDelete.TabIndex = 67;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(189, 839);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(159, 124);
            this.buttonEdit.TabIndex = 66;
            this.buttonEdit.Text = "UPDATE";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(13, 839);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(147, 124);
            this.buttonInsert.TabIndex = 65;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textSearchID
            // 
            this.textSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchID.Location = new System.Drawing.Point(189, 262);
            this.textSearchID.Name = "textSearchID";
            this.textSearchID.Size = new System.Drawing.Size(133, 40);
            this.textSearchID.TabIndex = 64;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(13, 256);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(151, 51);
            this.buttonSearch.TabIndex = 63;
            this.buttonSearch.Text = "Get by ID:";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(13, 166);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(518, 51);
            this.buttonDisplay.TabIndex = 62;
            this.buttonDisplay.Text = "DISPLAY BRANCHES";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 723);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 33);
            this.label5.TabIndex = 61;
            this.label5.Text = "Telephone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 640);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 33);
            this.label4.TabIndex = 60;
            this.label4.Text = "Postal code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 33);
            this.label3.TabIndex = 59;
            this.label3.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 33);
            this.label2.TabIndex = 58;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 33);
            this.label1.TabIndex = 57;
            this.label1.Text = "Name:";
            // 
            // textTelephone
            // 
            this.textTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelephone.Location = new System.Drawing.Point(189, 723);
            this.textTelephone.Name = "textTelephone";
            this.textTelephone.Size = new System.Drawing.Size(342, 40);
            this.textTelephone.TabIndex = 56;
            // 
            // textPostalCode
            // 
            this.textPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPostalCode.Location = new System.Drawing.Point(189, 637);
            this.textPostalCode.Name = "textPostalCode";
            this.textPostalCode.Size = new System.Drawing.Size(342, 40);
            this.textPostalCode.TabIndex = 55;
            // 
            // textCity
            // 
            this.textCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCity.Location = new System.Drawing.Point(189, 547);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(342, 40);
            this.textCity.TabIndex = 54;
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(189, 457);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(342, 40);
            this.textAddress.TabIndex = 53;
            // 
            // textBranchName
            // 
            this.textBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBranchName.Location = new System.Drawing.Point(189, 373);
            this.textBranchName.Name = "textBranchName";
            this.textBranchName.Size = new System.Drawing.Size(342, 40);
            this.textBranchName.TabIndex = 52;
            // 
            // dgBranches
            // 
            this.dgBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBranches.Location = new System.Drawing.Point(559, 106);
            this.dgBranches.Name = "dgBranches";
            this.dgBranches.RowHeadersWidth = 82;
            this.dgBranches.RowTemplate.Height = 33;
            this.dgBranches.Size = new System.Drawing.Size(1101, 613);
            this.dgBranches.TabIndex = 51;
            this.dgBranches.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgBranches_MouseClick_1);
            // 
            // buttonBranchEmployees
            // 
            this.buttonBranchEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBranchEmployees.Location = new System.Drawing.Point(348, 256);
            this.buttonBranchEmployees.Name = "buttonBranchEmployees";
            this.buttonBranchEmployees.Size = new System.Drawing.Size(181, 51);
            this.buttonBranchEmployees.TabIndex = 68;
            this.buttonBranchEmployees.Text = "Employees";
            this.buttonBranchEmployees.UseVisualStyleBackColor = true;
            this.buttonBranchEmployees.Click += new System.EventHandler(this.buttonBranchEmployees_Click);
            // 
            // buttonPdf
            // 
            this.buttonPdf.Location = new System.Drawing.Point(871, 22);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(363, 51);
            this.buttonPdf.TabIndex = 69;
            this.buttonPdf.Text = "PDF Branches";
            this.buttonPdf.UseVisualStyleBackColor = true;
            this.buttonPdf.Click += new System.EventHandler(this.buttonPdf_Click);
            // 
            // dgByID
            // 
            this.dgByID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgByID.Location = new System.Drawing.Point(559, 771);
            this.dgByID.Name = "dgByID";
            this.dgByID.RowHeadersWidth = 82;
            this.dgByID.RowTemplate.Height = 33;
            this.dgByID.Size = new System.Drawing.Size(1101, 249);
            this.dgByID.TabIndex = 70;
            // 
            // buttonPdfByID
            // 
            this.buttonPdfByID.Location = new System.Drawing.Point(1297, 22);
            this.buttonPdfByID.Name = "buttonPdfByID";
            this.buttonPdfByID.Size = new System.Drawing.Size(363, 51);
            this.buttonPdfByID.TabIndex = 71;
            this.buttonPdfByID.Text = "PDF Branch Employees";
            this.buttonPdfByID.UseVisualStyleBackColor = true;
            this.buttonPdfByID.Click += new System.EventHandler(this.buttonPdfByID_Click);
            // 
            // Branches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1698, 1174);
            this.Controls.Add(this.buttonPdfByID);
            this.Controls.Add(this.dgByID);
            this.Controls.Add(this.buttonPdf);
            this.Controls.Add(this.buttonBranchEmployees);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textSearchID);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTelephone);
            this.Controls.Add(this.textPostalCode);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textBranchName);
            this.Controls.Add(this.dgBranches);
            this.Name = "Branches";
            this.Text = "Branches";
            ((System.ComponentModel.ISupportInitialize)(this.dgBranches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgByID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textSearchID;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTelephone;
        private System.Windows.Forms.TextBox textPostalCode;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textBranchName;
        private System.Windows.Forms.DataGridView dgBranches;
        private System.Windows.Forms.Button buttonBranchEmployees;
        private System.Windows.Forms.Button buttonPdf;
        private System.Windows.Forms.DataGridView dgByID;
        private System.Windows.Forms.Button buttonPdfByID;
    }
}