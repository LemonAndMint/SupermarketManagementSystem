
namespace SupermarketManagementSystem
{
	partial class Login
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.Button();
            this.hidePassword = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "hello world";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(122)))), ((int)(((byte)(91)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 12.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(56, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.panel1.Location = new System.Drawing.Point(27, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 2);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.panel2.Location = new System.Drawing.Point(27, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 2);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(65)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(159, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "exit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textUsername
            // 
            this.textUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(65)))), ((int)(((byte)(59)))));
            this.textUsername.Location = new System.Drawing.Point(66, 260);
            this.textUsername.Multiline = true;
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(264, 23);
            this.textUsername.TabIndex = 11;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(65)))), ((int)(((byte)(59)))));
            this.textPassword.Location = new System.Drawing.Point(66, 347);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(264, 23);
            this.textPassword.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label3.Location = new System.Drawing.Point(56, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.label4.Location = new System.Drawing.Point(56, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(65)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Supermarket";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(65)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(13, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Management System";
            // 
            // showPassword
            // 
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.showPassword.Image = global::SupermarketManagementSystem.Properties.Resources.eye;
            this.showPassword.Location = new System.Drawing.Point(297, 339);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(33, 31);
            this.showPassword.TabIndex = 18;
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // hidePassword
            // 
            this.hidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.hidePassword.Image = global::SupermarketManagementSystem.Properties.Resources.invisible_eye;
            this.hidePassword.Location = new System.Drawing.Point(297, 339);
            this.hidePassword.Name = "hidePassword";
            this.hidePassword.Size = new System.Drawing.Size(33, 31);
            this.hidePassword.TabIndex = 19;
            this.hidePassword.UseVisualStyleBackColor = true;
            this.hidePassword.Click += new System.EventHandler(this.hidePassword_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SupermarketManagementSystem.Properties.Resources.password_icon;
            this.pictureBox3.Location = new System.Drawing.Point(27, 339);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SupermarketManagementSystem.Properties.Resources.user_icon;
            this.pictureBox2.Location = new System.Drawing.Point(27, 252);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.pictureBox1.Image = global::SupermarketManagementSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(261, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::SupermarketManagementSystem.Properties.Resources.untitled__1_;
            this.pictureBox4.Location = new System.Drawing.Point(60, -473);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(837, 758);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(65)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(27, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "! Invalid username or password";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(368, 556);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.hidePassword);
            this.Controls.Add(this.textPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button showPassword;
        private System.Windows.Forms.Button hidePassword;
        private System.Windows.Forms.Label label7;
    }
}

