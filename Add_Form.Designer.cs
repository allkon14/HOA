
namespace dbHOA
{
    partial class Add_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.erase_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Meter_id_textbox = new System.Windows.Forms.TextBox();
            this.Reading_textbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Save_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erase_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.erase_pic);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 97);
            this.panel1.TabIndex = 0;
            // 
            // erase_pic
            // 
            this.erase_pic.Image = ((System.Drawing.Image)(resources.GetObject("erase_pic.Image")));
            this.erase_pic.Location = new System.Drawing.Point(623, 12);
            this.erase_pic.Name = "erase_pic";
            this.erase_pic.Size = new System.Drawing.Size(123, 73);
            this.erase_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erase_pic.TabIndex = 1;
            this.erase_pic.TabStop = false;
            this.erase_pic.Click += new System.EventHandler(this.erase_pic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление новой записи";
            // 
            // Meter_id_textbox
            // 
            this.Meter_id_textbox.Location = new System.Drawing.Point(329, 194);
            this.Meter_id_textbox.Name = "Meter_id_textbox";
            this.Meter_id_textbox.Size = new System.Drawing.Size(100, 22);
            this.Meter_id_textbox.TabIndex = 1;
            // 
            // Reading_textbox
            // 
            this.Reading_textbox.Location = new System.Drawing.Point(329, 237);
            this.Reading_textbox.Name = "Reading_textbox";
            this.Reading_textbox.Size = new System.Drawing.Size(100, 22);
            this.Reading_textbox.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(329, 283);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2023, 5, 16, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(577, 356);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 5;
            this.Save_btn.Text = "button1";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Reading_textbox);
            this.Controls.Add(this.Meter_id_textbox);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Form";
            this.Text = "Добавление показания";
            this.Load += new System.EventHandler(this.Add_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erase_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox erase_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Meter_id_textbox;
        private System.Windows.Forms.TextBox Reading_textbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Save_btn;
    }
}