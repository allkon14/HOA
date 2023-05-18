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
    

    public partial class MainForm : Form
    {
        DataBase dataBase = new DataBase();
        string log_str = Data.login_str;
        

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        public void CreateColumn()
        {
            dgv_Meter_for_Tenant.Columns.Add("Tenant.FIO", "ФИО");
            dgv_Meter_for_Tenant.Columns.Add("Apartment.Number_of_apartment", "Номер квартиры");
            dgv_Meter_for_Tenant.Columns.Add("House.Name_house", "Номер дома");
            dgv_Meter_for_Tenant.Columns.Add("Street.Name", "Улица");

            dgv_Meter_for_Tenant.Columns.Add("Type_meter.Name", "Тип счетчика");
            //dgv_Meter_for_Tenant.Columns.Add("Meter.id_meter", "ID счетчика");
            dgv_Meter_for_Tenant.Columns.Add("Apartment.Count_of_tenants", "Количество жильцов");
            dgv_Meter_for_Tenant.Columns.Add("Apartment.Square", "Площадь");

        }

        private void ReadRow(DataGridView dgw, IDataReader record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetInt32(5), record.GetDouble(6));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dataBase.openConnection();
            SqlConnection connection = dataBase.GetConnection();
            SqlCommand cmd = connection.CreateCommand();
            int id_ten = int.Parse(log_str); ///

            cmd.CommandText = $"SELECT FIO FROM Tenant WHERE id_tenant = '{id_ten}'";

            string result = ((string)cmd.ExecuteScalar());

            string query = $"SELECT Tenant.FIO, Type_meter.Name, Meter.id_meter, Apartment.Count_of_tenants, Apartment.Square, Apartment.Number_of_apartment, House.Name_house, Street.Name FROM Apartment INNER JOIN House ON Apartment.id_House = House.id_house INNER JOIN Street ON House.id_Street = Street.id_street INNER JOIN Meter ON Apartment.Number_of_apartment = Meter.id_Apartment_meter INNER JOIN Type_meter ON Meter.id_Type_Meter = Type_meter.id_type_meter INNER JOIN Tenant ON Apartment.id_apartment = Tenant.id_Apartment WHERE Tenant.id_tenant = '{log_str}'";

            string q_req = $"select * from vw_Tenant_on_House where FIO = '{result}'";
            SqlCommand command = new SqlCommand(q_req, dataBase.GetConnection());

            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadRow(dgw, reader);
            }
            reader.Close();
        }

        int selectedRow;

        private void dgv_Meter_for_Tenant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //selectedRow = e.RowIndex;
            //if()
        }


        private void Services_Load()
        {
            dataBase.openConnection();
            int id_ten = int.Parse(log_str); ///

            SqlConnection connection = dataBase.GetConnection();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT id_Apartment FROM Tenant WHERE id_tenant = '{id_ten}'";

            int result = ((int)cmd.ExecuteScalar());
            //search_textBox.Text = result.ToString();

            using (SqlCommand command = new SqlCommand("vw_vw_Service_payment_and_surplus", dataBase.GetConnection()))
            {
                //command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.Add(new SqlParameter("@IDApar", SqlDbType.Int));
                //command.Parameters["@IDApar"].Value = result;
                try
                {
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    BindingSource bs = new BindingSource();
                    bs.DataSource = table;

                    dgv_Service.DataSource = bs;
                }
                catch (Exception ex)
                {
                    string exstr = ex.ToString();
                    MessageBox.Show(exstr, "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dataBase.closeConnection();
        }

        public void CreateColumn_Service()
        {
            dgv_Service.Columns.Add("vw_Service_payment_and_surplus.Square", "Площадь");
            dgv_Service.Columns.Add("vw_Service_payment_and_surplus.Name_type_service", "Назавание");
            dgv_Service.Columns.Add("vw_Service_payment_and_surplus.Rate", "Тариф");
            dgv_Service.Columns.Add("vw_Service_payment_and_surplus.Service_date", "Дата услуги");
            dgv_Service.Columns.Add("vw_Service_payment_and_surplus.Summa_of_payment", "Сумма оплаты");
            dgv_Service.Columns.Add("vw_Service_payment_and_surplus.Date_of_payment", "Дата оплаты");
            dgv_Service.Columns.Add("vw_Service_payment_and_surplus.Total_summa", "Сумма к оплате");
            dgv_Service.Columns.Add("vw_Service_payment_and_surplus.Surplus_summa", "Размер перплаты");

        }

        private void ReadRow_Service(DataGridView dgw, IDataReader record)
        {
            dgw.Rows.Add(record.GetDouble(0), record.GetString(1), record.GetDouble(2), record.GetDateTime(3), record.GetDouble(4), record.GetDateTime(5), record.GetDouble(6), record.GetDouble(7));
        }

        private void RefreshDataGrid_Service(DataGridView dgw)
        {
            dataBase.openConnection();
            SqlConnection connection = dataBase.GetConnection();
            SqlCommand cmd = connection.CreateCommand();
            int id_ten = int.Parse(log_str); ///

            cmd.CommandText = $"SELECT id_Apartment FROM Tenant WHERE id_tenant = '{id_ten}'";

            int result = ((int)cmd.ExecuteScalar());

            //string query = $"SELECT Tenant.FIO, Type_meter.Name, Meter.id_meter, Apartment.Count_of_tenants, Apartment.Square, Apartment.Number_of_apartment, House.Name_house, Street.Name FROM Apartment INNER JOIN House ON Apartment.id_House = House.id_house INNER JOIN Street ON House.id_Street = Street.id_street INNER JOIN Meter ON Apartment.Number_of_apartment = Meter.id_Apartment_meter INNER JOIN Type_meter ON Meter.id_Type_Meter = Type_meter.id_type_meter INNER JOIN Tenant ON Apartment.id_apartment = Tenant.id_Apartment WHERE Tenant.id_tenant = '{log_str}'";

            string q_req = $"select [Square],[Name_type_service],[Rate],[Service_date],[Summa_of_payment],[Date_of_payment],[Total_summa],[Surplus_summa] from vw_vw_Service_payment_and_surplus where id_apartment = '{result}'";
            SqlCommand command = new SqlCommand(q_req, dataBase.GetConnection());

            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadRow_Service(dgw, reader);
            }
            reader.Close();
        }

        private void Readings_Load()
        {
            dataBase.openConnection();
            int id_ten = int.Parse(log_str); ///

            SqlConnection connection = dataBase.GetConnection();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT id_Apartment FROM Tenant WHERE id_tenant = '{id_ten}'";

            int result = ((int)cmd.ExecuteScalar());
            Data.id_Apartm = result;
            //search_textBox.Text = result.ToString();

            using (SqlCommand command = new SqlCommand("Get_Readings_for_Apartment", dataBase.GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@IDApar", SqlDbType.Int));
                command.Parameters["@IDApar"].Value = result;
                try
                {
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    BindingSource bs = new BindingSource();
                    bs.DataSource = table;

                    dgv_Readings_meter.DataSource = bs;
                }
                catch (Exception ex)
                {
                    string exstr = ex.ToString();
                    MessageBox.Show(exstr, "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dataBase.closeConnection();
        }

        private void update_pic_Click(object sender, EventArgs e)
        {
            Clean_TextBoxes();
            Readings_Load();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Add_Form addform = new Add_Form();
            addform.Show();
        }

        private void dgv_Readings_meter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Readings_meter.Rows[selectedRow];

                Meter_id_textBox_main.Text = row.Cells[0].Value.ToString();
                Data.meter_id = int.Parse(Meter_id_textBox_main.Text);

                Reading_textBox_main.Text = row.Cells[4].Value.ToString();
                Data.reading = double.Parse(Reading_textBox_main.Text);

                date_textBox_main.Text = row.Cells[5].Value.ToString();
                Data.last_date = DateTime.Parse(date_textBox_main.Text).Date;

                Total_sum_textBox_main.Text = row.Cells[9].Value.ToString();

            }
        }
        private void dgv_Service_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Service.Rows[selectedRow];
                Data.date_serv = DateTime.Parse(row.Cells[3].Value.ToString()).Date;

            }
        }
        private void add_ser_btn_Click(object sender, EventArgs e)
        {
            Add_payment addpayment = new Add_payment();
            addpayment.Show();
        }

        private void Clean_TextBoxes()
        {
            Meter_id_textBox_main.Text = "";

            Reading_textBox_main.Text = "";

            date_textBox_main.Text = "";

            Total_sum_textBox_main.Text = "";
            search_textBox.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateColumn();
            RefreshDataGrid(dgv_Meter_for_Tenant);

            Clean_TextBoxes();
            Readings_Load();

            CreateColumn_Service();
            RefreshDataGrid_Service(dgv_Service);

        }
        //----------------------------------------------------//
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search(DataGridView dgw)
        {
            dataBase.openConnection();
            //DataTable table = new DataTable();

            string searchstr = $"select	--m.id_Apartment_meter as Apartment, " +
                $"mr1.id_Meter as [Счетчик], tm.Name as [Тип счетчика], " +
                $"mr2.Reading as [Первое показание], mr2.Payment_date as [Дата первого показания], " +
                $"mr1.Reading as [Второе показание], mr1.Payment_date as [Дата второго показания], " +
                $"ROUND(mr1.Reading - mr2.Reading, 2) as [Разность], tm.Metric_units as [Ед.изм.], tm.Rate as [Тариф], " +
                $"ROUND(mr1.Reading - mr2.Reading, 2) * Rate as [Итоговая сумма]" +
                    $"from Meter_Readings as mr2" +
                $"join Meter_Readings as mr1 on mr1.id_Meter = mr2.id_Meter" +
                $"join Meter as m on m.id_meter = mr1.id_Meter" +
                $"join Type_meter as tm on tm.id_type_meter = m.id_Type_Meter" +
                    $"where mr1.id_meter_readings != mr2.id_meter_readings" +
                $"and datediff(day, mr2.Payment_date, mr1.Payment_date) > 20" +
               $" and datediff(day, mr2.Payment_date, mr1.Payment_date) < 40" +
                $"AND m.id_Apartment_meter = '{Data.id_Apartm}'" +
                $"AND Concat(mr1.id_Meter, tm.Name, mr2.Reading, mr2.Payment_date, mr1.Reading, mr1.Payment_date, ROUND(mr1.Reading - mr2.Reading, 2), tm.Metric_units, tm.Rate, ROUND(mr1.Reading - mr2.Reading, 2) * Rate) like '%'+'{search_textBox.Text}'+'%' ";
            using (SqlCommand com = new SqlCommand("Get_Search_Readings_for_Apartment", dataBase.GetConnection()))
            {
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter("@IDApar", SqlDbType.Int));
                com.Parameters["@IDApar"].Value = Data.id_Apartm;
                //SqlCommand command = new SqlCommand(searchstr, dataBase.GetConnection());
                com.Parameters.Add(new SqlParameter("@Searchstr", SqlDbType.NVarChar));
                com.Parameters["@Searchstr"].Value = search_textBox.Text;
                try
                {
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(com);
                    adapter.Fill(table);
                    BindingSource bs = new BindingSource();
                    bs.DataSource = table;

                    dgv_Readings_meter.DataSource = bs;
                }
                catch (Exception ex)
                {
                    string exstr = ex.ToString();
                    MessageBox.Show(exstr, "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            dataBase.closeConnection();
        }

        private void search_pic_Click(object sender, EventArgs e)
        {
            Clean_TextBoxes();

            Search(dgv_Readings_meter);
            if (search_textBox.Text.Equals(""))
            {
                Readings_Load();

            }

        }
    }
}
