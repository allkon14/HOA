
namespace dbHOA
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgv_Readings_meter = new System.Windows.Forms.DataGridView();
            this.View_Meter = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Total_sum_textBox_main = new System.Windows.Forms.TextBox();
            this.date_textBox_main = new System.Windows.Forms.TextBox();
            this.Reading_textBox_main = new System.Windows.Forms.TextBox();
            this.Meter_id_textBox_main = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.search_pic = new System.Windows.Forms.PictureBox();
            this.update_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_Meter_for_Tenant = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.add_ser_btn = new System.Windows.Forms.Button();
            this.dgv_Service = new System.Windows.Forms.DataGridView();
            this.apartmentTableAdapter1 = new dbHOA.HOADataSetTableAdapters.ApartmentTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Readings_meter)).BeginInit();
            this.View_Meter.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_pic)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Meter_for_Tenant)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Readings_meter
            // 
            this.dgv_Readings_meter.AllowUserToAddRows = false;
            this.dgv_Readings_meter.AllowUserToDeleteRows = false;
            this.dgv_Readings_meter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Readings_meter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Readings_meter.Location = new System.Drawing.Point(6, 129);
            this.dgv_Readings_meter.Name = "dgv_Readings_meter";
            this.dgv_Readings_meter.ReadOnly = true;
            this.dgv_Readings_meter.RowHeadersWidth = 51;
            this.dgv_Readings_meter.RowTemplate.Height = 24;
            this.dgv_Readings_meter.Size = new System.Drawing.Size(1414, 364);
            this.dgv_Readings_meter.TabIndex = 0;
            this.dgv_Readings_meter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Readings_meter_CellContentClick);
            // 
            // View_Meter
            // 
            this.View_Meter.Controls.Add(this.tabPage2);
            this.View_Meter.Controls.Add(this.tabPage1);
            this.View_Meter.Controls.Add(this.tabPage3);
            this.View_Meter.Location = new System.Drawing.Point(12, 12);
            this.View_Meter.Name = "View_Meter";
            this.View_Meter.SelectedIndex = 0;
            this.View_Meter.Size = new System.Drawing.Size(1439, 781);
            this.View_Meter.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.add_btn);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dgv_Readings_meter);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1431, 752);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Просмотр показаний";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Total_sum_textBox_main);
            this.panel2.Controls.Add(this.date_textBox_main);
            this.panel2.Controls.Add(this.Reading_textBox_main);
            this.panel2.Controls.Add(this.Meter_id_textBox_main);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(46, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 204);
            this.panel2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Итоговая сумма";
            // 
            // Total_sum_textBox_main
            // 
            this.Total_sum_textBox_main.Location = new System.Drawing.Point(415, 152);
            this.Total_sum_textBox_main.Name = "Total_sum_textBox_main";
            this.Total_sum_textBox_main.Size = new System.Drawing.Size(100, 26);
            this.Total_sum_textBox_main.TabIndex = 7;
            // 
            // date_textBox_main
            // 
            this.date_textBox_main.Location = new System.Drawing.Point(169, 123);
            this.date_textBox_main.Name = "date_textBox_main";
            this.date_textBox_main.Size = new System.Drawing.Size(100, 26);
            this.date_textBox_main.TabIndex = 6;
            // 
            // Reading_textBox_main
            // 
            this.Reading_textBox_main.Location = new System.Drawing.Point(169, 85);
            this.Reading_textBox_main.Name = "Reading_textBox_main";
            this.Reading_textBox_main.Size = new System.Drawing.Size(100, 26);
            this.Reading_textBox_main.TabIndex = 5;
            // 
            // Meter_id_textBox_main
            // 
            this.Meter_id_textBox_main.Location = new System.Drawing.Point(169, 45);
            this.Meter_id_textBox_main.Name = "Meter_id_textBox_main";
            this.Meter_id_textBox_main.Size = new System.Drawing.Size(100, 26);
            this.Meter_id_textBox_main.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "Поcледнее \r\nпоказание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Счетчик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Запись";
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.add_btn.Location = new System.Drawing.Point(960, 579);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(266, 98);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Добавить показания";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.search_textBox);
            this.panel1.Controls.Add(this.search_pic);
            this.panel1.Controls.Add(this.update_pic);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1414, 70);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // search_textBox
            // 
            this.search_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.search_textBox.Location = new System.Drawing.Point(954, 12);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(448, 45);
            this.search_textBox.TabIndex = 1;
            this.search_textBox.TextChanged += new System.EventHandler(this.search_textBox_TextChanged);
            // 
            // search_pic
            // 
            this.search_pic.Image = ((System.Drawing.Image)(resources.GetObject("search_pic.Image")));
            this.search_pic.Location = new System.Drawing.Point(836, 3);
            this.search_pic.Name = "search_pic";
            this.search_pic.Size = new System.Drawing.Size(112, 64);
            this.search_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search_pic.TabIndex = 4;
            this.search_pic.TabStop = false;
            this.search_pic.Click += new System.EventHandler(this.search_pic_Click);
            // 
            // update_pic
            // 
            this.update_pic.Image = ((System.Drawing.Image)(resources.GetObject("update_pic.Image")));
            this.update_pic.Location = new System.Drawing.Point(759, 3);
            this.update_pic.Name = "update_pic";
            this.update_pic.Size = new System.Drawing.Size(71, 64);
            this.update_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.update_pic.TabIndex = 3;
            this.update_pic.TabStop = false;
            this.update_pic.Click += new System.EventHandler(this.update_pic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Показания счетчиков";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_Meter_for_Tenant);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1431, 752);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Просмотр счетчиков";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgv_Meter_for_Tenant
            // 
            this.dgv_Meter_for_Tenant.AllowUserToAddRows = false;
            this.dgv_Meter_for_Tenant.AllowUserToDeleteRows = false;
            this.dgv_Meter_for_Tenant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Meter_for_Tenant.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_Meter_for_Tenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Meter_for_Tenant.Location = new System.Drawing.Point(27, 115);
            this.dgv_Meter_for_Tenant.Name = "dgv_Meter_for_Tenant";
            this.dgv_Meter_for_Tenant.ReadOnly = true;
            this.dgv_Meter_for_Tenant.RowHeadersWidth = 51;
            this.dgv_Meter_for_Tenant.RowTemplate.Height = 24;
            this.dgv_Meter_for_Tenant.Size = new System.Drawing.Size(1302, 332);
            this.dgv_Meter_for_Tenant.TabIndex = 0;
            this.dgv_Meter_for_Tenant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Meter_for_Tenant_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.add_ser_btn);
            this.tabPage3.Controls.Add(this.dgv_Service);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1431, 752);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Просмотр оплаты за услуги";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // add_ser_btn
            // 
            this.add_ser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.add_ser_btn.Location = new System.Drawing.Point(595, 552);
            this.add_ser_btn.Name = "add_ser_btn";
            this.add_ser_btn.Size = new System.Drawing.Size(266, 115);
            this.add_ser_btn.TabIndex = 7;
            this.add_ser_btn.Text = "Добавить оплату";
            this.add_ser_btn.UseVisualStyleBackColor = true;
            this.add_ser_btn.Click += new System.EventHandler(this.add_ser_btn_Click);
            // 
            // dgv_Service
            // 
            this.dgv_Service.AllowUserToAddRows = false;
            this.dgv_Service.AllowUserToDeleteRows = false;
            this.dgv_Service.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Service.Location = new System.Drawing.Point(10, 215);
            this.dgv_Service.Name = "dgv_Service";
            this.dgv_Service.RowHeadersWidth = 51;
            this.dgv_Service.RowTemplate.Height = 24;
            this.dgv_Service.Size = new System.Drawing.Size(1407, 239);
            this.dgv_Service.TabIndex = 0;
            this.dgv_Service.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Service_CellContentClick);
            // 
            // apartmentTableAdapter1
            // 
            this.apartmentTableAdapter1.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(10, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1407, 75);
            this.panel3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(24, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(452, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "Просмотр оплаты за услуги";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 803);
            this.Controls.Add(this.View_Meter);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Readings_meter)).EndInit();
            this.View_Meter.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_pic)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Meter_for_Tenant)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Readings_meter;
        private System.Windows.Forms.TabControl View_Meter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_Meter_for_Tenant;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.PictureBox update_pic;
        private System.Windows.Forms.PictureBox search_pic;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Total_sum_textBox_main;
        private System.Windows.Forms.TextBox date_textBox_main;
        private System.Windows.Forms.TextBox Reading_textBox_main;
        private System.Windows.Forms.TextBox Meter_id_textBox_main;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_Service;
        private HOADataSetTableAdapters.ApartmentTableAdapter apartmentTableAdapter1;
        private System.Windows.Forms.Button add_ser_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
    }
}