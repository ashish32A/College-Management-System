namespace CollegeMgmtSystem
{
    partial class Fees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Sid = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.period = new System.Windows.Forms.DateTimePicker();
            this.Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.feesNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegemanagementDataSet10 = new CollegeMgmtSystem.CollegemanagementDataSet10();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.feesTblTableAdapter = new CollegeMgmtSystem.CollegemanagementDataSet10TableAdapters.FeesTblTableAdapter();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegemanagementDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 129);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(502, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 48);
            this.label2.TabIndex = 10;
            this.label2.Text = "Account";
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
            this.label1.Location = new System.Drawing.Point(308, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "College Management System";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(43, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 32);
            this.label5.TabIndex = 60;
            this.label5.Text = "Name";
            // 
            // Sid
            // 
            this.Sid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sid.FormattingEnabled = true;
            this.Sid.Location = new System.Drawing.Point(177, 247);
            this.Sid.Name = "Sid";
            this.Sid.Size = new System.Drawing.Size(197, 28);
            this.Sid.TabIndex = 59;
            this.Sid.Text = "Select";
            this.Sid.SelectionChangeCommitted += new System.EventHandler(this.Sid_SelectionChangeCommitted);
            this.Sid.SelectedValueChanged += new System.EventHandler(this.Sid_SelectedValueChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.Location = new System.Drawing.Point(153, 490);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 47);
            this.button3.TabIndex = 58;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Location = new System.Drawing.Point(277, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 43);
            this.button2.TabIndex = 57;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(153, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 43);
            this.button1.TabIndex = 56;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.Location = new System.Drawing.Point(37, 427);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 43);
            this.button4.TabIndex = 55;
            this.button4.Text = "Pay";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // period
            // 
            this.period.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.period.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period.Location = new System.Drawing.Point(177, 327);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(197, 28);
            this.period.TabIndex = 54;
            // 
            // Name
            // 
            this.Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(177, 283);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(197, 36);
            this.Name.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(43, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 30);
            this.label6.TabIndex = 47;
            this.label6.Text = "Period";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(43, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 36);
            this.label4.TabIndex = 46;
            this.label4.Text = "StdId";
            // 
            // Num
            // 
            this.Num.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num.Location = new System.Drawing.Point(177, 198);
            this.Num.Multiline = true;
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(197, 36);
            this.Num.TabIndex = 45;
            this.Num.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(43, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 36);
            this.label3.TabIndex = 44;
            this.label3.Text = "FeesNum";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(684, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 48);
            this.label10.TabIndex = 62;
            this.label10.Text = "Payment  List";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feesNumDataGridViewTextBoxColumn,
            this.stdIDDataGridViewTextBoxColumn,
            this.stdNameDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.feesTblBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(419, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(763, 522);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // feesNumDataGridViewTextBoxColumn
            // 
            this.feesNumDataGridViewTextBoxColumn.DataPropertyName = "FeesNum";
            this.feesNumDataGridViewTextBoxColumn.HeaderText = "FeesNum";
            this.feesNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feesNumDataGridViewTextBoxColumn.Name = "feesNumDataGridViewTextBoxColumn";
            this.feesNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.feesNumDataGridViewTextBoxColumn.Width = 150;
            // 
            // stdIDDataGridViewTextBoxColumn
            // 
            this.stdIDDataGridViewTextBoxColumn.DataPropertyName = "StdID";
            this.stdIDDataGridViewTextBoxColumn.HeaderText = "StdID";
            this.stdIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdIDDataGridViewTextBoxColumn.Name = "stdIDDataGridViewTextBoxColumn";
            this.stdIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stdIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // stdNameDataGridViewTextBoxColumn
            // 
            this.stdNameDataGridViewTextBoxColumn.DataPropertyName = "StdName";
            this.stdNameDataGridViewTextBoxColumn.HeaderText = "StdName";
            this.stdNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdNameDataGridViewTextBoxColumn.Name = "stdNameDataGridViewTextBoxColumn";
            this.stdNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stdNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "Period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            this.periodDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodDataGridViewTextBoxColumn.Width = 120;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 200;
            // 
            // feesTblBindingSource
            // 
            this.feesTblBindingSource.DataMember = "FeesTbl";
            this.feesTblBindingSource.DataSource = this.collegemanagementDataSet10;
            // 
            // collegemanagementDataSet10
            // 
            this.collegemanagementDataSet10.DataSetName = "CollegemanagementDataSet10";
            this.collegemanagementDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(178, 374);
            this.Amount.Multiline = true;
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(197, 36);
            this.Amount.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(44, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 36);
            this.label7.TabIndex = 63;
            this.label7.Text = "Amount";
            // 
            // feesTblTableAdapter
            // 
            this.feesTblTableAdapter.ClearBeforeFill = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 730);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1194, 25);
            this.panel10.TabIndex = 65;
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 755);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Sid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.period);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Fees_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegemanagementDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Sid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker period;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label7;
        private CollegemanagementDataSet10 collegemanagementDataSet10;
        private System.Windows.Forms.BindingSource feesTblBindingSource;
        private CollegemanagementDataSet10TableAdapters.FeesTblTableAdapter feesTblTableAdapter;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridViewTextBoxColumn feesNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}