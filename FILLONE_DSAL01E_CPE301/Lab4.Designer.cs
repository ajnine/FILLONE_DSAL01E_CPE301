namespace FILLONE_DSAL01E_CPE301
{
    partial class Lab4
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
            this.btnSequenial = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSentinel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSequenial
            // 
            this.btnSequenial.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSequenial.Location = new System.Drawing.Point(523, 18);
            this.btnSequenial.Name = "btnSequenial";
            this.btnSequenial.Size = new System.Drawing.Size(107, 34);
            this.btnSequenial.TabIndex = 5;
            this.btnSequenial.Text = "Sequential";
            this.btnSequenial.UseVisualStyleBackColor = false;
            this.btnSequenial.Click += new System.EventHandler(this.btnSequenial_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(27, 18);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(490, 34);
            this.txtSearch.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 339);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSentinel
            // 
            this.btnSentinel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSentinel.Location = new System.Drawing.Point(636, 18);
            this.btnSentinel.Name = "btnSentinel";
            this.btnSentinel.Size = new System.Drawing.Size(107, 34);
            this.btnSentinel.TabIndex = 6;
            this.btnSentinel.Text = "Sentinel";
            this.btnSentinel.UseVisualStyleBackColor = false;
            this.btnSentinel.Click += new System.EventHandler(this.btnSentinel_Click);
            // 
            // Lab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSentinel);
            this.Controls.Add(this.btnSequenial);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lab4";
            this.Text = "Lab4";
            this.Load += new System.EventHandler(this.Lab4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSequenial;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSentinel;
    }
}