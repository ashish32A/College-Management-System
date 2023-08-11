namespace CollegeMgmtSystem
{
    partial class Department
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.depNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegemanagementDataSet1 = new CollegeMgmtSystem.CollegemanagementDataSet1();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Durat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DepName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.departmentTblTableAdapter = new CollegeMgmtSystem.CollegemanagementDataSet1TableAdapters.DepartmentTblTableAdapter();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegemanagementDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 124);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(474, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 48);
            this.label2.TabIndex = 10;
            this.label2.Text = "Departments";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.RoyalBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Location = new System.Drawing.Point(1155, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 47);
            this.button7.TabIndex = 9;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(308, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "College Management System";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(651, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(295, 48);
            this.label10.TabIndex = 76;
            this.label10.Text = "Departments List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depNameDataGridViewTextBoxColumn,
            this.depDescDataGridViewTextBoxColumn,
            this.depDurationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departmentTblBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(414, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(763, 522);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // depNameDataGridViewTextBoxColumn
            // 
            this.depNameDataGridViewTextBoxColumn.DataPropertyName = "DepName";
            this.depNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.depNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depNameDataGridViewTextBoxColumn.Name = "depNameDataGridViewTextBoxColumn";
            this.depNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.depNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // depDescDataGridViewTextBoxColumn
            // 
            this.depDescDataGridViewTextBoxColumn.DataPropertyName = "DepDesc";
            this.depDescDataGridViewTextBoxColumn.HeaderText = "Description";
            this.depDescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depDescDataGridViewTextBoxColumn.Name = "depDescDataGridViewTextBoxColumn";
            this.depDescDataGridViewTextBoxColumn.ReadOnly = true;
            this.depDescDataGridViewTextBoxColumn.Width = 260;
            // 
            // depDurationDataGridViewTextBoxColumn
            // 
            this.depDurationDataGridViewTextBoxColumn.DataPropertyName = "DepDuration";
            this.depDurationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.depDurationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depDurationDataGridViewTextBoxColumn.Name = "depDurationDataGridViewTextBoxColumn";
            this.depDurationDataGridViewTextBoxColumn.ReadOnly = true;
            this.depDurationDataGridViewTextBoxColumn.Width = 250;
            // 
            // departmentTblBindingSource
            // 
            this.departmentTblBindingSource.DataMember = "DepartmentTbl";
            this.departmentTblBindingSource.DataSource = this.collegemanagementDataSet1;
            // 
            // collegemanagementDataSet1
            // 
            this.collegemanagementDataSet1.DataSetName = "CollegemanagementDataSet1";
            this.collegemanagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.Location = new System.Drawing.Point(144, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 47);
            this.button3.TabIndex = 74;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Location = new System.Drawing.Point(268, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 43);
            this.button2.TabIndex = 73;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(144, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 43);
            this.button1.TabIndex = 72;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.Location = new System.Drawing.Point(28, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 43);
            this.button4.TabIndex = 71;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Durat
            // 
            this.Durat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Durat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Durat.Location = new System.Drawing.Point(171, 290);
            this.Durat.Multiline = true;
            this.Durat.Name = "Durat";
            this.Durat.Size = new System.Drawing.Size(205, 36);
            this.Durat.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(28, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 36);
            this.label5.TabIndex = 69;
            this.label5.Text = "Duration";
            // 
            // Desc
            // 
            this.Desc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc.Location = new System.Drawing.Point(171, 234);
            this.Desc.Multiline = true;
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(205, 36);
            this.Desc.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(23, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 36);
            this.label4.TabIndex = 67;
            this.label4.Text = "Description";
            // 
            // DepName
            // 
            this.DepName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepName.Location = new System.Drawing.Point(171, 185);
            this.DepName.Multiline = true;
            this.DepName.Name = "DepName";
            this.DepName.Size = new System.Drawing.Size(205, 36);
            this.DepName.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 36);
            this.label3.TabIndex = 65;
            this.label3.Text = "Name";
            // 
            // departmentTblTableAdapter
            // 
            this.departmentTblTableAdapter.ClearBeforeFill = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 740);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1191, 25);
            this.panel10.TabIndex = 77;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 765);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Durat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DepName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegemanagementDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Durat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DepName;
        private System.Windows.Forms.Label label3;
        private CollegemanagementDataSet1 collegemanagementDataSet1;
        private System.Windows.Forms.BindingSource departmentTblBindingSource;
        private CollegemanagementDataSet1TableAdapters.DepartmentTblTableAdapter departmentTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn depNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel10;
    }
}