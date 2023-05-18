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
    public partial class Add_payment : Form
    {
        DataBase db = new DataBase();
        public Add_payment()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void Add_payment_Load(object sender, EventArgs e)
        {
            Type_combobox.Items.AddRange(new string[] { "Жил. фонд", "Кап. ремонт" });

            date_serv.CustomFormat = "dd-MM-yyyy";
            date_serv.Value = Data.date_serv;

            date_serv.CustomFormat = "dd-MM-yyyy";
            date_payment.Value = Data.date_serv;

        }
        private int Type_of_Serv()
        {
            string selectedState = Type_combobox.SelectedItem.ToString();
            int id_type_service = 0;
            if (selectedState == "Жил. фонд")
            {
                return 1;// id_type_service = 1;
            }
            else if (selectedState == "Кап. ремонт")
            {
                //id_type_service = 2;
                return 2;
            }
            else
            {
                return 0;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            db.openConnection();

            double payment;
            if (double.TryParse(Summa_textbox.Text, out payment))
            {
                //if (Data.last_date.Subtract(date_read).TotalDays > 15 && Data.last_date.Subtract(date_read).TotalDays < 22)
                try
                {
                    int apar_id = Data.id_Apartm;
                    
                    date_serv.CustomFormat = "dd-MM-yyyy";
                    string format = "dd/MM/yyyy";
                    var date_read = date_serv.Value;

                    date_payment.CustomFormat = "dd-MM-yyyy";
                    var date_p = date_payment.Value;

                    // string strdate = "\'" + date_read.Day.ToString() + "/" + date_read.Month.ToString() + "/" + date_read.Year.ToString() + "\'";

                    //string strdate = "\'" + date_read.Month.ToString() + "/" + date_read.Day.ToString() + "/" + date_read.Year.ToString() + "\'";

                    //string reading_true = Reading_textbox.Text.Replace(",", ".");
                    int typeser = Type_of_Serv();

                    var addquery = $"insert Service(id_Apartment_service, id_Type_Service, Service_date) values ('{apar_id}', '{typeser}', '" + date_read.ToString(format) + "')";
                    var command = new SqlCommand(addquery, db.GetConnection());
                    command.ExecuteNonQuery();

                    SqlConnection connection = db.GetConnection();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = $"SELECT id_Service FROM Service WHERE id_Type_Service = '{typeser}' and Service_date = '"+ date_read.ToString(format) +"'";
                    //MessageBox.Show("Запись1 успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int result = ((int)cmd.ExecuteScalar());

                    addquery = $"insert Service_Payment(id_Service, Date_of_payment, Summa_of_payment) values ('{result}', '{date_p.ToString(format)}', '{double.Parse(Summa_textbox.Text)}')";
                    command = new SqlCommand(addquery, db.GetConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
                catch (Exception ex)
                {
                    string exstr = ex.ToString();
                    MessageBox.Show(exstr, "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Сумма должна быть числовыми", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            db.closeConnection();
        }
    }
}
