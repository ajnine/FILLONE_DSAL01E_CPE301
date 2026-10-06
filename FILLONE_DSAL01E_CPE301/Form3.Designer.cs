namespace FILLONE_DSAL01E_CPE301
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBTN = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchtxtbox = new System.Windows.Forms.TextBox();
            this.ex1BTN = new System.Windows.Forms.Button();
            this.ex2BTN = new System.Windows.Forms.Button();
            this.ex4BTN = new System.Windows.Forms.Button();
            this.ex3BTN = new System.Windows.Forms.Button();
            this.ex6BTN = new System.Windows.Forms.Button();
            this.ex5BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 419);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.searchBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBTN.Location = new System.Drawing.Point(282, 23);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(134, 34);
            this.searchBTN.TabIndex = 2;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // searchtxtbox
            // 
            this.searchtxtbox.Location = new System.Drawing.Point(12, 23);
            this.searchtxtbox.Multiline = true;
            this.searchtxtbox.Name = "searchtxtbox";
            this.searchtxtbox.Size = new System.Drawing.Size(264, 34);
            this.searchtxtbox.TabIndex = 6;
            // 
            // ex1BTN
            // 
            this.ex1BTN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ex1BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex1BTN.Location = new System.Drawing.Point(422, 23);
            this.ex1BTN.Name = "ex1BTN";
            this.ex1BTN.Size = new System.Drawing.Size(86, 50);
            this.ex1BTN.TabIndex = 8;
            this.ex1BTN.Text = "ex1 - fname";
            this.ex1BTN.UseVisualStyleBackColor = false;
            this.ex1BTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // ex2BTN
            // 
            this.ex2BTN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ex2BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex2BTN.Location = new System.Drawing.Point(514, 23);
            this.ex2BTN.Name = "ex2BTN";
            this.ex2BTN.Size = new System.Drawing.Size(86, 50);
            this.ex2BTN.TabIndex = 9;
            this.ex2BTN.Text = "ex2 - mname";
            this.ex2BTN.UseVisualStyleBackColor = false;
            this.ex2BTN.Click += new System.EventHandler(this.ex2BTN_Click);
            // 
            // ex4BTN
            // 
            this.ex4BTN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ex4BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex4BTN.Location = new System.Drawing.Point(697, 23);
            this.ex4BTN.Name = "ex4BTN";
            this.ex4BTN.Size = new System.Drawing.Size(134, 50);
            this.ex4BTN.TabIndex = 11;
            this.ex4BTN.Text = "ex4 - any category";
            this.ex4BTN.UseVisualStyleBackColor = false;
            this.ex4BTN.Click += new System.EventHandler(this.ex4BTN_Click);
            // 
            // ex3BTN
            // 
            this.ex3BTN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ex3BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex3BTN.Location = new System.Drawing.Point(605, 23);
            this.ex3BTN.Name = "ex3BTN";
            this.ex3BTN.Size = new System.Drawing.Size(86, 50);
            this.ex3BTN.TabIndex = 10;
            this.ex3BTN.Text = "ex3 - sname";
            this.ex3BTN.UseVisualStyleBackColor = false;
            this.ex3BTN.Click += new System.EventHandler(this.ex3BTN_Click);
            // 
            // ex6BTN
            // 
            this.ex6BTN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ex6BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex6BTN.Location = new System.Drawing.Point(927, 24);
            this.ex6BTN.Name = "ex6BTN";
            this.ex6BTN.Size = new System.Drawing.Size(86, 49);
            this.ex6BTN.TabIndex = 13;
            this.ex6BTN.Text = "ex6 - fname";
            this.ex6BTN.UseVisualStyleBackColor = false;
            this.ex6BTN.Click += new System.EventHandler(this.ex6BTN_Click);
            // 
            // ex5BTN
            // 
            this.ex5BTN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ex5BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex5BTN.Location = new System.Drawing.Point(835, 24);
            this.ex5BTN.Name = "ex5BTN";
            this.ex5BTN.Size = new System.Drawing.Size(86, 49);
            this.ex5BTN.TabIndex = 12;
            this.ex5BTN.Text = "ex5 - province";
            this.ex5BTN.UseVisualStyleBackColor = false;
            this.ex5BTN.Click += new System.EventHandler(this.ex5BTN_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1025, 528);
            this.Controls.Add(this.ex6BTN);
            this.Controls.Add(this.ex5BTN);
            this.Controls.Add(this.ex4BTN);
            this.Controls.Add(this.ex3BTN);
            this.Controls.Add(this.ex2BTN);
            this.Controls.Add(this.ex1BTN);
            this.Controls.Add(this.searchtxtbox);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox searchtxtbox;
        private System.Windows.Forms.Button ex1BTN;
        private System.Windows.Forms.Button ex2BTN;
        private System.Windows.Forms.Button ex4BTN;
        private System.Windows.Forms.Button ex3BTN;
        private System.Windows.Forms.Button ex6BTN;
        private System.Windows.Forms.Button ex5BTN;
    }
}