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
    public partial class ClientForm : Form
    {
        private int _account;
        private string _login;
        private string _password;
        private string _mobileNumber;
        private string _email;

        private string _seriesNumber;
        private string _Name;
        private string _Surname;
        private string _Patronymic;
        private DateTime _DateOfBirth;
        private string _PlaceOfBirth;


        private int servis = 0;
        private bool nameisNotNull = false;
        private int LvlCard = 0;

        const string connectionString = "server=DESKTOP-QGUHKNA;Trusted_Connection=Yes;DataBase=BankApp;";

        class Card
        {
            public string CardNumber;
            public string ValidityCard;
            public string CVC;
            public string Money;
            public string CardServiceSystem;
            public static List<Card> allCards = new List<Card>();
            public static List<string> allStringCards = new List<string>();
            public static List<string> allStringRecipient = new List<string>();
            public static List<Card> allRecipient = new List<Card>();

            public bool NameIsNotNull;
            public string _name;
            public string _surname;
            public string _patronymic;
            public int _account;


            public Card(string cardNumber, string validityCard, string cvc, string money, string cardServiceSystem,
                bool nameIsNotNull = false)
            {
                CardNumber = cardNumber;
                ValidityCard = validityCard;
                CVC = cvc;
                Money = money;
                CardServiceSystem = cardServiceSystem;
                NameIsNotNull = nameIsNotNull;

                allCards.Add(this);
                allStringCards.Add(cardNumber.Substring(11));
            }

            public Card(string cardNumber, string name, string surname, string patronymic, int account)
            {
                CardNumber = cardNumber;
                _name = name;
                _surname = surname;
                _patronymic = patronymic;
                _account = account;

                allRecipient.Add(this);
                allStringRecipient.Add(cardNumber);
            }
        }

        public ClientForm()
        {
            InitializeComponent();
            update_Click(null, null);
        }
        public ClientForm(string login)
        {
            InitializeComponent();

            ToolTip
                toolTipLvl1 = new ToolTip(),
                toolTipLvl2 = new ToolTip(),
                toolTipLvl3 = new ToolTip(),
                toolTipLvl4 = new ToolTip();

            toolTipLvl1.SetToolTip(Lvl1, "Срок обслуживание карты - 1 год");
            toolTipLvl2.SetToolTip(Lvl2, "Срок обслуживание карты - 2 года");
            toolTipLvl3.SetToolTip(Lvl3, "Срок обслуживание карты - 3 года");
            toolTipLvl4.SetToolTip(Lvl4, "Срок обслуживание карты - 4 года");

            _login = login;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlProcedure = "UserAppProcClientDesigner";
                SqlCommand command = new SqlCommand(sqlProcedure, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlLogin = new SqlParameter
                {
                    ParameterName = "@login",
                    Value = login
                }; command.Parameters.Add(sqlLogin);

                var reader = command.ExecuteReader();

                if (!reader.Read()) { label1.Text = ":("; return; }
                else
                {
                    _account = reader.GetInt32(0);
                    _login = reader.GetString(1);
                    _password = reader.GetString(2);
                    _seriesNumber = reader.GetString(3);
                    if (!reader.IsDBNull(4)) _mobileNumber = reader.GetString(4);
                    else _mobileNumber = "";
                    if (!reader.IsDBNull(5)) _email = reader.GetString(5);
                    else _email = "";



                }
                reader.Close();
                //-------------+

                sqlProcedure = "PasportDataClientDesigner";
                command = new SqlCommand(sqlProcedure, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlSeriesNumber = new SqlParameter
                {
                    ParameterName = "@SeriesNumber",
                    Value = _seriesNumber
                }; command.Parameters.Add(sqlSeriesNumber);

                reader = command.ExecuteReader();

                if (!reader.Read()) { label1.Text = ":(("; return; }
                else
                {
                    _Name = reader.GetString(1);
                    _Surname = reader.GetString(2);
                    _Patronymic = reader.GetString(3);
                    _DateOfBirth = reader.GetDateTime(4);
                    _PlaceOfBirth = reader.GetString(5);

                    label1.Text = "Добро пожаловать, " + _Name.ToString() + "!";

                }
                reader.Close();
            }
            update_Click(null, null);
        }


        private void closeButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        #region Page3thNewCard
        private void Servis1_Click(object sender, EventArgs e)
        {
            Servis1.ForeColor = Color.FromArgb(255, 155, 155, 155);
            Servis2.ForeColor = Color.FromArgb(255, 0, 0, 0);
            Servis3.ForeColor = Color.FromArgb(255, 0, 0, 0);
            servis = 0;
            ChangeCost();
        }


        private void Servis2_Click(object sender, EventArgs e)
        {
            Servis2.ForeColor = Color.FromArgb(255, 155, 155, 155);
            Servis1.ForeColor = Color.FromArgb(255, 0, 0, 0);
            Servis3.ForeColor = Color.FromArgb(255, 0, 0, 0);
            servis = 2;
            ChangeCost();
        }

        private void Servis3_Click(object sender, EventArgs e)
        {
            Servis3.ForeColor = Color.FromArgb(255, 155, 155, 155);
            Servis1.ForeColor = Color.FromArgb(255, 0, 0, 0);
            Servis2.ForeColor = Color.FromArgb(255, 0, 0, 0);
            servis = 3;
            ChangeCost();
        }

        private void NameYes_Click(object sender, EventArgs e)
        {
            NameYes.ForeColor = Color.FromArgb(255, 155, 155, 155);
            NameNo.ForeColor = Color.FromArgb(255, 0, 0, 0);
            nameisNotNull = true;
            ChangeCost();
        }

        private void NameNo_Click(object sender, EventArgs e)
        {
            NameNo.ForeColor = Color.FromArgb(255, 155, 155, 155);
            NameYes.ForeColor = Color.FromArgb(255, 0, 0, 0);
            nameisNotNull = false;
            ChangeCost();
        }

        private void Lvl1_Click(object sender, EventArgs e)
        {
            Lvl1.ForeColor = Color.FromArgb(255, 155, 155, 155);
            Lvl2.ForeColor = Color.FromArgb(255, 0, 0, 0);
            Lvl3.ForeColor = Color.FromArgb(255, 0, 0, 0);
            Lvl4.ForeColor = Color.FromArgb(255, 0, 0, 0);
            LvlCard = 0;
            ChangeCost();
        }

        private void Lvl2_Click(object sender, EventArgs e)
        {
            Lvl2.ForeColor = Color.FromArgb(255, 155, 155, 155);
            Lvl1.ForeColor = Color.FromArgb(255, 0, 0, 0);
            Lvl3.ForeColor = Color.FromArgb(255, 0, 0, 0);
            Lvl4.ForeColor = Color.FromArgb(255, 0, 0, 0);
            LvlCard = 1;
            ChangeCost();
        }

        private void Lvl3_Click(object sender, EventArgs e)
        {
            Lvl3.ForeColor = Color.FromArgb(255, 155, 155, 155);
            Lvl2.ForeColor = Color.FromArgb(255, 0, 0, 0);
            Lvl1.ForeColor = Color.FromArgb(255, 0, 0, 0);
            Lvl4.ForeColor = Color.FromArgb(255, 0, 0, 0);
            LvlCard = 2;
            ChangeCost();
        }

        private void Lvl4_Click(object sender, EventArgs e)
        {
            Lvl4.ForeColor = Color.FromArgb(255, 155, 155, 155);
            Lvl2.ForeColor = Color.FromArgb(255, 0, 0, 0);
            Lvl3.ForeColor = Color.FromArgb(255, 0, 0, 0);
            Lvl1.ForeColor = Color.FromArgb(255, 0, 0, 0);
            LvlCard = 3;
            ChangeCost();
        }

        private void ChangeCost()
        {
            int tempCost = 0;
            tempCost += servis * 49 + LvlCard * 221;
            if (nameisNotNull) tempCost += 104;

            Cost.Text = tempCost.ToString();

        }

        private void CreateCard_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlCheakNameProcedure = "[BankCardProcCount]";

                SqlCommand command = new SqlCommand(sqlCheakNameProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter account = new SqlParameter
                {
                    ParameterName = "@account",
                    Value = _account
                };

                SqlParameter count = new SqlParameter
                {
                    ParameterName = "@count",
                    SqlDbType = SqlDbType.Int
                }; count.Direction = ParameterDirection.Output;

                command.Parameters.Add(account);
                command.Parameters.Add(count);

                command.ExecuteNonQuery();


                if ((int)command.Parameters["@count"].Value >= 5)
                {
                    labelError.Text = "У вас слишком много карт";
                    return;
                }

                //Добавление карты --

                sqlCheakNameProcedure = "[BankCardProcInsert]";

                command = new SqlCommand(sqlCheakNameProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                Random random = new Random();

                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.Append((servis + 5).ToString());
                stringBuilder.Append("89081");
                for (int i = 0; i < 14; i++)
                {
                    stringBuilder.Append(random.Next(0, 9));
                }

                SqlParameter cardNumber = new SqlParameter
                {
                    ParameterName = "@CardNumber",
                    Value = stringBuilder.ToString()
                };
                command.Parameters.Add(cardNumber);

                SqlParameter validityCard = new SqlParameter
                {
                    ParameterName = "@ValidityCard",
                    Value = ((int)(DateTime.Today.Year) + LvlCard).ToString() + DateTime.Today.Month.ToString()
                }; command.Parameters.Add(validityCard);


                SqlParameter cvc = new SqlParameter
                {
                    ParameterName = "@CVC",
                    Value = random.Next(100, 999)
                }; command.Parameters.Add(cvc);

                string systemName;

                switch (servis)
                {
                    case 0:
                        systemName = "МИР";
                        break;
                    case 2:
                        systemName = "MASTER CARD";
                        break;
                    case 3:
                        systemName = "VISA";
                        break;
                    default:
                        systemName = "МИР";
                        break;
                }

                SqlParameter system = new SqlParameter
                {
                    ParameterName = "@CardServiceSystem",
                    Value = systemName
                }; command.Parameters.Add(system);

                SqlParameter nameCard;
                if (nameisNotNull)
                {
                    nameCard = new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = _Name
                    };
                    command.Parameters.Add(nameCard);
                }
                else
                {
                    nameCard = new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = DBNull.Value
                    };
                    command.Parameters.Add(nameCard);
                }

                SqlParameter surnameCard;
                if (nameisNotNull)
                {
                    surnameCard = new SqlParameter
                    {
                        ParameterName = "@Surname",
                        Value = _Surname
                    };
                    command.Parameters.Add(surnameCard);
                }
                else
                {
                    surnameCard = new SqlParameter
                    {
                        ParameterName = "@Surname",
                        Value = DBNull.Value
                    };
                    command.Parameters.Add(surnameCard);
                }

                SqlParameter accountCard;
                accountCard = new SqlParameter
                {
                    ParameterName = "@Account",
                    Value = _account
                };
                command.Parameters.Add(accountCard);


                SqlParameter mobileCard;
                if (_mobileNumber == "" || _mobileNumber.Length == 0)
                {
                    mobileCard = new SqlParameter
                    {
                        ParameterName = "@MobileNumber",
                        Value = DBNull.Value
                    };
                    command.Parameters.Add(mobileCard);
                }
                else
                {
                    mobileCard = new SqlParameter
                    {
                        ParameterName = "@MobileNumber",
                        Value = _mobileNumber
                    };
                    command.Parameters.Add(mobileCard);
                }
                try
                {
                    command.ExecuteNonQuery();
                    labelError.Text = "Карта " + cardNumber.Value.ToString().Substring(15) + " создана!";
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    labelError.Text = "Ошибка подключения к серверу!";
                }
            }
        }

        #endregion 
        #region PageSecondMain

        private void update_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlName = "BankCardProcCardsListFind";
                SqlCommand command = new SqlCommand(sqlName, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter account = new SqlParameter
                {
                    ParameterName = "@account",
                    Value = _account
                }; command.Parameters.Add(account);

                var reader = command.ExecuteReader();

                Card.allStringCards.Clear();
                Card.allCards.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string cardNumber = reader.GetString(0);
                        string validityCard = reader.GetString(1);
                        string cvc = reader.GetInt32(2).ToString();
                        string money = reader.GetDecimal(3).ToString();
                        string cardServiceSystem = reader.GetString(4);
                        bool nameIsNotNull = !reader.IsDBNull(5);



                        new Card(cardNumber, validityCard, cvc, money, cardServiceSystem, nameIsNotNull);
                    }
                }
                reader.Close();


                collectionCards.Items.Clear();
                collectionCards.Items.AddRange(Card.allStringCards.ToArray());

                transferCollectionCards.Items.Clear();
                transferCollectionCards.Items.AddRange(Card.allStringCards.ToArray());

                transferRecipientUpdate_Click(null, null);
            }
        }

        private void collectionCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (collectionCards.SelectedItem == null) return;
            int selectIndex = Card.allStringCards.IndexOf(collectionCards.SelectedItem.ToString());
            labelInfo.Text = "";
            fieldName.Text = "";
            fieldNumber.Text = "";
            fieldMoney.Text = Card.allCards.ElementAt(selectIndex).Money;
            fieldNumber.Text = Card.allCards.ElementAt(selectIndex).CardNumber;
            fieldM.Text = Card.allCards.ElementAt(selectIndex).ValidityCard.Substring(2, 2);
            fieldY.Text = Card.allCards.ElementAt(selectIndex).ValidityCard.Substring(4);
            if (Card.allCards.ElementAt(selectIndex).NameIsNotNull)
                fieldName.Text = _Surname + " " + _Name.Substring(0, 1) + "." +
                    ((_Patronymic.Length == 0) ? "" : _Patronymic.Substring(0, 1) + ".");

            fieldSystem.Text = Card.allCards.ElementAt(selectIndex).CardServiceSystem;

        }
        #endregion
        #region PageSecondTransfer
        private void transferUpdate_Click(object sender, EventArgs e)
        {
            update_Click(sender, e);
        }

        private void transferCollectionCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (transferCollectionCards.SelectedItem == null) return;
            transferFirstCard.Text = transferCollectionCards.SelectedItem.ToString();
            transferNumeric.Value = 0;
            transferNumeric.Maximum = Convert.ToDecimal(
                Card.allCards.ElementAt(transferCollectionCards.SelectedIndex).Money);
        }

        private void transferRecipient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (transferRecipient.SelectedItem == null) return;
            transferSecondCard.Text = transferRecipient.SelectedItem.ToString();
        }

        private void transferRecipientUpdate_Click(object sender, EventArgs e)
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



                        new Card(cardNumber, name, surname, patronymic, account);
                    }
                }
                reader.Close();
            }

            transferRecipient.Items.Clear();
            transferRecipient.Items.AddRange(Card.allStringRecipient.ToArray());


        }

        private void transferOK_Click(object sender, EventArgs e)
        {
            if (transferCollectionCards.SelectedItem == null || transferRecipient.SelectedItem == null||
                (Decimal)transferNumeric.Value == 0)
                return;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlName = "OperationInsert";
                SqlCommand command = new SqlCommand(sqlName, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter senderAccount = new SqlParameter
                {
                    ParameterName = "@Sender",
                    Value = Card.allCards.ElementAt(transferCollectionCards.SelectedIndex).CardNumber
                }; command.Parameters.Add(senderAccount);

                SqlParameter recipientAccount = new SqlParameter
                {
                    ParameterName = "@Recipient",
                    Value = Card.allRecipient.ElementAt(transferRecipient.SelectedIndex).CardNumber
                }; command.Parameters.Add(recipientAccount);
                
                SqlParameter sum = new SqlParameter
                {
                    ParameterName = "@Sum",
                    Value = transferNumeric.Value
                }; command.Parameters.Add(sum);
                
                command.ExecuteNonQuery();

                MessageBox.Show("\tПеревод выполнен на сумму " + sum.Value + "RUB\n\t На карту **** **** **** " +
                    transferRecipient.SelectedItem.ToString().Substring(3) + "\n\tВладелец: " +
                    Card.allRecipient[transferRecipient.SelectedIndex]._surname.ToString()
                    , "ПЕРЕВОД");

                transferCollectionCards_SelectedIndexChanged(null, null);
                update_Click(null, null);
            }
        }
        #endregion
        #region Operation

        private void label11_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlName = "OperationProcFind";
                SqlCommand command = new SqlCommand(sqlName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter account = new SqlParameter
                {
                    ParameterName = "@account",
                    Value = _account
                }; command.Parameters.Add(account);


                var reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();

                }

                reader.Close();

                dataGridView1.Rows.Clear();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }
        #endregion
    }
}