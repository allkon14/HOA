using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbHOA
{
    public partial class Add_Form : Form
    {

        int meter_id = Data.meter_id;
        double reading = Data.reading;
        DateTime last_date = Data.last_date;

        DataBase dataBase = new DataBase();


        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void erase_pic_Click(object sender, EventArgs e)
        {
            Meter_id_textbox.Text = "";
            Reading_textbox.Text = "";
            //dateTimePicker1.Value = ;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            
            double reading;
            if (double.TryParse(Reading_textbox.Text, out reading))
            {
                //if (Data.last_date.Subtract(date_read).TotalDays > 15 && Data.last_date.Subtract(date_read).TotalDays < 22)
                try
                {
                    int meter_id = int.Parse(Meter_id_textbox.Text);
                    //var reading = Reading_textbox.Text;
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    string format = "dd/MM/yyyy";
                    var date_read = dateTimePicker1.Value;
                    string month = date_read.Month / 100 < 9 ? "0" + date_read.Month.ToString() : date_read.Month.ToString();
                    string day = date_read.Day / 100 < 9 ? "0" + date_read.Day.ToString() : date_read.Day.ToString();


                    // string strdate = "\'" + date_read.Day.ToString() + "/" + date_read.Month.ToString() + "/" + date_read.Year.ToString() + "\'";

                    //string strdate = "\'" + date_read.Month.ToString() + "/" + date_read.Day.ToString() + "/" + date_read.Year.ToString() + "\'";


                    string reading_true = Reading_textbox.Text.Replace(",", ".");

                    var addquery = $"insert Meter_Readings (id_Meter, Reading, Payment_date) values ('{meter_id}', '{reading}', '"+date_read.ToString(format)+"')";
                    var command = new SqlCommand(addquery, dataBase.GetConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    string exstr = ex.ToString();
                    MessageBox.Show(exstr, "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Показание должно быть числовыми", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            dataBase.closeConnection();
        }

        private void Add_Form_Load(object sender, EventArgs e)
        {
            Meter_id_textbox.Text = Data.meter_id.ToString();
            Reading_textbox.Text = Data.reading.ToString();
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Value = Data.last_date;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
