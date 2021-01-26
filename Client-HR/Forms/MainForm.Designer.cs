
namespace Client_HR.Forms
{
    partial class MainForm
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
            this.buttonPdf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eMPLOYEESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgMain = new System.Windows.Forms.DataGridView();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPdf
            // 
            this.buttonPdf.Location = new System.Drawing.Point(672, -136);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(363, 51);
            this.buttonPdf.TabIndex = 80;
            this.buttonPdf.Text = "PDF";
            this.buttonPdf.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-235, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 76;
            this.label1.Text = "Department";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(-227, 356);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(159, 124);
            this.buttonInsert.TabIndex = 73;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(859, 51);
            this.label2.TabIndex = 84;
            this.label2.Text = "Welcome to the Human Resource System";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eMPLOYEESToolStripMenuItem,
            this.branchesToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.titlesToolStripMenuItem,
            this.statusesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1606, 59);
            this.menuStrip1.TabIndex = 86;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eMPLOYEESToolStripMenuItem
            // 
            this.eMPLOYEESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.eMPLOYEESToolStripMenuItem.Name = "eMPLOYEESToolStripMenuItem";
            this.eMPLOYEESToolStripMenuItem.Size = new System.Drawing.Size(221, 55);
            this.eMPLOYEESToolStripMenuItem.Text = "Employees";
            this.eMPLOYEESToolStripMenuItem.Click += new System.EventHandler(this.eMPLOYEESToolStripMenuItem_Click);
            // 
            // branchesToolStripMenuItem
            // 
            this.branchesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.branchesToolStripMenuItem.Name = "branchesToolStripMenuItem";
            this.branchesToolStripMenuItem.Size = new System.Drawing.Size(194, 55);
            this.branchesToolStripMenuItem.Text = "Branches";
            this.branchesToolStripMenuItem.Click += new System.EventHandler(this.branchesToolStripMenuItem_Click);
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(260, 55);
            this.departmentsToolStripMenuItem.Text = "Departments";
            this.departmentsToolStripMenuItem.Click += new System.EventHandler(this.departmentsToolStripMenuItem_Click);
            // 
            // titlesToolStripMenuItem
            // 
            this.titlesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.titlesToolStripMenuItem.Name = "titlesToolStripMenuItem";
            this.titlesToolStripMenuItem.Size = new System.Drawing.Size(129, 55);
            this.titlesToolStripMenuItem.Text = "Titles";
            this.titlesToolStripMenuItem.Click += new System.EventHandler(this.titlesToolStripMenuItem_Click);
            // 
            // statusesToolStripMenuItem
            // 
            this.statusesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.statusesToolStripMenuItem.Name = "statusesToolStripMenuItem";
            this.statusesToolStripMenuItem.Size = new System.Drawing.Size(180, 55);
            this.statusesToolStripMenuItem.Text = "Statuses";
            this.statusesToolStripMenuItem.Click += new System.EventHandler(this.statusesToolStripMenuItem_Click);
            // 
            // dgMain
            // 
            this.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMain.Location = new System.Drawing.Point(31, 319);
            this.dgMain.Name = "dgMain";
            this.dgMain.RowHeadersWidth = 82;
            this.dgMain.RowTemplate.Height = 33;
            this.dgMain.Size = new System.Drawing.Size(1537, 691);
            this.dgMain.TabIndex = 88;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(31, 243);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(562, 48);
            this.buttonDisplay.TabIndex = 154;
            this.buttonDisplay.Text = "DISPLAY ALL EMPLOYEES";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(1006, 243);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(562, 48);
            this.btnPdf.TabIndex = 155;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 1142);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.dgMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPdf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eMPLOYEESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgMain;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button btnPdf;
    }
}