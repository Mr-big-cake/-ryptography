
namespace BankAppU
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeButton = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMax = new System.Windows.Forms.Label();
            this.accountNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateValidity = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fieldM = new System.Windows.Forms.Label();
            this.fieldY = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fieldNumber = new System.Windows.Forms.Label();
            this.fieldMoney = new System.Windows.Forms.Label();
            this.collectionCards = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updateUsers = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.infoSQL = new System.Windows.Forms.Label();
            this.loadFileButton = new System.Windows.Forms.Label();
            this.loadFileWindow = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveFileButton = new System.Windows.Forms.Label();
            this.saveFileWindow = new System.Windows.Forms.Label();
            this.loadBackup = new System.Windows.Forms.Label();
            this.createBackup = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyUpdateButton = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Account.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.closeButton.Location = new System.Drawing.Point(698, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeButton.Size = new System.Drawing.Size(90, 59);
            this.closeButton.TabIndex = 2;
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
            this.Account.Location = new System.Drawing.Point(0, 71);
            this.Account.Name = "Account";
            this.Account.SelectedIndex = 0;
            this.Account.Size = new System.Drawing.Size(800, 529);
            this.Account.TabIndex = 3;
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
            this.tabPage1.Size = new System.Drawing.Size(792, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Редактор карт";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(356, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(428, 38);
            this.label15.TabIndex = 21;
            this.label15.Text = "*Здесь можно редактировать карты";
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
            this.update.Size = new System.Drawing.Size(342, 67);
            this.update.TabIndex = 3;
            this.update.Text = "Обновить";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelMax);
            this.panel1.Controls.Add(this.accountNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.updateValidity);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.fieldM);
            this.panel1.Controls.Add(this.fieldY);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.fieldNumber);
            this.panel1.Controls.Add(this.fieldMoney);
            this.panel1.Location = new System.Drawing.Point(356, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 319);
            this.panel1.TabIndex = 2;
            // 
            // labelMax
            // 
            this.labelMax.BackColor = System.Drawing.Color.Transparent;
            this.labelMax.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.labelMax.ForeColor = System.Drawing.Color.Red;
            this.labelMax.Location = new System.Drawing.Point(4, 179);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(252, 42);
            this.labelMax.TabIndex = 22;
            this.labelMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // accountNumber
            // 
            this.accountNumber.AutoSize = true;
            this.accountNumber.BackColor = System.Drawing.Color.GhostWhite;
            this.accountNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountNumber.Location = new System.Drawing.Point(169, 11);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Size = new System.Drawing.Size(2, 37);
            this.accountNumber.TabIndex = 25;
            this.accountNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 42);
            this.label2.TabIndex = 24;
            this.label2.Text = "Аккаунт №";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // updateValidity
            // 
            this.updateValidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.updateValidity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateValidity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateValidity.Location = new System.Drawing.Point(3, 231);
            this.updateValidity.Name = "updateValidity";
            this.updateValidity.Size = new System.Drawing.Size(222, 76);
            this.updateValidity.TabIndex = 23;
            this.updateValidity.Text = "Продлить срок действия карты";
            this.updateValidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateValidity.Click += new System.EventHandler(this.updateValidity_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Location = new System.Drawing.Point(231, 231);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(188, 76);
            this.delete.TabIndex = 22;
            this.delete.Text = "Удалить карту";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(327, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 35);
            this.label7.TabIndex = 3;
            this.label7.Text = "/";
            // 
            // fieldM
            // 
            this.fieldM.BackColor = System.Drawing.Color.OldLace;
            this.fieldM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldM.Location = new System.Drawing.Point(262, 179);
            this.fieldM.Name = "fieldM";
            this.fieldM.Size = new System.Drawing.Size(59, 42);
            this.fieldM.TabIndex = 7;
            this.fieldM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fieldY
            // 
            this.fieldY.BackColor = System.Drawing.Color.OldLace;
            this.fieldY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldY.Location = new System.Drawing.Point(360, 179);
            this.fieldY.Name = "fieldY";
            this.fieldY.Size = new System.Drawing.Size(59, 42);
            this.fieldY.TabIndex = 6;
            this.fieldY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.GhostWhite;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(365, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "Руб";
            // 
            // fieldNumber
            // 
            this.fieldNumber.BackColor = System.Drawing.Color.OldLace;
            this.fieldNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fieldNumber.Location = new System.Drawing.Point(3, 123);
            this.fieldNumber.Name = "fieldNumber";
            this.fieldNumber.Size = new System.Drawing.Size(416, 42);
            this.fieldNumber.TabIndex = 3;
            this.fieldNumber.Text = "* * * * * * * * * *";
            this.fieldNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fieldMoney
            // 
            this.fieldMoney.BackColor = System.Drawing.Color.GhostWhite;
            this.fieldMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fieldMoney.Location = new System.Drawing.Point(3, 71);
            this.fieldMoney.Name = "fieldMoney";
            this.fieldMoney.Size = new System.Drawing.Size(356, 42);
            this.fieldMoney.TabIndex = 2;
            this.fieldMoney.Text = "Выберите карту";
            this.fieldMoney.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // collectionCards
            // 
            this.collectionCards.BackColor = System.Drawing.Color.OldLace;
            this.collectionCards.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.collectionCards.FormattingEnabled = true;
            this.collectionCards.ItemHeight = 35;
            this.collectionCards.Location = new System.Drawing.Point(8, 115);
            this.collectionCards.Name = "collectionCards";
            this.collectionCards.Size = new System.Drawing.Size(342, 249);
            this.collectionCards.TabIndex = 1;
            this.collectionCards.SelectedIndexChanged += new System.EventHandler(this.collectionCards_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F);
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.updateUsers);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактор пользователей";
            // 
            // updateUsers
            // 
            this.updateUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.updateUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateUsers.Location = new System.Drawing.Point(8, 421);
            this.updateUsers.Name = "updateUsers";
            this.updateUsers.Size = new System.Drawing.Size(781, 55);
            this.updateUsers.TabIndex = 6;
            this.updateUsers.Text = "Обновить";
            this.updateUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateUsers.Click += new System.EventHandler(this.updateUsers_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column14,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(786, 415);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView2_CellValidating);
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.HeaderText = "Аккаунт";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 147;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Логин";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 160;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Номер паспорта";
            this.Column14.MinimumWidth = 8;
            this.Column14.Name = "Column14";
            this.Column14.Width = 200;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Имя";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 160;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Фамилия";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 160;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Отчество";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 160;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Дата рождения";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 160;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Номер";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.Width = 160;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Почта";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.Width = 160;
            // 
            // Column13
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.Column13.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column13.HeaderText = "Уроверь администратора";
            this.Column13.MinimumWidth = 8;
            this.Column13.Name = "Column13";
            this.Column13.Width = 150;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Moccasin;
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage3.Controls.Add(this.infoSQL);
            this.tabPage3.Controls.Add(this.loadFileButton);
            this.tabPage3.Controls.Add(this.loadFileWindow);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.saveFileButton);
            this.tabPage3.Controls.Add(this.saveFileWindow);
            this.tabPage3.Controls.Add(this.loadBackup);
            this.tabPage3.Controls.Add(this.createBackup);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Сохранение";
            // 
            // infoSQL
            // 
            this.infoSQL.BackColor = System.Drawing.Color.Transparent;
            this.infoSQL.Font = new System.Drawing.Font("Segoe Print", 18F);
            this.infoSQL.ForeColor = System.Drawing.Color.Indigo;
            this.infoSQL.Location = new System.Drawing.Point(39, 217);
            this.infoSQL.Name = "infoSQL";
            this.infoSQL.Size = new System.Drawing.Size(714, 57);
            this.infoSQL.TabIndex = 26;
            this.infoSQL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loadFileButton
            // 
            this.loadFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.loadFileButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadFileButton.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadFileButton.Location = new System.Drawing.Point(681, 346);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loadFileButton.Size = new System.Drawing.Size(73, 55);
            this.loadFileButton.TabIndex = 25;
            this.loadFileButton.Text = ". . .";
            this.loadFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // loadFileWindow
            // 
            this.loadFileWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.loadFileWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loadFileWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadFileWindow.Location = new System.Drawing.Point(40, 346);
            this.loadFileWindow.Name = "loadFileWindow";
            this.loadFileWindow.Size = new System.Drawing.Size(626, 55);
            this.loadFileWindow.TabIndex = 24;
            this.loadFileWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 20F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(40, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(714, 68);
            this.label8.TabIndex = 23;
            this.label8.Text = "Загрузка резервной копии";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 20F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(34, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(720, 68);
            this.label6.TabIndex = 22;
            this.label6.Text = "Создание резервной копии";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveFileButton
            // 
            this.saveFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.saveFileButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveFileButton.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFileButton.Location = new System.Drawing.Point(681, 88);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveFileButton.Size = new System.Drawing.Size(73, 55);
            this.saveFileButton.TabIndex = 10;
            this.saveFileButton.Text = ". . .";
            this.saveFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // saveFileWindow
            // 
            this.saveFileWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.saveFileWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.saveFileWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveFileWindow.Location = new System.Drawing.Point(40, 88);
            this.saveFileWindow.Name = "saveFileWindow";
            this.saveFileWindow.Size = new System.Drawing.Size(620, 55);
            this.saveFileWindow.TabIndex = 9;
            this.saveFileWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadBackup
            // 
            this.loadBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.loadBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadBackup.Location = new System.Drawing.Point(40, 411);
            this.loadBackup.Name = "loadBackup";
            this.loadBackup.Size = new System.Drawing.Size(714, 55);
            this.loadBackup.TabIndex = 8;
            this.loadBackup.Text = "Загрузка";
            this.loadBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadBackup.Click += new System.EventHandler(this.loadBackup_Click);
            // 
            // createBackup
            // 
            this.createBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.createBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBackup.Location = new System.Drawing.Point(40, 151);
            this.createBackup.Name = "createBackup";
            this.createBackup.Size = new System.Drawing.Size(714, 55);
            this.createBackup.TabIndex = 7;
            this.createBackup.Text = "Создание";
            this.createBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createBackup.Click += new System.EventHandler(this.createBackup_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.historyUpdateButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 481);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Операции ";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(8, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
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
            // historyUpdateButton
            // 
            this.historyUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.historyUpdateButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyUpdateButton.Location = new System.Drawing.Point(8, 410);
            this.historyUpdateButton.Name = "historyUpdateButton";
            this.historyUpdateButton.Size = new System.Drawing.Size(776, 55);
            this.historyUpdateButton.TabIndex = 5;
            this.historyUpdateButton.Text = "Обновить";
            this.historyUpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.historyUpdateButton.Click += new System.EventHandler(this.historyUpdateButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.closeButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Account.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.TabControl Account;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label updateValidity;
        private System.Windows.Forms.Label delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label fieldM;
        private System.Windows.Forms.Label fieldY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fieldNumber;
        private System.Windows.Forms.Label fieldMoney;
        private System.Windows.Forms.ListBox collectionCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label historyUpdateButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label accountNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label updateUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Label saveFileButton;
        private System.Windows.Forms.Label saveFileWindow;
        private System.Windows.Forms.Label loadBackup;
        private System.Windows.Forms.Label createBackup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label loadFileButton;
        private System.Windows.Forms.Label loadFileWindow;
        private System.Windows.Forms.Label infoSQL;
    }
}