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
    public partial class AdminForm : Form
    {
        const string connectionString = "server=DESKTOP-QGUHKNA;Trusted_Connection=Yes;DataBase=BankApp;";

        private int _account;
        private string _login;
        private string _password;
        private string _mobileNumber;
        private string _email;
        private int _lvl;

        class Card
        {
            public string CardNumber;
            public string ValidityCard;
            public string Money;
            public static List<string> allStringRecipient = new List<string>();
            public static List<Card> allRecipient = new List<Card>();

            public string _name;
            public string _surname;
            public string _patronymic;
            public int _account;

            public Card(string cardNumber, string name, string surname,
                string patronymic, int account, string validityCard, string money)
            {
                CardNumber = cardNumber;
                _name = name;
                _surname = surname;
                _patronymic = patronymic;
                _account = account;
                ValidityCard = validityCard;
                Money = money;
                allRecipient.Add(this);
                allStringRecipient.Add(cardNumber);

            }

        }

        public AdminForm()
        {
            InitializeComponent();
        }
        public AdminForm(string login)
        {
            InitializeComponent();
            _login = login;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlProcedure = "AdminAppProcClientDesigner";
                SqlCommand command = new SqlCommand(sqlProcedure, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlLogin = new SqlParameter
                {
                    ParameterName = "@login",
                    Value = login
                }; command.Parameters.Add(sqlLogin);

                try
                {
                    var reader = command.ExecuteReader();

                    if (!reader.Read()) { label1.Text = ":("; return; }
                    else
                    {
                        _account = reader.GetInt32(0);
                        _lvl = reader.GetInt32(1);
                        _login = reader.GetString(2);
                        _password = reader.GetString(3);
                        if (!reader.IsDBNull(5)) _mobileNumber = reader.GetString(5);
                        else _mobileNumber = "";
                        if (!reader.IsDBNull(6)) _email = reader.GetString(6);
                        else _email = "";



                    }
                    reader.Close();
                    label1.Text = "Меню администратора " + _lvl.ToString() + " Уровня";
                    if (_lvl < 3)
                    {

                        Column13.ReadOnly = true;
                        infoSQL.Text = "У вас нет доступа (lvl)";
                        saveFileButton.Enabled = false;
                        loadFileButton.Enabled = false;
                    }
                    if (_lvl < 2)
                    {
                        Column11.ReadOnly = true;
                        Column12.ReadOnly = true;
                    }


                    
                }
                catch
                {
                    return;
                }
            }

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region History
        private void historyUpdateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlName = "OperationProcAll";
                SqlCommand command = new SqlCommand(sqlName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;


                var reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }

                reader.Close();

                dataGridView1.Rows.Clear();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }
        #endregion
        #region Card
        private void collectionCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (collectionCards.SelectedItem == null) return;
            int selectIndex = Card.allStringRecipient.IndexOf(collectionCards.SelectedItem.ToString());
            labelInfo.Text = "";
            fieldNumber.Text = "";
            fieldMoney.Text = Card.allRecipient.ElementAt(selectIndex).Money;
            fieldNumber.Text = Card.allRecipient.ElementAt(selectIndex).CardNumber;
            fieldM.Text = Card.allRecipient.ElementAt(selectIndex).ValidityCard.Substring(2, 2);
            fieldY.Text = Card.allRecipient.ElementAt(selectIndex).ValidityCard.Substring(4);
            accountNumber.Text = Card.allRecipient.ElementAt(selectIndex)._account.ToString();

            labelMax.Text = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlName = "BankAppProcViewAll";
                SqlCommand command = new SqlCommand(sqlName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;


                var reader = command.ExecuteReader();

                Card.allStringRecipient.Clear();
                Card.allRecipient.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string cardNumber = reader.GetString(0);
                        int account = reader.GetInt32(1);
                        string name = reader.GetString(2);
                        string surname = reader.GetString(3);
                        string patronymic = reader.GetString(4);
                        string validityCard = reader.GetString(5);
                        string money = reader.GetDecimal(6).ToString();

                        new Card(cardNumber, name, surname, patronymic, account, validityCard, money);
                    }
                }
                reader.Close();
            }
            labelMax.Text = "";
            collectionCards.Items.Clear();
            collectionCards.Items.AddRange(Card.allStringRecipient.ToArray());
        }

        private void updateValidity_Click(object sender, EventArgs e)
        {
            if (collectionCards.SelectedItem == null) return;
            if (Convert.ToInt32(fieldM.Text) - (DateTime.Now.Year % 2000) >= 5)
            {
                labelMax.Text = "Максимальное значение!";
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlName = "BankCardProcUpdateValidityCard";
                SqlCommand command = new SqlCommand(sqlName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter account = new SqlParameter
                {
                    ParameterName = "@CardNumber",
                    Value = collectionCards.SelectedItem.ToString()
                }; command.Parameters.Add(account);

                SqlParameter validity = new SqlParameter
                {
                    ParameterName = "@validity",
                    Value = "20" + (Convert.ToInt32(fieldM.Text) + 1).ToString() + "1"
                }; command.Parameters.Add(validity);

                command.ExecuteNonQuery();
                fieldM.Text = (Convert.ToInt32(fieldM.Text) + 1).ToString();
            }
        }


        private void delete_Click(object sender, EventArgs e)
        {
            if (collectionCards.SelectedItem == null) return;
            if (_lvl < 2)
            {
                labelMax.Text = "Доступ запрещен!(lvl)";
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlName = "BankCardProcCount";
                SqlCommand command = new SqlCommand(sqlName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter account = new SqlParameter
                {
                    ParameterName = "@account",
                    Value = Card.allRecipient[collectionCards.SelectedIndex]._account
                }; command.Parameters.Add(account);

                SqlParameter count = new SqlParameter
                {
                    ParameterName = "@count",
                    SqlDbType = SqlDbType.Int
                }; count.Direction = ParameterDirection.Output;
                command.Parameters.Add(count);

                command.ExecuteNonQuery();
                if ((int)command.Parameters["@count"].Value < 2)
                {
                    labelMax.Text = "Удаление невозможно!";
                    return;
                }

                sqlName = "BankCardProcDelete";
                command = new SqlCommand(sqlName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter card = new SqlParameter
                {
                    ParameterName = "@CardNumber",
                    Value = collectionCards.SelectedItem.ToString()
                }; command.Parameters.Add(card);

                command.ExecuteNonQuery();
                update_Click(null, null);
            }
        }
        #endregion

        #region Users
        List<string> passwords = new List<string>();
        private void updateUsers_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlName = "UsersAppPasportDataProcAll";
                SqlCommand command = new SqlCommand(sqlName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;


                var reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                passwords.Clear();

                while (reader.Read())
                {
                    data.Add(new string[10]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString().Substring(0, 10);
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();
                    passwords.Add(reader[10].ToString());
                }

                reader.Close();

                dataGridView2.Rows.Clear();
                foreach (string[] s in data)
                    dataGridView2.Rows.Add(s);
            }
        }


       
        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView2[e.ColumnIndex, e.RowIndex].Value == null) return;
            //string data = dataGridView2[e.ColumnIndex, e.RowIndex].Value.ToString();
            string data = e.FormattedValue.ToString();
            int dataNumber;
            switch (e.ColumnIndex)
            {
                case 7:
                    {
                        if (!Regex.IsMatch(data, @"((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$"))
                        {
                            ((DataGridView)sender).CancelEdit();
                        }
                        else
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                string sqlName = "UserAppProcUpdateNumber";
                                SqlCommand command = new SqlCommand(sqlName, connection);
                                command.CommandType = System.Data.CommandType.StoredProcedure;

                                SqlParameter account = new SqlParameter
                                {
                                    ParameterName = "@account",
                                    Value = Convert.ToInt32(dataGridView2[0, e.RowIndex].Value)
                                }; command.Parameters.Add(account);

                                SqlParameter mobileNumber = new SqlParameter
                                {
                                    ParameterName = "@MobileNumber",
                                    Value = data
                                }; command.Parameters.Add(mobileNumber);

                                command.ExecuteNonQuery();
                            }

                        }
                        break;
                    }
                case 8:
                    {
                        if (!Regex.IsMatch(data, @"^.+@.+\..+$"))
                        {
                            ((DataGridView)sender).CancelEdit();
                        }
                        else
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                string sqlName = "UserAppProcUpdateEmail";
                                SqlCommand command = new SqlCommand(sqlName, connection);
                                command.CommandType = System.Data.CommandType.StoredProcedure;

                                SqlParameter account = new SqlParameter
                                {
                                    ParameterName = "@account",
                                    Value = Convert.ToInt32(dataGridView2[0, e.RowIndex].Value)
                                }; command.Parameters.Add(account);

                                SqlParameter email = new SqlParameter
                                {
                                    ParameterName = "@Email",
                                    Value = data
                                }; command.Parameters.Add(email);

                                command.ExecuteNonQuery();
                            }
                        }
                        break;
                    }
                case 9:
                    {
                        try
                        {
                            dataNumber = Convert.ToInt32(data);


                            if (dataNumber > 2 || dataNumber < 0 || dataNumber >= _lvl ||
                                _login == dataGridView2[1, e.RowIndex].Value.ToString())
                            {
                                ((DataGridView)sender).CancelEdit();
                                return;
                            }
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {//Есть ли пользователь в таблице админов?
                                connection.Open();
                                string sqlName = "AdminAppProcCheckAdmin";
                                SqlCommand command = new SqlCommand(sqlName, connection);
                                command.CommandType = System.Data.CommandType.StoredProcedure;

                                SqlParameter login = new SqlParameter
                                {
                                    ParameterName = "@Login",
                                    Value = dataGridView2[1, e.RowIndex].Value.ToString()
                                }; command.Parameters.Add(login);

                                var reader = command.ExecuteReader();

                                if (reader.Read())
                                {
                                    if (Convert.ToInt32(reader.GetInt32(0)) == 0)
                                    {// Да, ЕСТЬ
                                        sqlName = "AdminAppProcInsert";

                                        command = new SqlCommand(sqlName, connection);
                                        command.CommandType = CommandType.StoredProcedure;
                                        var lvl = new SqlParameter
                                        {
                                            ParameterName = "@Lvl",
                                            Value = data
                                        }; command.Parameters.Add(lvl);

                                        login = new SqlParameter
                                        {
                                            ParameterName = "@Login",
                                            Value = dataGridView2[1, e.RowIndex].Value.ToString()
                                        };

                                        SqlParameter password = new SqlParameter
                                        {
                                            ParameterName = "@Password",
                                            Value = passwords[e.RowIndex]
                                        };

                                        SqlParameter seriesNumber = new SqlParameter
                                        {
                                            ParameterName = "@SeriesNumber",
                                            Value = dataGridView2[2, e.RowIndex].Value.ToString()
                                        };

                                        SqlParameter mobileNumber = new SqlParameter();
                                        SqlParameter email = new SqlParameter();

                                        if (dataGridView2[7, e.RowIndex].Value == null ||
                                            dataGridView2[7, e.RowIndex].Value.ToString().Length == 0 ||
                                            dataGridView2[7, e.RowIndex].Value.ToString() == "")
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
                                                    Value = dataGridView2[7, e.RowIndex].Value.ToString()

                                                };
                                                command.Parameters.Add(mobileNumber);
                                            }
                                            catch
                                            {
                                                return;
                                            }
                                        }
                                        if (dataGridView2[8, e.RowIndex].Value == null ||
                                            dataGridView2[8, e.RowIndex].Value.ToString().Length == 0 ||
                                            dataGridView2[8, e.RowIndex].Value.ToString() == "")
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
                                                    Value = dataGridView2[8, e.RowIndex].Value.ToString()
                                                };
                                                command.Parameters.Add(email);
                                            }
                                            catch
                                            {
                                                return;
                                            }
                                        }
                                        command.Parameters.Add(login);
                                        command.Parameters.Add(password);
                                        command.Parameters.Add(seriesNumber);
                                        reader.Close();
                                        try
                                        {
                                            command.ExecuteNonQuery();
                                        }
                                        catch
                                        {
                                            return;
                                        }
                                    }
                                    else
                                    {// НЕТ, его нет
                                        sqlName = "AdminAppProcUpdateLvl";
                                        command = new SqlCommand(sqlName, connection);
                                        command.CommandType = System.Data.CommandType.StoredProcedure;

                                        SqlParameter SeriesNumber = new SqlParameter
                                        {
                                            ParameterName = "@SeriesNumber",
                                            Value = Convert.ToInt32(dataGridView2[2, e.RowIndex].Value)
                                        }; command.Parameters.Add(SeriesNumber);

                                        SqlParameter lvl = new SqlParameter
                                        {
                                            ParameterName = "@lvl",
                                            Value = data
                                        }; command.Parameters.Add(lvl);
                                        reader.Close();
                                        command.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        catch
                        {
                            ((DataGridView)sender).CancelEdit();
                            return;
                        }

                        break;
                    }
            }
        }
        #endregion
        #region Load and save
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.bak)|*.bak";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;

            saveFileWindow.Text = filename;
            infoSQL.Text = "Файл сохранен";
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.bak)|*.bak";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;

            loadFileWindow.Text = filename;
            infoSQL.Text = "Файл загружен";
        }

        private void createBackup_Click(object sender, EventArgs e)
        {
            infoSQL.Text = "Загрузка...";
            if (saveFileWindow.Text == null || saveFileWindow.Text.Length == 0) return;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlName = "SetBackup";
                SqlCommand command = new SqlCommand(sqlName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter file = new SqlParameter
                {
                    ParameterName = "@file",
                    Value = saveFileWindow.Text
                }; command.Parameters.Add(file);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    infoSQL.Text = "Ошибка!";
                }
                infoSQL.Text = "Создана резервная копия";
            }
        }

        private void loadBackup_Click(object sender, EventArgs e)
        {
            infoSQL.Text = "Загрузка...";
            string connectionStringMaster = "server=DESKTOP-QGUHKNA;Trusted_Connection=Yes;DataBase=master;";
            if (loadFileWindow.Text == null || loadFileWindow.Text.Length == 0) return;
            using (SqlConnection connection = new SqlConnection(connectionStringMaster))
            {
                connection.Open();
                string sqlName = "GetBackup";
                SqlCommand command = new SqlCommand(sqlName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter file = new SqlParameter
                {
                    ParameterName = "@file",
                    Value = loadFileWindow.Text
                }; command.Parameters.Add(file);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    infoSQL.Text = "Ошибка!";
                }
                infoSQL.Text = "Загружена резервная копия";
            }
        }
        #endregion
    }
}

