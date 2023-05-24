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
    public partial class AdminForm : Form
    {
        DataBase db = new DataBase();
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter;
        SqlCommandBuilder sqlBuilder = null;
        string selectedState = "";
        bool newRowAdd = false;
        int selectedRow;

        public AdminForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = comboBox1.SelectedItem.ToString();
            db.openConnection();
            SqlConnection connection = db.GetConnection();
            
            try
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"SELECT * FROM {selectedState}";
                //cmd.CommandText = $"select * from INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'{selectedState}'";


                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                var sqlBuilder = new SqlCommandBuilder(adapter);
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetDeleteCommand();

                adapter.Fill(table);
                BindingSource bs = new BindingSource();
                bs.DataSource = table;

                dataGridView1.DataSource = bs;

                //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                //{
                //    DataGridViewLinkCell linkcell = new DataGridViewLinkCell();
                //    dataGridView1[dataGridView1.ColumnCount - 1, i] = linkcell;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }


        private void ReLoad()
        {

            dataSet = new DataSet();


            try
            {

                string selectedState = comboBox1.SelectedItem.ToString();
                db.openConnection();
                SqlConnection connection = db.GetConnection();
                //dataSet = new DataSet();
                //dataGridView1.DataSource = dataSet.Tables[selectedState];

                //dataSet.Tables[selectedState].Clear();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"SELECT * FROM {selectedState}";
                //cmd.CommandText = $"select * from INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'{selectedState}'";
                //DataTable table = new DataTable();
                adapter = new SqlDataAdapter(cmd);
                sqlBuilder = new SqlCommandBuilder(adapter);

                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetDeleteCommand();




                adapter.Fill(dataSet, selectedState);
                //BindingSource bs = new BindingSource();
                //bs.DataSource = table;

                //dataGridView1.DataSource = bs;
                dataGridView1.DataSource = dataSet.Tables[selectedState];

                //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                //{
                //    DataGridViewLinkCell linkcell = new DataGridViewLinkCell();
                //    dataGridView1[dataGridView1.ColumnCount - 1, i] = linkcell;
                //}
            }
            catch (Exception ex)
            {
                string exstr = ex.ToString();
                MessageBox.Show(ex.Message, "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }
    

        private void AdminForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] {"Street", "House", "Apartment", "Tenant", "Meter", "Meter_Readings", "Type_service", "Type_meter", "Service", "Service_Payment", "Meter_Payment"});
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                //Meter_id_textBox_main.Text = row.Cells[0].Value.ToString();
                //Data.meter_id = int.Parse(Meter_id_textBox_main.Text);

                //Reading_textBox_main.Text = row.Cells[4].Value.ToString();
                //Data.reading = double.Parse(Reading_textBox_main.Text);

                //date_textBox_main.Text = row.Cells[5].Value.ToString();
                //Data.last_date = DateTime.Parse(date_textBox_main.Text).Date;

                //Total_sum_textBox_main.Text = row.Cells[9].Value.ToString();

            }



        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            add_textbox.Text = "";


            string sql = $"SELECT * FROM {selectedState}";
            string connectionString;
            // DataTable сохраняет данные в памяти как таблицу
            DataTable dataTable = new DataTable();
            db.openConnection();
            SqlCommand sqlCommand = new SqlCommand(sql, db.GetConnection());
            //Создаем адаптер
            // DataAdapter - посредник между базой данных и DataSet
            adapter = new SqlDataAdapter(sqlCommand);

            //Создаем построитель команд
            //Для адаптера становится доступной команда Update
            SqlCommandBuilder commandBuilder =
              new SqlCommandBuilder(adapter);

            // Данные из адаптера поступают в DataTable
            adapter.Fill(dataTable);
            // Связываем данные с элементом DataGridView
            dataGridView1.DataSource = dataTable;

            try
            {
                UpdateStreet(dataTable);
                adapter.Update(dataTable);
                MessageBox.Show("Изменения в базе данных выполнены!",
                  "Уведомление о результатах", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Изменения в базе данных выполнить не удалось!",
                  "Уведомление о результатах", MessageBoxButtons.OK);
            }
            db.closeConnection();
            //ReLoad();

        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //try
            //{
            //    if (newRowAdd == false)
            //    {
            //        newRowAdd = true;
            //        int lastRow = dataGridView1.Rows.Count - 2;
            //        int col = dataGridView1.Rows.Count - 1;
            //        DataGridViewRow row = dataGridView1.Rows[lastRow];
            //        DataGridViewLinkCell linkcell = new DataGridViewLinkCell();
            //        dataGridView1[col, lastRow] = linkcell;
            //        row.Cells["Delete"].Value = "Update";
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    int col = dataGridView1.Rows.Count - 1;

            //    if (newRowAdd == false)
            //    {
            //        int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            //        DataGridViewRow edrow = dataGridView1.Rows[rowIndex];
            //        DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
            //        dataGridView1[col, rowIndex] = linkCell;
            //        edrow.Cells["Delete"].Value = "Insert";
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
        }

        private void add_pic_Click(object sender, EventArgs e)
        {
            string add_text = add_textbox.Text;
            string[] param = add_text.Split(';');


            db.openConnection();
            if (param.Length > 0)
            {
                try
                {

                    switch (selectedState)
                    {
                        case "Tenant":
                            int id_ten = int.Parse(param[0]);
                            int id_apar = int.Parse(param[1]);
                            string FIO = param[2];

                            var addquery = $"insert Tenant (id_tenant, id_Apartment, FIO) values ({id_ten}, {id_apar}, '{FIO}')";
                            var command = new SqlCommand(addquery, db.GetConnection());
                            command.ExecuteNonQuery();

                            MessageBox.Show("Запись успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            break;
                        case "Street":
                            string Name_Street = param[0];

                            addquery = $"insert Street (Name) values ('{Name_Street}')";
                            command = new SqlCommand(addquery, db.GetConnection());
                            command.ExecuteNonQuery();

                            MessageBox.Show("Запись успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case "House":
                            int id_street = int.Parse(param[0]);
                            int count_flats = int.Parse(param[2]);
                            string NumHouse = param[1];

                            addquery = $"insert House(id_Street, Name_house, Count_flats) values ('{id_street}', '{count_flats}', '{NumHouse}')";
                            command = new SqlCommand(addquery, db.GetConnection());
                            command.ExecuteNonQuery();

                            MessageBox.Show("Запись успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            break;
                        default:
                            break;

                    }
                }
                catch (Exception ex)
                {
                    string exstr = ex.ToString();
                    MessageBox.Show(exstr, "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Пустая строка или строка без разделителя ;", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            db.closeConnection();
        }

        private void info_pic_Click(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(info_pic, "Подсказка для TextBox");
          
            switch (selectedState)
            {

                case "Tenant":
                    t.SetToolTip(info_pic, "Вставка записи (id_tenant, id_Apartment, FIO): (24033033;2;Посталюк Павел Романович)");
                    break;
                case "Street":
                    t.SetToolTip(info_pic, "Вставка записи (Name): (Рабочая)");
                    break;
                case "House":
                    t.SetToolTip(info_pic, "Вставка записи (id_Street, Name_house, Count_flats): (302;12/3А;56)");
                    break;
                default:
                    t.SetToolTip(info_pic, "Подсказка");
                    break;

            }
            
        }

        public void UpdateStreet(DataTable table) //DAL represents 3-tyer architecture (so data access layer)
        {
            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=HOA;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = @"UPDATE Street SET " +
                              "Name = @name " +
                              "WHERE id_street = @oldId";
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 50, "Name");
                    SqlParameter param = cmd.Parameters.Add("@oldId", SqlDbType.Int, 5, "id_street");
                    param.SourceVersion = DataRowVersion.Original;
                    cmd.Connection = sqlConn;
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.UpdateCommand = cmd;
                        da.Update(table);
                    }

                    /*
                    using (SqlConnection sqlConn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=HOA;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = @"UPDATE Street SET " +
                              "StudentID = @id, " +
                              "FirstName = @first, " +
                              "Name = @name " +
                              "Birthday = @birthday, " +
                              "PersonalNo = @personal " +
                              "WHERE StudentID = @oldId";
                    cmd.Parameters.Add("@id", SqlDbType.Int, 5, "StudentID");
                    cmd.Parameters.Add("@first", SqlDbType.VarChar, 50, "FirstName");
                    cmd.Parameters.Add("@last", SqlDbType.VarChar, 50, "LastName");
                    cmd.Parameters.Add("@birthday", SqlDbType.DateTime, 1, "Birthday");
                    cmd.Parameters.Add("@personal", SqlDbType.VarChar, 50, "PersonalNo");
                    SqlParameter param = cmd.Parameters.Add("@oldId", SqlDbType.Int, 5, "StudentID");
                    param.SourceVersion = DataRowVersion.Original;
                    cmd.Connection = sqlConn;
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.UpdateCommand = cmd;
                        da.Update(table);
                    }
                    }
                     */
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                int id_del = int.Parse(row.Cells[0].Value.ToString());
                db.openConnection();
                var addquery = $"";

                try
                {

                    switch (selectedState)
                    {

                        case "Tenant":
                            addquery = $"delete from Tenant where id_tenant = '{id_del}'";
                            break;
                        case "Street":
                            addquery = $"delete from Street where id_street = '{id_del}'";

                            break;
                        case "House":
                            addquery = $"delete from House where id_house = '{id_del}'";

                            break;
                        default:

                            break;
                    }
                    var command = new SqlCommand(addquery, db.GetConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно удалена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.closeConnection();
                }
                catch(Exception ex)
                {
                    string exstr = ex.ToString();
                    MessageBox.Show(exstr, "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Search()
        {
            db.openConnection();
            switch (selectedState)
            {
                case "Tenant":

                    //Concat(mr1.id_Meter, tm.Name, mr2.Reading, mr2.Payment_date, mr1.Reading, mr1.Payment_date, ROUND(mr1.Reading - mr2.Reading, 2), tm.Metric_units, tm.Rate, ROUND(mr1.Reading - mr2.Reading, 2) * Rate) like '%' + '{search_textBox.Text}' + '%'
                    var addquery = $"select * from Tenant where concat(id_tenant, id_Apartment, FIO) like '%' + '{search_textbox.Text}' + '%'";
                    var command = new SqlCommand(addquery, db.GetConnection());
                    command.ExecuteNonQuery();

                    //MessageBox.Show("Запись успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dataTable = new DataTable();
                    db.openConnection();
                    SqlCommand sqlCommand = new SqlCommand(addquery, db.GetConnection());
                    //Создаем адаптер
                    // DataAdapter - посредник между базой данных и DataSet
                    adapter = new SqlDataAdapter(sqlCommand);

                    //Создаем построитель команд
                    //Для адаптера становится доступной команда Update
                    SqlCommandBuilder commandBuilder =
                      new SqlCommandBuilder(adapter);

                    // Данные из адаптера поступают в DataTable
                    adapter.Fill(dataTable);
                    // Связываем данные с элементом DataGridView
                    dataGridView1.DataSource = dataTable;
                    break;
                case "Street":
                    //string Name_Street = param[0];

                    addquery = $"select * from Street where Name like '%' + '{search_textbox.Text}' + '%'";
                    command = new SqlCommand(addquery, db.GetConnection());
                    command.ExecuteNonQuery();
                    dataTable = new DataTable();
                    db.openConnection();
                    sqlCommand = new SqlCommand(addquery, db.GetConnection());
                    //Создаем адаптер
                    // DataAdapter - посредник между базой данных и DataSet
                    adapter = new SqlDataAdapter(sqlCommand);

                    //Создаем построитель команд
                    //Для адаптера становится доступной команда Update
                    commandBuilder =
                      new SqlCommandBuilder(adapter);

                    // Данные из адаптера поступают в DataTable
                    adapter.Fill(dataTable);
                    // Связываем данные с элементом DataGridView
                    dataGridView1.DataSource = dataTable;
                    //MessageBox.Show("Запись успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                //case "House":
                //    int id_street = int.Parse(param[0]);
                //    int count_flats = int.Parse(param[2]);
                //    string NumHouse = param[1];

                //    addquery = $"insert House(id_Street, Name_house, Count_flats) values ('{id_street}', '{count_flats}', '{NumHouse}')";
                //    command = new SqlCommand(addquery, db.GetConnection());
                //    command.ExecuteNonQuery();

                //    MessageBox.Show("Запись успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    break;
                default:
                    break;

            }
            db.closeConnection();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
