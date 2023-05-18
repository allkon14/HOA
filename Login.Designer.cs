
namespace dbHOA
{
    partial class Login
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
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.login_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.log_in_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.login_label.Location = new System.Drawing.Point(60, 70);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(88, 31);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Логин";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.password_label.Location = new System.Drawing.Point(40, 125);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(108, 31);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Пароль";
            // 
            // login_box
            // 
            this.login_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.login_box.Location = new System.Drawing.Point(182, 70);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(243, 38);
            this.login_box.TabIndex = 2;
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.password_box.Location = new System.Drawing.Point(182, 119);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(243, 38);
            this.password_box.TabIndex = 3;
            // 
            // log_in_btn
            // 
            this.log_in_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.log_in_btn.Location = new System.Drawing.Point(163, 201);
            this.log_in_btn.Name = "log_in_btn";
            this.log_in_btn.Size = new System.Drawing.Size(153, 41);
            this.log_in_btn.TabIndex = 4;
            this.log_in_btn.Text = "Войти";
            this.log_in_btn.UseVisualStyleBackColor = true;
            this.log_in_btn.Click += new System.EventHandler(this.log_in_btn_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 286);
            this.Controls.Add(this.log_in_btn);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Button log_in_btn;
    }
}