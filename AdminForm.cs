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
        SqlDataAdapter adapter = null;
        SqlCommandBuilder sqlBuilder = null;
        string selectedState = "Tenant";
        bool newRowAdd = false;

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
                cmd.CommandText = $"SELECT *, 'Delete' as [Delete] FROM {selectedState}";
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

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkcell = new DataGridViewLinkCell();
                    dataGridView1[dataGridView1.ColumnCount - 1, i] = linkcell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }


        private void ReLoad()
        {
           


            try
            {

                string selectedState = comboBox1.SelectedItem.ToString();
                db.openConnection();
                SqlConnection connection = db.GetConnection();
                //dataSet = new DataSet();
                //dataGridView1.DataSource = dataSet.Tables[selectedState];

                //dataSet.Tables[selectedState].Clear();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"SELECT *, 'Delete' as [Delete] FROM {selectedState}";
                //cmd.CommandText = $"select * from INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'{selectedState}'";
                //DataTable table = new DataTable();
                adapter = new SqlDataAdapter(cmd);
                sqlBuilder = new SqlCommandBuilder(adapter);

                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();



                adapter.Fill(dataSet, selectedState);
                //BindingSource bs = new BindingSource();
                //bs.DataSource = table;

                //dataGridView1.DataSource = bs;
                dataGridView1.DataSource = dataSet.Tables[selectedState];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkcell = new DataGridViewLinkCell();
                    dataGridView1[dataGridView1.ColumnCount - 1, i] = linkcell;
                }
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
            comboBox1.Items.AddRange(new string[] {"Street", "House", "Apartment", "Tenant", "Meter", "Meter_Readings", "registration", "Type_service", "Type_meter", "Service", "Service_Payment", "Meter_Payment"});
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = dataGridView1.Rows.Count - 1; ////
            try
            {
                if (e.ColumnIndex == col)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[col].Value.ToString();
                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dataGridView1.Rows.RemoveAt(rowIndex);
                            dataSet.Tables[selectedState].Rows[rowIndex].Delete();
                            adapter.Update(dataSet, selectedState);
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView1.Rows.Count - 2;
                        DataRow row = dataSet.Tables[selectedState].NewRow();
                        //DataRow row = dataSet.Tables[selectedState].Rows[rowIndex];
                        for (int i = 1; i < col; i++)
                        {
                            row[i] = dataGridView1.Rows[rowIndex].Cells[i].Value;
                        }


                        dataSet.Tables[selectedState].Rows.Add(row);
                        dataSet.Tables[selectedState].Rows.RemoveAt(dataSet.Tables[selectedState].Rows.Count - 1); ;

                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);
                        dataGridView1.Rows[e.RowIndex].Cells[col].Value = "Delete";
                        adapter.Update(dataSet, selectedState);
                        newRowAdd = false;


                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;
                        for (int i = 0; i < col; i++)
                        {
                            dataSet.Tables[selectedState].Rows[r][i] = dataGridView1.Rows[r].Cells[i].Value;
                        }
                        adapter.Update(dataSet, selectedState);
                        dataGridView1.Rows[r].Cells[col].Value = "Delete";
                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            ReLoad();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdd == false)
                {
                    newRowAdd = true;
                    int lastRow = dataGridView1.Rows.Count - 2;
                    int col = dataGridView1.Rows.Count - 1;
                    DataGridViewRow row = dataGridView1.Rows[lastRow];
                    DataGridViewLinkCell linkcell = new DataGridViewLinkCell();
                    dataGridView1[col, lastRow] = linkcell;
                    row.Cells["Delete"].Value = "Update";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int col = dataGridView1.Rows.Count - 1;

                if (newRowAdd == false)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow edrow = dataGridView1.Rows[rowIndex];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[col, rowIndex] = linkCell;
                    edrow.Cells["Delete"].Value = "Insert";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }
    }
}
