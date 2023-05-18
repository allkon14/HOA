
namespace dbHOA
{
    partial class Add_payment
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
            this.Type_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_serv = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Summa_textbox = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.date_payment = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Type_combobox
            // 
            this.Type_combobox.FormattingEnabled = true;
            this.Type_combobox.Location = new System.Drawing.Point(246, 87);
            this.Type_combobox.Name = "Type_combobox";
            this.Type_combobox.Size = new System.Drawing.Size(200, 24);
            this.Type_combobox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип услуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата выполнения услуги";
            // 
            // date_serv
            // 
            this.date_serv.Location = new System.Drawing.Point(246, 160);
            this.date_serv.Name = "date_serv";
            this.date_serv.Size = new System.Drawing.Size(200, 22);
            this.date_serv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сумма оплаты";
            // 
            // Summa_textbox
            // 
            this.Summa_textbox.Location = new System.Drawing.Point(246, 235);
            this.Summa_textbox.Name = "Summa_textbox";
            this.Summa_textbox.Size = new System.Drawing.Size(200, 22);
            this.Summa_textbox.TabIndex = 5;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(544, 302);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(141, 86);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // date_payment
            // 
            this.date_payment.Location = new System.Drawing.Point(246, 302);
            this.date_payment.Name = "date_payment";
            this.date_payment.Size = new System.Drawing.Size(200, 22);
            this.date_payment.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата оплаты";
            // 
            // Add_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.date_payment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.Summa_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_serv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Type_combobox);
            this.Name = "Add_payment";
            this.Text = "Add_payment";
            this.Load += new System.EventHandler(this.Add_payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Type_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_serv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Summa_textbox;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.DateTimePicker date_payment;
        private System.Windows.Forms.Label label4;
    }
}