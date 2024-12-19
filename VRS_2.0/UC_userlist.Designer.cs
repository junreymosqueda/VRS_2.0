namespace VRS_2._0
{
    partial class UC_userlist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvuser = new System.Windows.Forms.DataGridView();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btncreat = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.update = new System.Windows.Forms.Button();
            this.tbncancel = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tblast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbfirst = new System.Windows.Forms.TextBox();
            this.btnup = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvuser
            // 
            this.dgvuser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuser.Location = new System.Drawing.Point(159, 26);
            this.dgvuser.Margin = new System.Windows.Forms.Padding(4);
            this.dgvuser.Name = "dgvuser";
            this.dgvuser.ReadOnly = true;
            this.dgvuser.RowHeadersVisible = false;
            this.dgvuser.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvuser.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvuser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvuser.Size = new System.Drawing.Size(1540, 677);
            this.dgvuser.TabIndex = 0;
            this.dgvuser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvuser_CellClick);
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
            this.btndelete.Location = new System.Drawing.Point(1601, 725);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.ShadowDecoration.Parent = this.btndelete;
            this.btndelete.Size = new System.Drawing.Size(129, 55);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "DELETE";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Gray;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Silver;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(1413, 725);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(129, 55);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "EDIT";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btncreat
            // 
            this.btncreat.BorderThickness = 1;
            this.btncreat.CheckedState.Parent = this.btncreat;
            this.btncreat.CustomImages.Parent = this.btncreat;
            this.btncreat.FillColor = System.Drawing.Color.Gray;
            this.btncreat.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreat.ForeColor = System.Drawing.Color.White;
            this.btncreat.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btncreat.HoverState.Parent = this.btncreat;
            this.btncreat.Location = new System.Drawing.Point(1107, 725);
            this.btncreat.Margin = new System.Windows.Forms.Padding(4);
            this.btncreat.Name = "btncreat";
            this.btncreat.ShadowDecoration.Parent = this.btncreat;
            this.btncreat.Size = new System.Drawing.Size(273, 55);
            this.btncreat.TabIndex = 3;
            this.btncreat.Text = "CREATE ACCOUNT";
            this.btncreat.Click += new System.EventHandler(this.btncreat_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.tbncancel);
            this.panel1.Controls.Add(this.btncreate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbpass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbemail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tblast);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbfirst);
            this.panel1.Controls.Add(this.btnup);
            this.panel1.Controls.Add(this.pb);
            this.panel1.Location = new System.Drawing.Point(3, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 724);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(53, 609);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(131, 46);
            this.update.TabIndex = 38;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Visible = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // tbncancel
            // 
            this.tbncancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbncancel.Location = new System.Drawing.Point(235, 609);
            this.tbncancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbncancel.Name = "tbncancel";
            this.tbncancel.Size = new System.Drawing.Size(133, 46);
            this.tbncancel.TabIndex = 36;
            this.tbncancel.Text = "CANCEL";
            this.tbncancel.UseVisualStyleBackColor = true;
            this.tbncancel.Click += new System.EventHandler(this.tbncancel_Click);
            // 
            // btncreate
            // 
            this.btncreate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(53, 609);
            this.btncreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(131, 46);
            this.btncreate.TabIndex = 35;
            this.btncreate.Text = "CREATE";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 30);
            this.label4.TabIndex = 34;
            this.label4.Text = "Password:";
            // 
            // tbpass
            // 
            this.tbpass.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpass.Location = new System.Drawing.Point(47, 542);
            this.tbpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(320, 40);
            this.tbpass.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 30);
            this.label3.TabIndex = 32;
            this.label3.Text = "Email:";
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.Location = new System.Drawing.Point(47, 459);
            this.tbemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(320, 40);
            this.tbemail.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 30);
            this.label2.TabIndex = 30;
            this.label2.Text = "Last name:";
            // 
            // tblast
            // 
            this.tblast.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblast.Location = new System.Drawing.Point(47, 377);
            this.tblast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblast.Name = "tblast";
            this.tblast.Size = new System.Drawing.Size(320, 40);
            this.tblast.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "First name:";
            // 
            // tbfirst
            // 
            this.tbfirst.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfirst.Location = new System.Drawing.Point(47, 292);
            this.tbfirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbfirst.Name = "tbfirst";
            this.tbfirst.Size = new System.Drawing.Size(320, 40);
            this.tbfirst.TabIndex = 27;
            // 
            // btnup
            // 
            this.btnup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.Location = new System.Drawing.Point(139, 178);
            this.btnup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(128, 41);
            this.btnup.TabIndex = 26;
            this.btnup.Text = "UPLOAD";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pb.Location = new System.Drawing.Point(100, 21);
            this.pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(205, 153);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 25;
            this.pb.TabStop = false;
            // 
            // UC_userlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncreat);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dgvuser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_userlist";
            this.Size = new System.Drawing.Size(1800, 802);
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvuser;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btncreat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tbncancel;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tblast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbfirst;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button update;
    }
}
