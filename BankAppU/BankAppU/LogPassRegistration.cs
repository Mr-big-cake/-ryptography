using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppU
{
    public partial class LogPassRegistration : Form
    {
        public LogPassRegistration()
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //try
                //{
                connection.Open();
                string sqlCheakNameProcedure = "AdminAppProcCountString";

                SqlCommand command = new SqlCommand(sqlCheakNameProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter count = new SqlParameter
                {
                    ParameterName = "@count",
                    SqlDbType = SqlDbType.Int
                };count.Direction = ParameterDirection.Output;

                command.Parameters.Add(count);

                command.ExecuteNonQuery();

                if ((int)command.Parameters["@count"].Value == 0)
                {
                    isAdminCheckBox.Visible = true;
                }

            }
        }

        #region ButtonNumericTextbox
        private void CloseButtonFormRegistration_MouseMove(object sender, MouseEventArgs e)
        {
            CloseButtonFormRegistration.ForeColor = Color.FromArgb(255, 0, 0, 0);
        }
        private void CloseButtonFormRegistration_MouseLeave(object sender, EventArgs e)
        {
            CloseButtonFormRegistration.ForeColor = Color.FromArgb(255, 255, 250, 205);
        }

        private void ContinueButtonFormRegistration_MouseMove(object sender, MouseEventArgs e)
        {
            ContinueButtonFormRegistration.ForeColor = Color.FromArgb(255, 0, 0, 0);
        }

        private void ContinueButtonFormRegistration_MouseLeave(object sender, EventArgs e)
        {
            ContinueButtonFormRegistration.ForeColor = Color.FromArgb(255, 255, 250, 205);
        }

        private void CloseButtonFormRegistration_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                if (TbLogin.TextLength == 0)
                {
                    TbLogin.Text = "";
                    TbLogin.Focus();
                    labelError.Text = "Логин - обязательное поле";
                }
                else TbPassword.Focus();
            }
        }

        private void TbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((e.KeyChar < 'A' || e.KeyChar > 'z') && !Char.IsDigit(e.KeyChar)) || TbLogin.TextLength >= 20
                )
    && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
                return;
            }
            else if (labelError.Text.Length != 0) labelError.Text = "";

            if (TbLogin.TextLength > 0)
            {
                lab1.Text = "";
            }
            else
            {

                lab1.Text = "*";
            }
        }

        private void TbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                if (TbPassword.TextLength == 0)
                {
                    TbPassword.Text = "";
                    TbPassword.Focus();
                    labelError.Text = "Придумайте пароль";
                }
                else if(TbPassword.TextLength < 4)
                {
                    TbPassword.Text = "";
                    TbPassword.Focus();
                    labelError.Text = "Пароль - 4 и более символов";
                }
                else TbRepeat.Focus();
            }
            else if (e.KeyCode == Keys.Up || (e.KeyCode == Keys.Back && TbPassword.TextLength == 0))
             {
                TbLogin.Focus();
            }
        }

        private void TbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((e.KeyChar < 'A' || e.KeyChar > 'z') && !Char.IsDigit(e.KeyChar)) || TbPassword.TextLength >= 10 )
   && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
                return;
            }
            else if (labelError.Text.Length != 0) labelError.Text = "";

            if (TbPassword.TextLength > 0)
            {
                lab2.Text = "";
            }
            else
            {

                lab2.Text = "*";
            }
        }

        private void TbRepeat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                if (TbPassword.TextLength == 0)
                {
                    TbPassword.Text = "";
                    TbPassword.Focus();
                    labelError.Text = "Повторите пароль";
                }
                else if (TbPassword.Text != TbRepeat.Text)
                {
                    TbRepeat.Text = "";
                    TbRepeat.Focus();
                    labelError.Text = "Пароли не совпадают";
                }
                else TbEmail.Focus();
            }
            else if (e.KeyCode == Keys.Up || (e.KeyCode == Keys.Back && TbRepeat.TextLength == 0))
            {
                TbPassword.Focus();
            }
        }

        private void TbRepeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((e.KeyChar < 'A' || e.KeyChar > 'z') && !Char.IsDigit(e.KeyChar)) || TbRepeat.TextLength >= 10)
  && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
                return;
            }
            else if (labelError.Text.Length != 0) labelError.Text = "";
            if (TbRepeat.TextLength > 0)
            {
                lab3.Text = "";
            }
            else
            {

                lab3.Text = "*";
            }
        }
        private void TbEmail_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                TbMNumber.Focus();
            }
            else if (e.KeyCode == Keys.Up || (e.KeyCode == Keys.Back && TbEmail.TextLength == 0))
            {
                TbRepeat.Focus();
            }

        }

        private void TbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TbMNumber.Text.Length >= 10 )
            {
                e.Handled = true;
                return;
            }
            if (!Regex.IsMatch(TbEmail.Text,
                 @"^.+@.+\..+$"))
            {
                labelError.Text = "Некорртектный email";
            }
            else labelError.Text = "";

        }
        private void TbMNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                ContinueButtonFormRegistration.Focus();
            }
            else if (e.KeyCode == Keys.Up || (e.KeyCode == Keys.Back && TbEmail.TextLength == 0))
            {
                TbEmail.Focus();
            }
        }

        private void TbMNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((TbMNumber.Text.Length >= 10 || !Char.IsDigit(e.KeyChar))
                 && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
                return;
            }
            else if (!Regex.IsMatch(TbMNumber.Text, @"((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$")){
                labelError.Text = "Некорректный номер ";
            }
            else labelError.Text = "";


        }

        #endregion

        public FormRegistration parent;
        public static string connectionString = "server=DESKTOP-QGUHKNA;Trusted_Connection=Yes;DataBase=BankApp;";

        private void ContinueButtonFormRegistration_Click(object sender, EventArgs e)
        {
            if(TbLogin.TextLength == 0)
            {
                labelError.Text = "Не указан логин";
                lab1.Text = "*";
                return;
            }
            else if (TbPassword.TextLength == 0)
            {
                labelError.Text = "Не указан пароль";
                lab2.Text = "*";
                return;
            }
            else if (TbPassword.TextLength < 4)
            {
                labelError.Text = "Пароль меньше 4 знаков";
                lab2.Text = "*";
                return;
            }
            else if (TbRepeat.Text != TbPassword.Text)
            {
                labelError.Text = "Пароли не совпадают";
                lab3.Text = "*";
                return;
            }
            else if(TbEmail.TextLength != 0 && !Regex.IsMatch(TbEmail.Text,
                 @"^.+@.+\..+$"))
            {
                labelError.Text = "Неккоректная почта";
                return;
            }
            else if(TbMNumber.TextLength != 0 
                && !Regex.IsMatch(TbMNumber.Text, @"((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$"))
            {
                labelError.Text = "Неккоректный номер";
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlCheakNameProcedure = "UserAppProcCheck";

                SqlCommand command = new SqlCommand(sqlCheakNameProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                
                SqlParameter login = new SqlParameter
                {
                    ParameterName = "@checkLogin",
                    Value = TbLogin.Text
                };

                SqlParameter countStr = new SqlParameter
                {
                    ParameterName = "@count",
                    SqlDbType = SqlDbType.Int
                }; countStr.Direction = ParameterDirection.Output;

                command.Parameters.Add(login);
                command.Parameters.Add(countStr);
                command.ExecuteNonQuery();

                //labelError.Text = command.Parameters["@count"].Value.ToString();

                if ((int)command.Parameters["@count"].Value == 0)
                {
                   // try
                   // {
                        labelError.Text = "Верно";
                        parent.RegistrationPasportDataInsert();
                        RegistrationUserAppSqlInsert();
                        this.Close();
                        parent.Close();
                   //}
                  // catch {
                  //     labelError.Text = "НЕ Верно";
                   // }
                }
                else
                {
                    labelError.Text = "Аккаунт существует";
                    return;
                }


            }
        }

        public void RegistrationUserAppSqlInsert()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlCheakNameProcedure = "UserAppProcInsert";

                SqlCommand command = new SqlCommand(sqlCheakNameProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter login = new SqlParameter
                {
                    ParameterName = "@Login",
                    Value = TbLogin.Text
                };

                SqlParameter password = new SqlParameter
                {
                    ParameterName = "@Password",
                    Value = ((3 * TbPassword.Text.GetHashCode() )% 10000).ToString()
                };

                SqlParameter seriesNumber = new SqlParameter
                {
                    ParameterName = "@SeriesNumber",
                    Value = parent.TbSries.Text + parent.TbNumber.Text
                };

                SqlParameter mobileNumber = new SqlParameter(), email = new SqlParameter();
                if (TbMNumber.TextLength == 0 || TbMNumber.Text == "")
                {
                    mobileNumber = new SqlParameter
                    {
                        ParameterName = "@MobileNumber",
                        Value = DBNull.Value
                    };
                    command.Parameters.Add(mobileNumber);
                }
                else
                {
                    try
                    {
                        mobileNumber = new SqlParameter
                        {
                            ParameterName = "@MobileNumber",
                            Value = TbMNumber.Text

                        };
                        command.Parameters.Add(mobileNumber);
                    }
                    catch
                    {
                        labelError.Text = "Номер занят";
                    }
                }
                if (TbEmail.TextLength == 0 || TbEmail.Text == "")
                {
                    email = new SqlParameter
                    {
                        ParameterName = "@Email",
                        Value = DBNull.Value
                    };
                    command.Parameters.Add(email);
                }
                else
                {
                    try
                    {
                        email = new SqlParameter
                        {
                            ParameterName = "@Email",
                            Value = TbEmail.Text
                        };
                        command.Parameters.Add(email);
                    }
                    catch
                    {
                        labelError.Text = "Почта занята";
                    }
                }

                command.Parameters.Add(login);
                command.Parameters.Add(password);
                command.Parameters.Add(seriesNumber);


                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    labelError.Text = "Ошбика! Аккаунт уже существует";
                }

                if(isAdminCheckBox.Checked == true)
                {
                    sqlCheakNameProcedure = "AdminAppProcInsert";

                    command = new SqlCommand(sqlCheakNameProcedure, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    var lvl = new SqlParameter
                    {
                        ParameterName = "@Lvl",
                        Value = 3
                    };command.Parameters.Add(lvl);

                    login = new SqlParameter
                    {
                        ParameterName = "@Login",
                        Value = TbLogin.Text
                    };

                    password = new SqlParameter
                    {
                        ParameterName = "@Password",
                        Value = ((3 * TbPassword.Text.GetHashCode()) % 10000).ToString()
                    };

                    seriesNumber = new SqlParameter
                    {
                        ParameterName = "@SeriesNumber",
                        Value = parent.TbSries.Text + parent.TbNumber.Text
                    };

                    mobileNumber = new SqlParameter(); email = new SqlParameter();
                    if (TbMNumber.TextLength == 0 || TbMNumber.Text == "")
                    {
                        mobileNumber = new SqlParameter
                        {
                            ParameterName = "@MobileNumber",
                            Value = DBNull.Value
                        };
                        command.Parameters.Add(mobileNumber);
                    }
                    else
                    {
                        try
                        {
                            mobileNumber = new SqlParameter
                            {
                                ParameterName = "@MobileNumber",
                                Value = TbMNumber.Text

                            };
                            command.Parameters.Add(mobileNumber);
                        }
                        catch
                        {
                            labelError.Text = "Номер занят";
                        }
                    }
                    if (TbEmail.TextLength == 0 || TbEmail.Text == "")
                    {
                        email = new SqlParameter
                        {
                            ParameterName = "@Email",
                            Value = DBNull.Value
                        };
                        command.Parameters.Add(email);
                    }
                    else
                    {
                        try
                        {
                            email = new SqlParameter
                            {
                                ParameterName = "@Email",
                                Value = TbEmail.Text
                            };
                            command.Parameters.Add(email);
                        }
                        catch
                        {
                            labelError.Text = "Почта занята";
                        }
                    }
                    command.Parameters.Add(login);
                    command.Parameters.Add(password);
                    command.Parameters.Add(seriesNumber);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        labelError.Text = "Ошбика! Аккаунт уже существует";
                    }
                }
            }
        }
    }
}
