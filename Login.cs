using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

//24091403
// 24012036

namespace dbHOA
{
    public partial class Login : Form
    {
        DataBase dataBase = new DataBase();
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            password_box.PasswordChar = '*';
            login_box.MaxLength = 50;
            password_box.MaxLength = 50;
        }


        private void log_in_btn_Click_1(object sender, EventArgs e)
        {
            var loginUser = login_box.Text;
            var passUser = password_box.Text;
            Data.login_str = login_box.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable Registration = new DataTable();

            string query_reg = $"select login_user, password_user from registration where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand req_com = new SqlCommand(query_reg, dataBase.GetConnection());

            adapter.SelectCommand = req_com;
            adapter.Fill(Registration);

            if (Registration.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
                if (loginUser == "admin" && passUser == "admin891272")
                {
                    AdminForm admform = new AdminForm();
                    this.Hide();
                    admform.ShowDialog();
                    this.Show();
                }
                else
                {
                    MainForm mform = new MainForm();
                    this.Hide();
                    mform.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Вас нет в базе данных", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
