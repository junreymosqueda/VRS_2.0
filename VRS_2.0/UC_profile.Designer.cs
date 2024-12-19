namespace VRS_2._0
{
    partial class UC_profile1
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
            this.btneditpro = new Guna.UI2.WinForms.Guna2Button();
            this.btnarchive = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btneditpro
            // 
            this.btneditpro.CheckedState.Parent = this.btneditpro;
            this.btneditpro.CustomImages.Parent = this.btneditpro;
            this.btneditpro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btneditpro.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btneditpro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditpro.ForeColor = System.Drawing.Color.White;
            this.btneditpro.HoverState.FillColor = System.Drawing.Color.LightGreen;
            this.btneditpro.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btneditpro.HoverState.Parent = this.btneditpro;
            this.btneditpro.Location = new System.Drawing.Point(0, 0);
            this.btneditpro.Name = "btneditpro";
            this.btneditpro.ShadowDecoration.Parent = this.btneditpro;
            this.btneditpro.Size = new System.Drawing.Size(159, 45);
            this.btneditpro.TabIndex = 0;
            this.btneditpro.Text = "EDIT PROFILE";
            this.btneditpro.Click += new System.EventHandler(this.btneditpro_Click);
            // 
            // btnarchive
            // 
            this.btnarchive.CheckedState.Parent = this.btnarchive;
            this.btnarchive.CustomImages.Parent = this.btnarchive;
            this.btnarchive.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnarchive.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnarchive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnarchive.ForeColor = System.Drawing.Color.White;
            this.btnarchive.HoverState.FillColor = System.Drawing.Color.LightGreen;
            this.btnarchive.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnarchive.HoverState.Parent = this.btnarchive;
            this.btnarchive.Location = new System.Drawing.Point(0, 45);
            this.btnarchive.Name = "btnarchive";
            this.btnarchive.ShadowDecoration.Parent = this.btnarchive;
            this.btnarchive.Size = new System.Drawing.Size(159, 45);
            this.btnarchive.TabIndex = 1;
            this.btnarchive.Text = "ARCHIVE";
            this.btnarchive.Click += new System.EventHandler(this.btnarchive_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.CheckedState.Parent = this.btnlogout;
            this.btnlogout.CustomImages.Parent = this.btnlogout;
            this.btnlogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnlogout.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.HoverState.FillColor = System.Drawing.Color.LightGreen;
            this.btnlogout.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnlogout.HoverState.Parent = this.btnlogout;
            this.btnlogout.Location = new System.Drawing.Point(0, 90);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.ShadowDecoration.Parent = this.btnlogout;
            this.btnlogout.Size = new System.Drawing.Size(159, 45);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Text = "LOG OUT";
            this.btnlogout.MouseLeave += new System.EventHandler(this.btnlogout_MouseLeave);
            // 
            // UC_profile1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnarchive);
            this.Controls.Add(this.btneditpro);
            this.Location = new System.Drawing.Point(1140, 0);
            this.Name = "UC_profile1";
            this.Size = new System.Drawing.Size(159, 135);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btneditpro;
        private Guna.UI2.WinForms.Guna2Button btnarchive;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
    }
}
