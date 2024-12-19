
namespace VRS_2._0
{
    partial class Archive_user
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
            this.userarchive = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userarchive)).BeginInit();
            this.SuspendLayout();
            // 
            // userarchive
            // 
            this.userarchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userarchive.Location = new System.Drawing.Point(53, 90);
            this.userarchive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userarchive.Name = "userarchive";
            this.userarchive.RowHeadersWidth = 51;
            this.userarchive.RowTemplate.Height = 24;
            this.userarchive.Size = new System.Drawing.Size(873, 510);
            this.userarchive.TabIndex = 0;
            this.userarchive.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userarchive_CellClick);
            this.userarchive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userarchive_CellContentClick);
            // 
            // Archive_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 727);
            this.Controls.Add(this.userarchive);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Archive_user";
            this.Text = "Archive_user";
            ((System.ComponentModel.ISupportInitialize)(this.userarchive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userarchive;
    }
}