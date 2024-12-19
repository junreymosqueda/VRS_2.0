namespace VRS_2._0
{
    partial class Staffrules
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvall = new System.Windows.Forms.DataGridView();
            this.btnproceed = new Guna.UI2.WinForms.Guna2Button();
            this.cbselection = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvall)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(628, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "RULES AND VIOLATION";
            // 
            // dgvall
            // 
            this.dgvall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvall.Location = new System.Drawing.Point(92, 170);
            this.dgvall.Name = "dgvall";
            this.dgvall.ReadOnly = true;
            this.dgvall.RowHeadersWidth = 51;
            this.dgvall.RowTemplate.Height = 24;
            this.dgvall.Size = new System.Drawing.Size(1620, 591);
            this.dgvall.TabIndex = 2;
            // 
            // btnproceed
            // 
            this.btnproceed.CheckedState.Parent = this.btnproceed;
            this.btnproceed.CustomImages.Parent = this.btnproceed;
            this.btnproceed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnproceed.ForeColor = System.Drawing.Color.White;
            this.btnproceed.HoverState.Parent = this.btnproceed;
            this.btnproceed.Location = new System.Drawing.Point(1334, 125);
            this.btnproceed.Name = "btnproceed";
            this.btnproceed.ShadowDecoration.Parent = this.btnproceed;
            this.btnproceed.Size = new System.Drawing.Size(130, 39);
            this.btnproceed.TabIndex = 10;
            this.btnproceed.Text = "PROCEED";
            this.btnproceed.Click += new System.EventHandler(this.btnproceed_Click);
            // 
            // cbselection
            // 
            this.cbselection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbselection.FormattingEnabled = true;
            this.cbselection.Location = new System.Drawing.Point(1482, 125);
            this.cbselection.Name = "cbselection";
            this.cbselection.Size = new System.Drawing.Size(230, 39);
            this.cbselection.TabIndex = 9;
            // 
            // Staffrules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(159)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.btnproceed);
            this.Controls.Add(this.cbselection);
            this.Controls.Add(this.dgvall);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Staffrules";
            this.Size = new System.Drawing.Size(1800, 802);
            ((System.ComponentModel.ISupportInitialize)(this.dgvall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvall;
        private Guna.UI2.WinForms.Guna2Button btnproceed;
        private System.Windows.Forms.ComboBox cbselection;
    }
}
