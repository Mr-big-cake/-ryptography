using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppU
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void CloseButtonFormRegistration_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region ButtonAndTextBoxAndNumericUpDown
        private void CloseButtonFormRegistration_MouseLeave(object sender, EventArgs e)
        {
            CloseButtonFormRegistration.ForeColor = Color.FromArgb(255, 255, 250, 205);
        }

        private void CloseButtonFormRegistration_MouseMove(object sender, MouseEventArgs e)
        {
            CloseButtonFormRegistration.ForeColor = Color.FromArgb(255, 0, 0, 0);
        }

        private void ContinueButtonFormRegistration_MouseLeave(object sender, EventArgs e)
        {
            ContinueButtonFormRegistration.ForeColor = Color.FromArgb(255, 255, 250, 205);
        }

        private void ContinueButtonFormRegistration_MouseMove(object sender, MouseEventArgs e)
        {
            ContinueButtonFormRegistration.ForeColor = Color.FromArgb(255, 0, 0, 0);
        }

        private void TbSries_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar) || TbSries.TextLength >= 4) &&
                e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
                return;
            } else if (labelError.Text.Length != 0) labelError.Text = "";

            if (TbSries.TextLength == 3)
            {
                lab1.Text = "";
            }
            else
            {
                
                lab1.Text = "*";
            }
        }

        private void TbSries_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                if (TbSries.TextLength != 4)
                {
                    TbSries.Text = "";
                    TbSries.Focus();
                    labelError.Text = "Серия паспорта - 4 цифры ";
                }
                else TbNumber.Focus();
            }
        }



        private void TbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar) || TbNumber.TextLength >= 6) &&
               e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
                return;
            }
            else if (labelError.Text.Length != 0) labelError.Text = "";

            if (TbNumber.TextLength == 5)
            {
                lab2.Text = "";
            }
            else
            {

                lab2.Text = "*";
            }
        }

        private void TbNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                if (TbNumber.TextLength != 6)
                {
                    TbNumber.Text = "";
                    TbNumber.Focus();
                    labelError.Text = "Номер паспорта - 6 цифр ";
                }
                else TbName.Focus();
            } else if(e.KeyCode == Keys.Up || (e.KeyCode == Keys.Back && TbNumber.TextLength == 0))
            {
                TbSries.Focus();
            }
        }

        private void TbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsLetter(e.KeyChar) || TbName.TextLength >= 50 || e.KeyChar < 'А' || e.KeyChar > 'я')
                && (e.KeyChar != '-' || (TbName.TextLength == 0 || TbName.Text.Contains('-')))
                && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;

            }
            else
            {
                if (labelError.Text.Length != 0) labelError.Text = "";

                if (TbName.Text.Equals(""))
                {
                    lab3.Text = "*";
                }
                else
                {
                    lab3.Text = "";
                }
            }
        }

        private void TbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                if (TbName.TextLength == 0 || TbName.Text.Last() == '-')
                {
                    TbName.Text = "";
                    TbName.Focus();
                    labelError.Text = "Некорректоне имя";
                    lab3.Text = "*";
                }
                else TbSurname.Focus();
            }
            else if (e.KeyCode == Keys.Up || (e.KeyCode == Keys.Back && TbName.TextLength == 0))
            {
                TbNumber.Focus();
            }


        }
        private void TbSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsLetter(e.KeyChar) || TbSurname.TextLength >= 50 || e.KeyChar < 'А' || e.KeyChar > 'я')
               && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete )
            {
                e.Handled = true;
                return;
            }
            else if (labelError.Text.Length != 0) labelError.Text = "";

            if (TbSurname.TextLength != 0)
            {
                lab4.Text = "";
            }
            else
            {

                lab4.Text = "*";
            }
        }

        private void TbSurname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                if (TbSurname.TextLength == 0)
                {
                    TbSurname.Text = "";
                    TbSurname.Focus();
                    labelError.Text = "Фамилия - обязательное поле";
                }
                else TbPatronymic.Focus();
            }
            else if (e.KeyCode == Keys.Up || (e.KeyCode == Keys.Back && TbSurname.TextLength == 0))
            {
                TbName.Focus();
            }
        }

        private void TbPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsLetter(e.KeyChar) || TbPatronymic.TextLength >= 50 || e.KeyChar < 'А' || e.KeyChar > 'я')
               && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
            else if (labelError.Text.Length != 0) labelError.Text = "";
        }

        private void TbPatronymic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                TbPlaceOfBirth.Focus();
            }
            else if (e.KeyCode == Keys.Up || (e.KeyCode == Keys.Back && TbPatronymic.TextLength == 0))
            {
                TbSurname.Focus();
            }
        }

        private void TbPlaceOfBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsLetter(e.KeyChar) || TbPlaceOfBirth.TextLength >= 50 || e.KeyChar < 'А' || e.KeyChar > 'я')
              && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
                return;
            }
            else if (labelError.Text.Length != 0) labelError.Text = "";

            if (TbPlaceOfBirth.TextLength > 0)
            {
                lab5.Text = "";
            }
            else
            {

                lab5.Text = "*";
            }
        }

        private void TbPlaceOfBirth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                if (TbPlaceOfBirth.TextLength == 0)
                {
                    TbPlaceOfBirth.Text = "";
                    TbPlaceOfBirth.Focus();
                    labelError.Text = "Укажите место рождения";
                }
                else numYear.Focus();
            }
            else if (e.KeyCode == Keys.Up || (e.KeyCode == Keys.Back && TbPlaceOfBirth.TextLength == 0))
            {
                TbPatronymic.Focus();
            }
        }

        private void numYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                numMonth.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                TbPlaceOfBirth.Focus();
            }
        }

        private void numMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                numNumber.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                numYear.Focus();
            }
        }

        DateTime dateTime;
        private void numNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                ContinueButtonFormRegistration.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                numMonth.Focus();
            }
        }
        #endregion

        public static string connectionString = "server=DESKTOP-QGUHKNA;Trusted_Connection=Yes;DataBase=BankApp;";

        private void ContinueButtonFormRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                dateTime = new DateTime((int)numYear.Value, (int)numMonth.Value, (int)numNumber.Value);
                if (lab1.Text.Length + lab2.Text.Length + lab3.Text.Length + lab4.Text.Length + lab5.Text.Length != 0)
                {
                    labelError.Text = "Обязательные поля не заполнены";
                    return;
                }
                else if (TbSries.Text.Length != 4)
                {
                    TbSries.Text = "";
                    labelError.Text = "Серия - обязательное поле";
                    lab1.Text = "*";
                    return;
                }
                else if (TbNumber.Text.Length != 6)
                {
                    TbNumber.Text = "";
                    labelError.Text = "Номер - обязательное поле";
                    lab2.Text = "*";
                    return;
                }
                else if (TbName.Text.Length == 0)
                {
                    TbName.Text = "";
                    labelError.Text = "Имя - обязательное поле";
                    lab3.Text = "*";
                    return;
                }
                else if (TbSurname.Text.Length == 0)
                {
                    TbSurname.Text = "";
                    labelError.Text = "Фамилия - обязательное поле";
                    lab4.Text = "*";
                    return;
                }
                else if (TbPlaceOfBirth.Text.Length == 0)
                {
                    TbPlaceOfBirth.Text = "";
                    labelError.Text = "Укажите место рождения";
                    lab5.Text = "*";
                    return;
                }
                if (labelError.Text.Length != 0) labelError.Text = "";
            }
            catch (ArgumentOutOfRangeException)
            {
                numNumber.Value = 1;
                labelError.Text = "Некорректная дата";
                return;
            }


            //SQL проверка на наличие серии и номера

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlCheakNameProcedure = "PasportDataProcCheck";

                SqlCommand command = new SqlCommand(sqlCheakNameProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter seriesNumber = new SqlParameter
                {
                    ParameterName = "@checkNum",
                    Value = TbSries.Text + TbNumber.Text
                };
                
                

                SqlParameter countStr = new SqlParameter
                {
                    ParameterName = "@count",
                    SqlDbType = SqlDbType.Int
                }; countStr.Direction = ParameterDirection.Output;

                command.Parameters.Add(seriesNumber);
                command.Parameters.Add(countStr);
                command.ExecuteNonQuery();

                if ((int)command.Parameters["@count"].Value == 0)
                {
                    LogPassRegistration logPassRegistration = new LogPassRegistration();
                    logPassRegistration.parent = this;
                    logPassRegistration.ShowDialog();
                }
                else labelError.Text = "Аккаунт существует";

                
            }

        }


        public void RegistrationPasportDataInsert()
        {
            StringBuilder dateSQL = new StringBuilder(numYear.Value.ToString());
            if (numMonth.Value < 10) dateSQL.Append('0');
            dateSQL.Append(numMonth.Value.ToString());
            if (numNumber.Value < 10) dateSQL.Append('0');
            dateSQL.Append(numNumber.Value.ToString());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlCheakNameProcedure = "PasportDataProcInsert";

                SqlCommand command = new SqlCommand(sqlCheakNameProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter seriesNumber = new SqlParameter
                {
                    ParameterName = "@SeriesNumber",
                    Value = TbSries.Text + TbNumber.Text
                };

                SqlParameter name = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = TbName.Text
                };

                SqlParameter surname = new SqlParameter
                {
                    ParameterName = "@Surname",
                    Value = TbSurname.Text
                };

                SqlParameter patronymic = new SqlParameter
                {
                    ParameterName = "@Patronymic",
                    Value = TbPatronymic.Text
                };

                SqlParameter dateOfBirth = new SqlParameter
                {
                    ParameterName = "@DateOfBirth",
                    Value = dateSQL.ToString()
                };

                SqlParameter placeOfBirth = new SqlParameter
                {
                    ParameterName = "@PlaceOfBirth",
                    Value = TbPlaceOfBirth.Text
                };


                command.Parameters.Add(seriesNumber);
                command.Parameters.Add(name);
                command.Parameters.Add(surname);
                command.Parameters.Add(patronymic);
                command.Parameters.Add(dateOfBirth);
                command.Parameters.Add(placeOfBirth);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    labelError.Text = "Ошибка подключения к серверу!";
                }
                //labelError.Text = command.Parameters["@count"].Value.ToString();


            }

        }
    } 

    
}
