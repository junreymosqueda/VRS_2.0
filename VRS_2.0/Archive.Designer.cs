
namespace VRS_2._0
{
    partial class Archive
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvarchive = new System.Windows.Forms.DataGridView();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnrestore = new Guna.UI2.WinForms.Guna2Button();
            this.cbtable = new System.Windows.Forms.ComboBox();
            this.btnok = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarchive)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvarchive
            // 
            this.dgvarchive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvarchive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvarchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvarchive.Location = new System.Drawing.Point(79, 68);
            this.dgvarchive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvarchive.Name = "dgvarchive";
            this.dgvarchive.RowHeadersVisible = false;
            this.dgvarchive.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvarchive.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvarchive.RowTemplate.Height = 24;
            this.dgvarchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvarchive.Size = new System.Drawing.Size(1639, 643);
            this.dgvarchive.TabIndex = 0;
            this.dgvarchive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btndelete.CheckedState.Parent = this.btndelete;
            this.btndelete.CustomImages.Parent = this.btndelete;
            this.btndelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btndelete.HoverState.Parent = this.btndelete;
            this.btndelete.Location = new System.Drawing.Point(1291, 734);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.ShadowDecoration.Parent = this.btndelete;
            this.btndelete.Size = new System.Drawing.Size(180, 46);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "DELETE";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnrestore
            // 
            this.btnrestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestore.CheckedState.Parent = this.btnrestore;
            this.btnrestore.CustomImages.Parent = this.btnrestore;
            this.btnrestore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnrestore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestore.ForeColor = System.Drawing.Color.White;
            this.btnrestore.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnrestore.HoverState.Parent = this.btnrestore;
            this.btnrestore.Location = new System.Drawing.Point(1513, 734);
            this.btnrestore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrestore.Name = "btnrestore";
            this.btnrestore.ShadowDecoration.Parent = this.btnrestore;
            this.btnrestore.Size = new System.Drawing.Size(180, 46);
            this.btnrestore.TabIndex = 2;
            this.btnrestore.Text = "RESTORE";
            this.btnrestore.Click += new System.EventHandler(this.btnrestore_Click);
            // 
            // cbtable
            // 
            this.cbtable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbtable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtable.FormattingEnabled = true;
            this.cbtable.Location = new System.Drawing.Point(1490, 12);
            this.cbtable.Name = "cbtable";
            this.cbtable.Size = new System.Drawing.Size(228, 44);
            this.cbtable.TabIndex = 3;
            // 
            // btnok
            // 
            this.btnok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnok.CheckedState.Parent = this.btnok;
            this.btnok.CustomImages.Parent = this.btnok;
            this.btnok.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnok.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnok.HoverState.Parent = this.btnok;
            this.btnok.Location = new System.Drawing.Point(1304, 11);
            this.btnok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnok.Name = "btnok";
            this.btnok.ShadowDecoration.Parent = this.btnok;
            this.btnok.Size = new System.Drawing.Size(180, 46);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "PEOCEED";
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 799);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.cbtable);
            this.Controls.Add(this.btnrestore);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dgvarchive);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Archive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archive";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvarchive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvarchive;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2Button btnrestore;
        private System.Windows.Forms.ComboBox cbtable;
        private Guna.UI2.WinForms.Guna2Button btnok;
    }
}