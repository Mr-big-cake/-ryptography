using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BankAppU
{
    public partial class Form1 : Form
    {

        FormRegistration formRegistration;
        public Form1()
        {
            InitializeComponent();
            formRegistration = new FormRegistration();
        }

        private void closeButton_MouseMove(object sender, MouseEventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(255, 0, 0, 0);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(255, 255, 255, 255);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entrance_MouseLeave(object sender, EventArgs e)
        {
            entrance.ForeColor = Color.FromArgb(255, 184, 134, 11);
        }

        private void entrance_MouseMove(object sender, MouseEventArgs e)
        {
            entrance.ForeColor = Color.FromArgb(255, 0, 0, 0);
        }

        private void registration_MouseLeave(object sender, EventArgs e)
        {
            registration.ForeColor = Color.FromArgb(255, 184, 134, 11);
        }

        private void registration_MouseMove(object sender, MouseEventArgs e)
        {
            registration.ForeColor = Color.FromArgb(255, 0, 0, 0);
        }

        private void registration_Click(object sender, EventArgs e)
        {
            try
            {
                formRegistration.ShowDialog();
            }
            catch
            {
                labelError.Text = "Ошибка подключения к серверу!";
            }
        }

        Point lastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                formRegistration.Left += e.X - lastPoint.X;
                formRegistration.Top += e.Y - lastPoint.Y;

            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        string connectionString = "server=DESKTOP-QGUHKNA;Trusted_Connection=Yes;DataBase=BankApp;";

        private void entrance_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sqlCheakNameProcedure = "UserAppLog";

                    SqlCommand command = new SqlCommand(sqlCheakNameProcedure, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter login = new SqlParameter
                    {
                        ParameterName = "@Login",
                        Value = loginTextBox.Text
                    };
                    SqlParameter password = new SqlParameter
                    {
                        ParameterName = "@Password",
                        Value = ((3 * passwordTextBox.Text.GetHashCode()) % 10000).ToString()
                    };
                    SqlParameter count = new SqlParameter
                    {
                        ParameterName = "@count",
                        SqlDbType = SqlDbType.Int
                    }; count.Direction = ParameterDirection.Output;

                    command.Parameters.Add(login);
                    command.Parameters.Add(password);
                    command.Parameters.Add(count);

                    command.ExecuteNonQuery();

                    if ((int)command.Parameters["@count"].Value != 0)
                    {
                        labelError.Text = "";
                        ClientForm clientForm = new ClientForm(loginTextBox.Text);
                        clientForm.ShowDialog();
                    }
                    else labelError.Text = "Неверный логин или пароль";
                }
                catch(System.Data.SqlClient.SqlException)
                {
                    labelError.Text = "Ошибка подключения к серверу!";
                }
            }

        }

        private void loginTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                passwordTextBox.Focus();
            }

        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                entrance_Click(null, null);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                { 
                    connection.Open();
                    string sqlCheakNameProcedure = "AdminAppLog";

                    SqlCommand command = new SqlCommand(sqlCheakNameProcedure, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter login = new SqlParameter
                    {
                        ParameterName = "@Login",
                        Value = loginTextBox.Text
                    };
                    SqlParameter password = new SqlParameter
                    {
                        ParameterName = "@Password",
                        Value = ((3 * passwordTextBox.Text.GetHashCode()) % 10000).ToString()
                    };
                    SqlParameter count = new SqlParameter
                    {
                        ParameterName = "@count",
                        SqlDbType = SqlDbType.Int
                    }; count.Direction = ParameterDirection.Output;

                    command.Parameters.Add(login);
                    command.Parameters.Add(password);
                    command.Parameters.Add(count);

                    command.ExecuteNonQuery();

                    if ((int)command.Parameters["@count"].Value != 0)
                    {
                        labelError.Text = "";
                        AdminForm adminForm = new AdminForm(loginTextBox.Text);
                        adminForm.ShowDialog();
                    }
                    else labelError.Text = "Неверный логин или пароль";
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    labelError.Text = "Ошибка подключения к серверу!";
                }
            }
        }
    }
}
