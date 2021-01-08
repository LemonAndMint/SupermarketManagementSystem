
namespace SupermarketManagementSystem
{
    partial class SubFormCari
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
			this.textBox1.Location = new System.Drawing.Point(77, 136);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(160, 53);
			this.textBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(74, 114);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Enter the Barcode :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(65)))), ((int)(((byte)(59)))));
			this.label2.Location = new System.Drawing.Point(311, 34);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "CARİ";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(331, 136);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(268, 248);
			this.dataGridView1.TabIndex = 3;
			// 
			// employeeBindingSource1
			// 
			this.employeeBindingSource1.DataSource = typeof(SupermarketManagementSystem.database.Employee);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(481, 437);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 21);
			this.label4.TabIndex = 5;
			this.label4.Text = "Total Fee :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(74, 239);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Add the Customer :";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
			this.textBox2.Location = new System.Drawing.Point(77, 262);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(160, 53);
			this.textBox2.TabIndex = 6;
			// 
			// employeeBindingSource
			// 
			this.employeeBindingSource.DataSource = typeof(SupermarketManagementSystem.database.Employee);
			// 
			// supplierBindingSource
			// 
			this.supplierBindingSource.DataSource = typeof(SupermarketManagementSystem.database.Supplier);
			// 
			// SubFormCari
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
			this.ClientSize = new System.Drawing.Size(737, 496);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "SubFormCari";
			this.Text = "SubFormCari";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.BindingSource employeeBindingSource;
		private System.Windows.Forms.BindingSource supplierBindingSource;
		private System.Windows.Forms.BindingSource employeeBindingSource1;
	}
}