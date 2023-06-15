
namespace BankAppU
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeButton = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.fieldM = new System.Windows.Forms.Label();
            this.fieldY = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fieldNumber = new System.Windows.Forms.Label();
            this.fieldMoney = new System.Windows.Forms.Label();
            this.fieldSystem = new System.Windows.Forms.Label();
            this.fieldName = new System.Windows.Forms.Label();
            this.collectionCards = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.transferOK = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.transferNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.transferSecondCard = new System.Windows.Forms.Label();
            this.transferFirstCard = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.transferRecipientUpdate = new System.Windows.Forms.Label();
            this.transferRecipient = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transferUpdate = new System.Windows.Forms.Label();
            this.transferCollectionCards = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelError = new System.Windows.Forms.Label();
            this.CreateCard = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.Lvl2 = new System.Windows.Forms.Label();
            this.Lvl4 = new System.Windows.Forms.Label();
            this.Lvl3 = new System.Windows.Forms.Label();
            this.Lvl1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.NameNo = new System.Windows.Forms.Label();
            this.NameYes = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Servis1 = new System.Windows.Forms.Label();
            this.Servis2 = new System.Windows.Forms.Label();
            this.Servis3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.Account.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transferNumeric)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Segoe Print", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.closeButton.ForeColor = System.Drawing.Color.OldLace;
            this.closeButton.Location = new System.Drawing.Point(698, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeButton.Size = new System.Drawing.Size(90, 59);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "[<-]";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Account
            // 
            this.Account.Controls.Add(this.tabPage1);
            this.Account.Controls.Add(this.tabPage2);
            this.Account.Controls.Add(this.tabPage3);
            this.Account.Controls.Add(this.tabPage4);
            this.Account.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Account.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Account.Location = new System.Drawing.Point(0, 66);
            this.Account.Name = "Account";
            this.Account.SelectedIndex = 0;
            this.Account.Size = new System.Drawing.Size(800, 534);
            this.Account.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SeaGreen;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.labelInfo);
            this.tabPage1.Controls.Add(this.update);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.collectionCards);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(792, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Карты";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.label15.Location = new System.Drawing.Point(8, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(776, 38);
            this.label15.TabIndex = 21;
            this.label15.Text = "*Здесь Вы можете выбрать одну из ваших карт и посмотреть остаток средств на ней";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.Olive;
            this.labelInfo.Location = new System.Drawing.Point(14, 438);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(770, 33);
            this.labelInfo.TabIndex = 20;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Location = new System.Drawing.Point(8, 367);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(230, 67);
            this.update.TabIndex = 3;
            this.update.Text = "Обновить";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update.MouseUp += new System.Windows.Forms.MouseEventHandler(this.update_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.fieldM);
            this.panel1.Controls.Add(this.fieldY);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.fieldNumber);
            this.panel1.Controls.Add(this.fieldMoney);
            this.panel1.Controls.Add(this.fieldSystem);
            this.panel1.Controls.Add(this.fieldName);
            this.panel1.Location = new System.Drawing.Point(244, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 319);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(372, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 35);
            this.label7.TabIndex = 3;
            this.label7.Text = "/";
            // 
            // fieldM
            // 
            this.fieldM.BackColor = System.Drawing.Color.OldLace;
            this.fieldM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldM.Location = new System.Drawing.Point(307, 185);
            this.fieldM.Name = "fieldM";
            this.fieldM.Size = new System.Drawing.Size(59, 42);
            this.fieldM.TabIndex = 7;
            this.fieldM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fieldY
            // 
            this.fieldY.BackColor = System.Drawing.Color.OldLace;
            this.fieldY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldY.Location = new System.Drawing.Point(405, 185);
            this.fieldY.Name = "fieldY";
            this.fieldY.Size = new System.Drawing.Size(59, 42);
            this.fieldY.TabIndex = 6;
            this.fieldY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.GhostWhite;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(470, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "Руб";
            // 
            // fieldNumber
            // 
            this.fieldNumber.BackColor = System.Drawing.Color.OldLace;
            this.fieldNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fieldNumber.Location = new System.Drawing.Point(80, 125);
            this.fieldNumber.Name = "fieldNumber";
            this.fieldNumber.Size = new System.Drawing.Size(384, 42);
            this.fieldNumber.TabIndex = 3;
            this.fieldNumber.Text = "* * * * * * * * * *";
            this.fieldNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fieldMoney
            // 
            this.fieldMoney.BackColor = System.Drawing.Color.GhostWhite;
            this.fieldMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fieldMoney.Location = new System.Drawing.Point(15, 36);
            this.fieldMoney.Name = "fieldMoney";
            this.fieldMoney.Size = new System.Drawing.Size(449, 42);
            this.fieldMoney.TabIndex = 2;
            this.fieldMoney.Text = "Выберите карту";
            this.fieldMoney.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fieldSystem
            // 
            this.fieldSystem.BackColor = System.Drawing.Color.OldLace;
            this.fieldSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldSystem.Location = new System.Drawing.Point(336, 268);
            this.fieldSystem.Name = "fieldSystem";
            this.fieldSystem.Size = new System.Drawing.Size(188, 42);
            this.fieldSystem.TabIndex = 1;
            // 
            // fieldName
            // 
            this.fieldName.BackColor = System.Drawing.Color.Transparent;
            this.fieldName.Location = new System.Drawing.Point(15, 268);
            this.fieldName.Name = "fieldName";
            this.fieldName.Size = new System.Drawing.Size(325, 42);
            this.fieldName.TabIndex = 0;
            // 
            // collectionCards
            // 
            this.collectionCards.BackColor = System.Drawing.Color.OldLace;
            this.collectionCards.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.collectionCards.FormattingEnabled = true;
            this.collectionCards.ItemHeight = 35;
            this.collectionCards.Location = new System.Drawing.Point(8, 115);
            this.collectionCards.Name = "collectionCards";
            this.collectionCards.Size = new System.Drawing.Size(230, 249);
            this.collectionCards.TabIndex = 1;
            this.collectionCards.SelectedIndexChanged += new System.EventHandler(this.collectionCards_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 35);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.transferOK);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.transferNumeric);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.transferSecondCard);
            this.tabPage2.Controls.Add(this.transferFirstCard);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.transferRecipientUpdate);
            this.tabPage2.Controls.Add(this.transferRecipient);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.transferUpdate);
            this.tabPage2.Controls.Add(this.transferCollectionCards);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Переводы";
            // 
            // transferOK
            // 
            this.transferOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.transferOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transferOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transferOK.Location = new System.Drawing.Point(220, 381);
            this.transferOK.Name = "transferOK";
            this.transferOK.Size = new System.Drawing.Size(265, 71);
            this.transferOK.TabIndex = 17;
            this.transferOK.Text = "Перевести";
            this.transferOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.transferOK.Click += new System.EventHandler(this.transferOK_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(214, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(271, 39);
            this.label10.TabIndex = 16;
            this.label10.Text = "Сумма перевода (RUB):";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // transferNumeric
            // 
            this.transferNumeric.DecimalPlaces = 2;
            this.transferNumeric.Location = new System.Drawing.Point(220, 328);
            this.transferNumeric.Name = "transferNumeric";
            this.transferNumeric.Size = new System.Drawing.Size(265, 43);
            this.transferNumeric.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(220, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 39);
            this.label9.TabIndex = 14;
            this.label9.Text = "Карта получателя:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // transferSecondCard
            // 
            this.transferSecondCard.BackColor = System.Drawing.Color.Transparent;
            this.transferSecondCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.transferSecondCard.Location = new System.Drawing.Point(220, 217);
            this.transferSecondCard.Name = "transferSecondCard";
            this.transferSecondCard.Size = new System.Drawing.Size(265, 35);
            this.transferSecondCard.TabIndex = 13;
            this.transferSecondCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // transferFirstCard
            // 
            this.transferFirstCard.BackColor = System.Drawing.Color.Transparent;
            this.transferFirstCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.transferFirstCard.Location = new System.Drawing.Point(220, 132);
            this.transferFirstCard.Name = "transferFirstCard";
            this.transferFirstCard.Size = new System.Drawing.Size(265, 35);
            this.transferFirstCard.TabIndex = 12;
            this.transferFirstCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(220, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 35);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ваша карта:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(220, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 68);
            this.label4.TabIndex = 10;
            this.label4.Text = "Перевод";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // transferRecipientUpdate
            // 
            this.transferRecipientUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.transferRecipientUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transferRecipientUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transferRecipientUpdate.Location = new System.Drawing.Point(494, 381);
            this.transferRecipientUpdate.Name = "transferRecipientUpdate";
            this.transferRecipientUpdate.Size = new System.Drawing.Size(290, 71);
            this.transferRecipientUpdate.TabIndex = 9;
            this.transferRecipientUpdate.Text = "Обновить";
            this.transferRecipientUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.transferRecipientUpdate.Click += new System.EventHandler(this.transferRecipientUpdate_Click);
            // 
            // transferRecipient
            // 
            this.transferRecipient.BackColor = System.Drawing.Color.OldLace;
            this.transferRecipient.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.transferRecipient.FormattingEnabled = true;
            this.transferRecipient.ItemHeight = 35;
            this.transferRecipient.Location = new System.Drawing.Point(494, 48);
            this.transferRecipient.Name = "transferRecipient";
            this.transferRecipient.Size = new System.Drawing.Size(290, 319);
            this.transferRecipient.TabIndex = 8;
            this.transferRecipient.SelectedIndexChanged += new System.EventHandler(this.transferRecipient_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(494, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Карта получателя";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите карту";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // transferUpdate
            // 
            this.transferUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.transferUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transferUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transferUpdate.Location = new System.Drawing.Point(8, 381);
            this.transferUpdate.Name = "transferUpdate";
            this.transferUpdate.Size = new System.Drawing.Size(203, 71);
            this.transferUpdate.TabIndex = 4;
            this.transferUpdate.Text = "Обновить";
            this.transferUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.transferUpdate.Click += new System.EventHandler(this.transferUpdate_Click);
            // 
            // transferCollectionCards
            // 
            this.transferCollectionCards.BackColor = System.Drawing.Color.OldLace;
            this.transferCollectionCards.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.transferCollectionCards.FormattingEnabled = true;
            this.transferCollectionCards.ItemHeight = 35;
            this.transferCollectionCards.Location = new System.Drawing.Point(8, 48);
            this.transferCollectionCards.Name = "transferCollectionCards";
            this.transferCollectionCards.Size = new System.Drawing.Size(203, 319);
            this.transferCollectionCards.TabIndex = 2;
            this.transferCollectionCards.SelectedIndexChanged += new System.EventHandler(this.transferCollectionCards_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Moccasin;
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage3.Controls.Add(this.labelError);
            this.tabPage3.Controls.Add(this.CreateCard);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.Cost);
            this.tabPage3.Controls.Add(this.Lvl2);
            this.tabPage3.Controls.Add(this.Lvl4);
            this.tabPage3.Controls.Add(this.Lvl3);
            this.tabPage3.Controls.Add(this.Lvl1);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.NameNo);
            this.tabPage3.Controls.Add(this.NameYes);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.Servis1);
            this.tabPage3.Controls.Add(this.Servis2);
            this.tabPage3.Controls.Add(this.Servis3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 486);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Новая карта";
            // 
            // labelError
            // 
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Olive;
            this.labelError.Location = new System.Drawing.Point(42, 346);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(694, 32);
            this.labelError.TabIndex = 19;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateCard
            // 
            this.CreateCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.CreateCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateCard.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.CreateCard.Location = new System.Drawing.Point(39, 400);
            this.CreateCard.Name = "CreateCard";
            this.CreateCard.Size = new System.Drawing.Size(694, 50);
            this.CreateCard.TabIndex = 18;
            this.CreateCard.Text = "Создать карту ";
            this.CreateCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreateCard.Click += new System.EventHandler(this.CreateCard_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.label23.Location = new System.Drawing.Point(96, 287);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(331, 35);
            this.label23.TabIndex = 17;
            this.label23.Text = "Цена за обслуживание карты:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Cost
            // 
            this.Cost.AutoEllipsis = true;
            this.Cost.BackColor = System.Drawing.Color.Transparent;
            this.Cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cost.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.Cost.Location = new System.Drawing.Point(446, 287);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(161, 35);
            this.Cost.TabIndex = 16;
            this.Cost.Text = "0";
            this.Cost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Lvl2
            // 
            this.Lvl2.AutoSize = true;
            this.Lvl2.BackColor = System.Drawing.Color.Transparent;
            this.Lvl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lvl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lvl2.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.Lvl2.Location = new System.Drawing.Point(402, 220);
            this.Lvl2.Name = "Lvl2";
            this.Lvl2.Size = new System.Drawing.Size(96, 37);
            this.Lvl2.TabIndex = 15;
            this.Lvl2.Text = "Золото";
            this.Lvl2.Click += new System.EventHandler(this.Lvl2_Click);
            // 
            // Lvl4
            // 
            this.Lvl4.AutoSize = true;
            this.Lvl4.BackColor = System.Drawing.Color.Transparent;
            this.Lvl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lvl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lvl4.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.Lvl4.Location = new System.Drawing.Point(623, 220);
            this.Lvl4.Name = "Lvl4";
            this.Lvl4.Size = new System.Drawing.Size(113, 37);
            this.Lvl4.TabIndex = 14;
            this.Lvl4.Text = "Премиум";
            this.Lvl4.Click += new System.EventHandler(this.Lvl4_Click);
            // 
            // Lvl3
            // 
            this.Lvl3.AutoSize = true;
            this.Lvl3.BackColor = System.Drawing.Color.Transparent;
            this.Lvl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lvl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lvl3.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.Lvl3.Location = new System.Drawing.Point(504, 220);
            this.Lvl3.Name = "Lvl3";
            this.Lvl3.Size = new System.Drawing.Size(113, 37);
            this.Lvl3.TabIndex = 13;
            this.Lvl3.Text = "Платина";
            this.Lvl3.Click += new System.EventHandler(this.Lvl3_Click);
            // 
            // Lvl1
            // 
            this.Lvl1.AutoSize = true;
            this.Lvl1.BackColor = System.Drawing.Color.Transparent;
            this.Lvl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lvl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lvl1.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.Lvl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Lvl1.Location = new System.Drawing.Point(263, 220);
            this.Lvl1.Name = "Lvl1";
            this.Lvl1.Size = new System.Drawing.Size(133, 37);
            this.Lvl1.TabIndex = 12;
            this.Lvl1.Text = "Стандарт";
            this.Lvl1.Click += new System.EventHandler(this.Lvl1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label17.Location = new System.Drawing.Point(6, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(256, 42);
            this.label17.TabIndex = 11;
            this.label17.Text = "3) Уровень карты:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NameNo
            // 
            this.NameNo.AutoSize = true;
            this.NameNo.BackColor = System.Drawing.Color.Transparent;
            this.NameNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NameNo.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.NameNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.NameNo.Location = new System.Drawing.Point(263, 178);
            this.NameNo.Name = "NameNo";
            this.NameNo.Size = new System.Drawing.Size(64, 37);
            this.NameNo.TabIndex = 10;
            this.NameNo.Text = "Нет";
            this.NameNo.Click += new System.EventHandler(this.NameNo_Click);
            // 
            // NameYes
            // 
            this.NameYes.AutoSize = true;
            this.NameYes.BackColor = System.Drawing.Color.Transparent;
            this.NameYes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NameYes.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.NameYes.Location = new System.Drawing.Point(333, 178);
            this.NameYes.Name = "NameYes";
            this.NameYes.Size = new System.Drawing.Size(48, 37);
            this.NameYes.TabIndex = 9;
            this.NameYes.Text = "Да";
            this.NameYes.Click += new System.EventHandler(this.NameYes_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label14.Location = new System.Drawing.Point(6, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(265, 42);
            this.label14.TabIndex = 8;
            this.label14.Text = "2) Именная карта:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label12.Location = new System.Drawing.Point(6, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(443, 42);
            this.label12.TabIndex = 7;
            this.label12.Text = "1) Выберете сервесную систему:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Servis1
            // 
            this.Servis1.AutoSize = true;
            this.Servis1.BackColor = System.Drawing.Color.Transparent;
            this.Servis1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Servis1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Servis1.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.Servis1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Servis1.Location = new System.Drawing.Point(455, 136);
            this.Servis1.Name = "Servis1";
            this.Servis1.Size = new System.Drawing.Size(62, 37);
            this.Servis1.TabIndex = 6;
            this.Servis1.Text = "Мир";
            this.Servis1.Click += new System.EventHandler(this.Servis1_Click);
            // 
            // Servis2
            // 
            this.Servis2.AutoSize = true;
            this.Servis2.BackColor = System.Drawing.Color.Transparent;
            this.Servis2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Servis2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Servis2.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.Servis2.Location = new System.Drawing.Point(523, 136);
            this.Servis2.Name = "Servis2";
            this.Servis2.Size = new System.Drawing.Size(142, 37);
            this.Servis2.TabIndex = 5;
            this.Servis2.Text = "Master Card";
            this.Servis2.Click += new System.EventHandler(this.Servis2_Click);
            // 
            // Servis3
            // 
            this.Servis3.AutoSize = true;
            this.Servis3.BackColor = System.Drawing.Color.Transparent;
            this.Servis3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Servis3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Servis3.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.Servis3.Location = new System.Drawing.Point(676, 136);
            this.Servis3.Name = "Servis3";
            this.Servis3.Size = new System.Drawing.Size(57, 37);
            this.Servis3.TabIndex = 4;
            this.Servis3.Text = "Visa";
            this.Servis3.Click += new System.EventHandler(this.Servis3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.label8.Location = new System.Drawing.Point(613, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 35);
            this.label8.TabIndex = 3;
            this.label8.Text = "Руб/месяц";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Underline);
            this.label13.Location = new System.Drawing.Point(42, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(694, 72);
            this.label13.TabIndex = 2;
            this.label13.Text = "Создание дебетовой карты";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 486);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "История операций ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Underline);
            this.label16.Location = new System.Drawing.Point(42, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(694, 72);
            this.label16.TabIndex = 7;
            this.label16.Text = "История операций";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(8, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 310);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 15F;
            this.Column1.HeaderText = "Дата";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 19.69697F;
            this.Column2.HeaderText = "Отправитель";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 19.69697F;
            this.Column3.HeaderText = "Получатель";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 10F;
            this.Column4.HeaderText = "Сумма";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Location = new System.Drawing.Point(8, 410);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(776, 55);
            this.label11.TabIndex = 5;
            this.label11.Text = "Обновить";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Account.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transferNumeric)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.TabControl Account;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox collectionCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fieldSystem;
        private System.Windows.Forms.Label fieldName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label fieldM;
        private System.Windows.Forms.Label fieldY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fieldNumber;
        private System.Windows.Forms.Label fieldMoney;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Servis1;
        private System.Windows.Forms.Label Servis2;
        private System.Windows.Forms.Label Servis3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label Lvl2;
        private System.Windows.Forms.Label Lvl4;
        private System.Windows.Forms.Label Lvl3;
        private System.Windows.Forms.Label Lvl1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label NameNo;
        private System.Windows.Forms.Label NameYes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label CreateCard;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label update;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label transferOK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown transferNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label transferSecondCard;
        private System.Windows.Forms.Label transferFirstCard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label transferRecipientUpdate;
        private System.Windows.Forms.ListBox transferRecipient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label transferUpdate;
        private System.Windows.Forms.ListBox transferCollectionCards;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}