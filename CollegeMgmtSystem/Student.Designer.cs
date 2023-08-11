namespace CollegeMgmtSystem
{
    partial class Student
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.fees = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.gender = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stdIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdDepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdFeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegemanagementDataSet9 = new CollegeMgmtSystem.CollegemanagementDataSet9();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dep = new System.Windows.Forms.ComboBox();
            this.studentTblTableAdapter = new CollegeMgmtSystem.CollegemanagementDataSet9TableAdapters.StudentTblTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegemanagementDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 118);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(520, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 48);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.RoyalBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Location = new System.Drawing.Point(1163, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 47);
            this.button7.TabIndex = 9;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "College Management System";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(49, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(165, 169);
            this.id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(201, 36);
            this.id.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(49, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(49, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(49, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "DOB";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(49, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 36);
            this.label7.TabIndex = 9;
            this.label7.Text = "Phone";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(49, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 33);
            this.label8.TabIndex = 10;
            this.label8.Text = "Deptmt";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(49, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 36);
            this.label9.TabIndex = 11;
            this.label9.Text = "Fees";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(165, 218);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(201, 36);
            this.name.TabIndex = 12;
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(165, 346);
            this.phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(201, 36);
            this.phone.TabIndex = 13;
            // 
            // fees
            // 
            this.fees.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fees.Location = new System.Drawing.Point(165, 450);
            this.fees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fees.Multiline = true;
            this.fees.Name = "fees";
            this.fees.Size = new System.Drawing.Size(201, 36);
            this.fees.TabIndex = 15;
            // 
            // dob
            // 
            this.dob.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dob.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(165, 305);
            this.dob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(201, 26);
            this.dob.TabIndex = 16;
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.gender.Location = new System.Drawing.Point(165, 265);
            this.gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(201, 28);
            this.gender.TabIndex = 17;
            this.gender.Text = "Select";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdIDDataGridViewTextBoxColumn,
            this.stdNameDataGridViewTextBoxColumn,
            this.stdGenderDataGridViewTextBoxColumn,
            this.stdDOBDataGridViewTextBoxColumn,
            this.stdPhoneDataGridViewTextBoxColumn,
            this.stdDepDataGridViewTextBoxColumn,
            this.stdFeesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentTblBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(413, 198);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(763, 571);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stdIDDataGridViewTextBoxColumn
            // 
            this.stdIDDataGridViewTextBoxColumn.DataPropertyName = "StdID";
            this.stdIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.stdIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdIDDataGridViewTextBoxColumn.Name = "stdIDDataGridViewTextBoxColumn";
            this.stdIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stdIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // stdNameDataGridViewTextBoxColumn
            // 
            this.stdNameDataGridViewTextBoxColumn.DataPropertyName = "StdName";
            this.stdNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.stdNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdNameDataGridViewTextBoxColumn.Name = "stdNameDataGridViewTextBoxColumn";
            this.stdNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stdNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // stdGenderDataGridViewTextBoxColumn
            // 
            this.stdGenderDataGridViewTextBoxColumn.DataPropertyName = "StdGender";
            this.stdGenderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.stdGenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdGenderDataGridViewTextBoxColumn.Name = "stdGenderDataGridViewTextBoxColumn";
            this.stdGenderDataGridViewTextBoxColumn.ReadOnly = true;
            this.stdGenderDataGridViewTextBoxColumn.Width = 150;
            // 
            // stdDOBDataGridViewTextBoxColumn
            // 
            this.stdDOBDataGridViewTextBoxColumn.DataPropertyName = "StdDOB";
            this.stdDOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.stdDOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdDOBDataGridViewTextBoxColumn.Name = "stdDOBDataGridViewTextBoxColumn";
            this.stdDOBDataGridViewTextBoxColumn.ReadOnly = true;
            this.stdDOBDataGridViewTextBoxColumn.Width = 170;
            // 
            // stdPhoneDataGridViewTextBoxColumn
            // 
            this.stdPhoneDataGridViewTextBoxColumn.DataPropertyName = "StdPhone";
            this.stdPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.stdPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdPhoneDataGridViewTextBoxColumn.Name = "stdPhoneDataGridViewTextBoxColumn";
            this.stdPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.stdPhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // stdDepDataGridViewTextBoxColumn
            // 
            this.stdDepDataGridViewTextBoxColumn.DataPropertyName = "StdDep";
            this.stdDepDataGridViewTextBoxColumn.HeaderText = "Dep";
            this.stdDepDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdDepDataGridViewTextBoxColumn.Name = "stdDepDataGridViewTextBoxColumn";
            this.stdDepDataGridViewTextBoxColumn.ReadOnly = true;
            this.stdDepDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdFeesDataGridViewTextBoxColumn
            // 
            this.stdFeesDataGridViewTextBoxColumn.DataPropertyName = "StdFees";
            this.stdFeesDataGridViewTextBoxColumn.HeaderText = "Fees";
            this.stdFeesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdFeesDataGridViewTextBoxColumn.Name = "stdFeesDataGridViewTextBoxColumn";
            this.stdFeesDataGridViewTextBoxColumn.ReadOnly = true;
            this.stdFeesDataGridViewTextBoxColumn.Width = 130;
            // 
            // studentTblBindingSource
            // 
            this.studentTblBindingSource.DataMember = "StudentTbl";
            this.studentTblBindingSource.DataSource = this.collegemanagementDataSet9;
            // 
            // collegemanagementDataSet9
            // 
            this.collegemanagementDataSet9.DataSetName = "CollegemanagementDataSet9";
            this.collegemanagementDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.Location = new System.Drawing.Point(12, 514);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 43);
            this.button4.TabIndex = 19;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Location = new System.Drawing.Point(271, 514);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 43);
            this.button2.TabIndex = 21;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.Location = new System.Drawing.Point(143, 583);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 47);
            this.button3.TabIndex = 22;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(679, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 48);
            this.label10.TabIndex = 23;
            this.label10.Text = "Student  List";
            // 
            // dep
            // 
            this.dep.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep.FormattingEnabled = true;
            this.dep.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.dep.Location = new System.Drawing.Point(165, 404);
            this.dep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(201, 28);
            this.dep.TabIndex = 24;
            this.dep.Text = "Select";
            this.dep.SelectedIndexChanged += new System.EventHandler(this.dep_SelectedIndexChanged);
            // 
            // studentTblTableAdapter
            // 
            this.studentTblTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(143, 514);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button5.Location = new System.Drawing.Point(627, 155);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 39);
            this.button5.TabIndex = 25;
            this.button5.Text = "No Due List ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button6.Location = new System.Drawing.Point(787, 155);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 39);
            this.button6.TabIndex = 26;
            this.button6.Text = "Refress";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1201, 794);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.fees);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegemanagementDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox fees;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox dep;
        private CollegemanagementDataSet9 collegemanagementDataSet9;
        private System.Windows.Forms.BindingSource studentTblBindingSource;
        private CollegemanagementDataSet9TableAdapters.StudentTblTableAdapter studentTblTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdDepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdFeesDataGridViewTextBoxColumn;
    }
}