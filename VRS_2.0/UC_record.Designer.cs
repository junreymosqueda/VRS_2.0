namespace VRS_2._0
{
    partial class UC_record
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvrecord = new System.Windows.Forms.DataGridView();
            this.btnreset = new Guna.UI2.WinForms.Guna2Button();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnedit = new Guna.UI2.WinForms.Guna2Button();
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.panelrecord = new System.Windows.Forms.Panel();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.tbwitness = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpdeadline = new System.Windows.Forms.DateTimePicker();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.cbviolation = new System.Windows.Forms.ComboBox();
            this.cbsemester = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbpunishment = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tboffence = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbcourse = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbcontact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbmiddlename = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbfirstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tblastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsave = new Guna.UI2.WinForms.Guna2Button();
            this.btncancel = new Guna.UI2.WinForms.Guna2Button();
            this.tbstudentID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.cbyearsection = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecord)).BeginInit();
            this.panelrecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbsearch
            // 
            this.tbsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearch.Location = new System.Drawing.Point(1000, 8);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(347, 31);
            this.tbsearch.TabIndex = 0;
            this.tbsearch.TextChanged += new System.EventHandler(this.tbsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(910, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "SEARCH";
            // 
            // dgvrecord
            // 
            this.dgvrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrecord.Location = new System.Drawing.Point(0, 56);
            this.dgvrecord.Name = "dgvrecord";
            this.dgvrecord.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvrecord.RowHeadersVisible = false;
            this.dgvrecord.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvrecord.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvrecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrecord.Size = new System.Drawing.Size(1365, 530);
            this.dgvrecord.TabIndex = 2;
            this.dgvrecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrecord_CellClick);
            this.dgvrecord.SelectionChanged += new System.EventHandler(this.dgvrecord_SelectionChanged_1);
            // 
            // btnreset
            // 
            this.btnreset.BorderThickness = 1;
            this.btnreset.CheckedState.Parent = this.btnreset;
            this.btnreset.CustomImages.Parent = this.btnreset;
            this.btnreset.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnreset.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.Black;
            this.btnreset.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnreset.HoverState.Parent = this.btnreset;
            this.btnreset.Location = new System.Drawing.Point(1208, 599);
            this.btnreset.Name = "btnreset";
            this.btnreset.ShadowDecoration.Parent = this.btnreset;
            this.btnreset.Size = new System.Drawing.Size(125, 42);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "RESET";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btndelete
            // 
            this.btndelete.BorderThickness = 1;
            this.btndelete.CheckedState.Parent = this.btndelete;
            this.btndelete.CustomImages.Parent = this.btndelete;
            this.btndelete.FillColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndelete.HoverState.Parent = this.btndelete;
            this.btndelete.Location = new System.Drawing.Point(986, 599);
            this.btndelete.Name = "btndelete";
            this.btndelete.ShadowDecoration.Parent = this.btndelete;
            this.btndelete.Size = new System.Drawing.Size(125, 42);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "DELETE";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BorderThickness = 1;
            this.btnedit.CheckedState.Parent = this.btnedit;
            this.btnedit.CustomImages.Parent = this.btnedit;
            this.btnedit.Enabled = false;
            this.btnedit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnedit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.Black;
            this.btnedit.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnedit.HoverState.Parent = this.btnedit;
            this.btnedit.Location = new System.Drawing.Point(826, 599);
            this.btnedit.Name = "btnedit";
            this.btnedit.ShadowDecoration.Parent = this.btnedit;
            this.btnedit.Size = new System.Drawing.Size(125, 42);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "EDIT";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BorderThickness = 1;
            this.btnadd.CheckedState.Parent = this.btnadd;
            this.btnadd.CustomImages.Parent = this.btnadd;
            this.btnadd.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnadd.HoverState.Parent = this.btnadd;
            this.btnadd.Location = new System.Drawing.Point(667, 599);
            this.btnadd.Name = "btnadd";
            this.btnadd.ShadowDecoration.Parent = this.btnadd;
            this.btnadd.Size = new System.Drawing.Size(125, 42);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "ADD";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panelrecord
            // 
            this.panelrecord.Controls.Add(this.cbyearsection);
            this.panelrecord.Controls.Add(this.cbstatus);
            this.panelrecord.Controls.Add(this.btnupdate);
            this.panelrecord.Controls.Add(this.tbwitness);
            this.panelrecord.Controls.Add(this.label16);
            this.panelrecord.Controls.Add(this.dtpdeadline);
            this.panelrecord.Controls.Add(this.dtpdate);
            this.panelrecord.Controls.Add(this.cbviolation);
            this.panelrecord.Controls.Add(this.cbsemester);
            this.panelrecord.Controls.Add(this.label8);
            this.panelrecord.Controls.Add(this.label9);
            this.panelrecord.Controls.Add(this.label10);
            this.panelrecord.Controls.Add(this.label11);
            this.panelrecord.Controls.Add(this.tbpunishment);
            this.panelrecord.Controls.Add(this.label12);
            this.panelrecord.Controls.Add(this.label13);
            this.panelrecord.Controls.Add(this.tboffence);
            this.panelrecord.Controls.Add(this.label14);
            this.panelrecord.Controls.Add(this.cbcourse);
            this.panelrecord.Controls.Add(this.label7);
            this.panelrecord.Controls.Add(this.label4);
            this.panelrecord.Controls.Add(this.tbcontact);
            this.panelrecord.Controls.Add(this.label5);
            this.panelrecord.Controls.Add(this.tbmiddlename);
            this.panelrecord.Controls.Add(this.label6);
            this.panelrecord.Controls.Add(this.tbfirstname);
            this.panelrecord.Controls.Add(this.label3);
            this.panelrecord.Controls.Add(this.tblastname);
            this.panelrecord.Controls.Add(this.label2);
            this.panelrecord.Controls.Add(this.btnsave);
            this.panelrecord.Controls.Add(this.btncancel);
            this.panelrecord.Controls.Add(this.tbstudentID);
            this.panelrecord.Controls.Add(this.label15);
            this.panelrecord.Location = new System.Drawing.Point(3, 8);
            this.panelrecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelrecord.Name = "panelrecord";
            this.panelrecord.Size = new System.Drawing.Size(560, 635);
            this.panelrecord.TabIndex = 7;
            this.panelrecord.Visible = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BorderThickness = 1;
            this.btnupdate.CheckedState.Parent = this.btnupdate;
            this.btnupdate.CustomImages.Parent = this.btnupdate;
            this.btnupdate.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnupdate.HoverState.Parent = this.btnupdate;
            this.btnupdate.Location = new System.Drawing.Point(152, 584);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.ShadowDecoration.Parent = this.btnupdate;
            this.btnupdate.Size = new System.Drawing.Size(103, 37);
            this.btnupdate.TabIndex = 66;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // tbwitness
            // 
            this.tbwitness.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbwitness.Location = new System.Drawing.Point(309, 170);
            this.tbwitness.Name = "tbwitness";
            this.tbwitness.Size = new System.Drawing.Size(232, 33);
            this.tbwitness.TabIndex = 65;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(306, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 17);
            this.label16.TabIndex = 64;
            this.label16.Text = "Witness";
            // 
            // dtpdeadline
            // 
            this.dtpdeadline.CalendarFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdeadline.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdeadline.Location = new System.Drawing.Point(309, 382);
            this.dtpdeadline.Name = "dtpdeadline";
            this.dtpdeadline.Size = new System.Drawing.Size(232, 33);
            this.dtpdeadline.TabIndex = 62;
            // 
            // dtpdate
            // 
            this.dtpdate.CalendarFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(309, 240);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(232, 33);
            this.dtpdate.TabIndex = 61;
            // 
            // cbviolation
            // 
            this.cbviolation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbviolation.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbviolation.FormattingEnabled = true;
            this.cbviolation.Items.AddRange(new object[] {
            "No ID",
            "Improper uniform ",
            "Cutting classes",
            "Wearing caps/hats",
            "PDA",
            "Bullying ",
            "Smoking ",
            "Stealing ",
            "Cheating ",
            "Plagiarism"});
            this.cbviolation.Location = new System.Drawing.Point(309, 28);
            this.cbviolation.Name = "cbviolation";
            this.cbviolation.Size = new System.Drawing.Size(232, 32);
            this.cbviolation.TabIndex = 60;
            // 
            // cbsemester
            // 
            this.cbsemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsemester.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsemester.FormattingEnabled = true;
            this.cbsemester.Items.AddRange(new object[] {
            "1st",
            "2nd"});
            this.cbsemester.Location = new System.Drawing.Point(23, 533);
            this.cbsemester.Name = "cbsemester";
            this.cbsemester.Size = new System.Drawing.Size(232, 32);
            this.cbsemester.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Offense:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "Semester:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(306, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(306, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 55;
            this.label11.Text = "Deadline:";
            // 
            // tbpunishment
            // 
            this.tbpunishment.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpunishment.Location = new System.Drawing.Point(309, 313);
            this.tbpunishment.Name = "tbpunishment";
            this.tbpunishment.Size = new System.Drawing.Size(232, 33);
            this.tbpunishment.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(306, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 53;
            this.label12.Text = "Punishment:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(306, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 52;
            this.label13.Text = "Date:";
            // 
            // tboffence
            // 
            this.tboffence.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboffence.Location = new System.Drawing.Point(309, 96);
            this.tboffence.Name = "tboffence";
            this.tboffence.Size = new System.Drawing.Size(232, 33);
            this.tboffence.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(306, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 17);
            this.label14.TabIndex = 50;
            this.label14.Text = "Violation:";
            // 
            // cbcourse
            // 
            this.cbcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcourse.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcourse.FormattingEnabled = true;
            this.cbcourse.Items.AddRange(new object[] {
            "ACT",
            "BSIS",
            "BSOM",
            "BSAIS",
            "BTVTED",
            "HRS",
            "CS",
            "BSCA",
            "BTVTED"});
            this.cbcourse.Location = new System.Drawing.Point(23, 384);
            this.cbcourse.Name = "cbcourse";
            this.cbcourse.Size = new System.Drawing.Size(232, 32);
            this.cbcourse.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Year and Section:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Course:";
            // 
            // tbcontact
            // 
            this.tbcontact.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontact.Location = new System.Drawing.Point(23, 312);
            this.tbcontact.Name = "tbcontact";
            this.tbcontact.Size = new System.Drawing.Size(232, 33);
            this.tbcontact.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Contact:";
            // 
            // tbmiddlename
            // 
            this.tbmiddlename.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmiddlename.Location = new System.Drawing.Point(23, 243);
            this.tbmiddlename.Name = "tbmiddlename";
            this.tbmiddlename.Size = new System.Drawing.Size(232, 33);
            this.tbmiddlename.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Middle name:";
            // 
            // tbfirstname
            // 
            this.tbfirstname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfirstname.Location = new System.Drawing.Point(23, 170);
            this.tbfirstname.Name = "tbfirstname";
            this.tbfirstname.Size = new System.Drawing.Size(232, 33);
            this.tbfirstname.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "First name:";
            // 
            // tblastname
            // 
            this.tblastname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblastname.Location = new System.Drawing.Point(23, 96);
            this.tblastname.Name = "tblastname";
            this.tblastname.Size = new System.Drawing.Size(232, 33);
            this.tblastname.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Last name:";
            // 
            // btnsave
            // 
            this.btnsave.BorderThickness = 1;
            this.btnsave.CheckedState.Parent = this.btnsave;
            this.btnsave.CustomImages.Parent = this.btnsave;
            this.btnsave.FillColor = System.Drawing.Color.Gray;
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnsave.HoverState.Parent = this.btnsave;
            this.btnsave.Location = new System.Drawing.Point(152, 584);
            this.btnsave.Name = "btnsave";
            this.btnsave.ShadowDecoration.Parent = this.btnsave;
            this.btnsave.Size = new System.Drawing.Size(103, 37);
            this.btnsave.TabIndex = 37;
            this.btnsave.Text = "SAVE";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.BorderThickness = 1;
            this.btncancel.CheckedState.Parent = this.btncancel;
            this.btncancel.CustomImages.Parent = this.btncancel;
            this.btncancel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btncancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Black;
            this.btncancel.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btncancel.HoverState.Parent = this.btncancel;
            this.btncancel.Location = new System.Drawing.Point(309, 584);
            this.btncancel.Name = "btncancel";
            this.btncancel.ShadowDecoration.Parent = this.btncancel;
            this.btncancel.Size = new System.Drawing.Size(103, 37);
            this.btncancel.TabIndex = 36;
            this.btncancel.Text = "CANCEL";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // tbstudentID
            // 
            this.tbstudentID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbstudentID.Location = new System.Drawing.Point(23, 28);
            this.tbstudentID.Name = "tbstudentID";
            this.tbstudentID.Size = new System.Drawing.Size(232, 33);
            this.tbstudentID.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "Student ID:";
            // 
            // cbstatus
            // 
            this.cbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstatus.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "Done",
            "Pending",
            "Undone"});
            this.cbstatus.Location = new System.Drawing.Point(309, 455);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(232, 31);
            this.cbstatus.TabIndex = 67;
            this.cbstatus.SelectedIndexChanged += new System.EventHandler(this.cbstatus_SelectedIndexChanged);
            // 
            // cbyearsection
            // 
            this.cbyearsection.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbyearsection.Location = new System.Drawing.Point(23, 464);
            this.cbyearsection.Name = "cbyearsection";
            this.cbyearsection.Size = new System.Drawing.Size(232, 33);
            this.cbyearsection.TabIndex = 68;
            // 
            // UC_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelrecord);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.dgvrecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbsearch);
            this.Name = "UC_record";
            this.Size = new System.Drawing.Size(1350, 652);
            this.Load += new System.EventHandler(this.UC_record_Load);
            this.Click += new System.EventHandler(this.UC_record_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecord)).EndInit();
            this.panelrecord.ResumeLayout(false);
            this.panelrecord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvrecord;
        private Guna.UI2.WinForms.Guna2Button btnreset;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2Button btnedit;
        private Guna.UI2.WinForms.Guna2Button btnadd;
        private System.Windows.Forms.Panel panelrecord;
        private System.Windows.Forms.DateTimePicker dtpdeadline;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.ComboBox cbviolation;
        private System.Windows.Forms.ComboBox cbsemester;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbpunishment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tboffence;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbcourse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbcontact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbmiddlename;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbfirstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tblastname;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnsave;
        private Guna.UI2.WinForms.Guna2Button btncancel;
        private System.Windows.Forms.TextBox tbstudentID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbwitness;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.TextBox cbyearsection;
    }
}
