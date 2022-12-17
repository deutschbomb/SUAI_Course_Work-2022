using System.Windows.Forms;

namespace ЛабРаб7
{
    partial class MyForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumberShow = new System.Windows.Forms.TextBox();
            this.AddPhone = new System.Windows.Forms.Button();
            this.ModelShow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PhonesLabel = new System.Windows.Forms.Label();
            this.ModelType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberType = new System.Windows.Forms.TextBox();
            this.DeniedButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.AddedPhoneList = new System.Windows.Forms.ListBox();
            this.Interface = new System.Windows.Forms.GroupBox();
            this.BalanceButton = new System.Windows.Forms.Button();
            this.SystemButton = new System.Windows.Forms.Button();
            this.PhotoButton = new System.Windows.Forms.Button();
            this.MessageButton = new System.Windows.Forms.Button();
            this.CallButton = new System.Windows.Forms.Button();
            this.simMenu = new System.Windows.Forms.GroupBox();
            this.simInfo = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Button();
            this.DepositButton = new System.Windows.Forms.Button();
            this.DepositType = new System.Windows.Forms.MaskedTextBox();
            this.PhotoMenu = new System.Windows.Forms.GroupBox();
            this.SystemMenu = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SystemInfo = new System.Windows.Forms.RichTextBox();
            this.MessageMenu = new System.Windows.Forms.GroupBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MessagesWindow = new System.Windows.Forms.RichTextBox();
            this.CallMenu = new System.Windows.Forms.GroupBox();
            this.userBalance = new System.Windows.Forms.MaskedTextBox();
            this.userNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userModel = new System.Windows.Forms.TextBox();
            this.CreationMenu = new System.Windows.Forms.GroupBox();
            this.ChooseType = new System.Windows.Forms.ComboBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.Interface.SuspendLayout();
            this.simMenu.SuspendLayout();
            this.SystemMenu.SuspendLayout();
            this.MessageMenu.SuspendLayout();
            this.CallMenu.SuspendLayout();
            this.CreationMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberShow
            // 
            this.NumberShow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NumberShow.Location = new System.Drawing.Point(15, 92);
            this.NumberShow.Name = "NumberShow";
            this.NumberShow.ReadOnly = true;
            this.NumberShow.Size = new System.Drawing.Size(201, 20);
            this.NumberShow.TabIndex = 49;
            this.NumberShow.TabStop = false;
            // 
            // AddPhone
            // 
            this.AddPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPhone.Location = new System.Drawing.Point(27, 114);
            this.AddPhone.Name = "AddPhone";
            this.AddPhone.Size = new System.Drawing.Size(178, 44);
            this.AddPhone.TabIndex = 43;
            this.AddPhone.Text = "Добавить";
            this.AddPhone.UseVisualStyleBackColor = true;
            this.AddPhone.Click += new System.EventHandler(this.AddPhone_Click);
            // 
            // ModelShow
            // 
            this.ModelShow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModelShow.Location = new System.Drawing.Point(15, 45);
            this.ModelShow.Name = "ModelShow";
            this.ModelShow.ReadOnly = true;
            this.ModelShow.Size = new System.Drawing.Size(201, 20);
            this.ModelShow.TabIndex = 48;
            this.ModelShow.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Номер входящего телефона:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Модель входящего телефона:";
            // 
            // PhonesLabel
            // 
            this.PhonesLabel.AutoSize = true;
            this.PhonesLabel.Location = new System.Drawing.Point(12, 183);
            this.PhonesLabel.Name = "PhonesLabel";
            this.PhonesLabel.Size = new System.Drawing.Size(63, 13);
            this.PhonesLabel.TabIndex = 45;
            this.PhonesLabel.Text = "Телефоны:";
            // 
            // ModelType
            // 
            this.ModelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.ModelType.ForeColor = System.Drawing.Color.DimGray;
            this.ModelType.Location = new System.Drawing.Point(12, 26);
            this.ModelType.Name = "ModelType";
            this.ModelType.Size = new System.Drawing.Size(201, 20);
            this.ModelType.TabIndex = 40;
            this.ModelType.Text = "iPhonk 69 или Pasasonic";
            this.ModelType.Enter += new System.EventHandler(this.ModelType_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Введите номер телефона:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Введите модель телефона:";
            // 
            // NumberType
            // 
            this.NumberType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NumberType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.NumberType.ForeColor = System.Drawing.Color.DimGray;
            this.NumberType.Location = new System.Drawing.Point(12, 73);
            this.NumberType.Name = "NumberType";
            this.NumberType.Size = new System.Drawing.Size(201, 20);
            this.NumberType.TabIndex = 42;
            this.NumberType.Text = "12-34-56 или 8(800)555-35-35";
            this.NumberType.Enter += new System.EventHandler(this.NumberType_Enter);
            // 
            // DeniedButton
            // 
            this.DeniedButton.BackColor = System.Drawing.Color.Transparent;
            this.DeniedButton.BackgroundImage = global::ЛабРаб7.Properties.Resources.denied;
            this.DeniedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeniedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeniedButton.Location = new System.Drawing.Point(123, 137);
            this.DeniedButton.Name = "DeniedButton";
            this.DeniedButton.Size = new System.Drawing.Size(80, 80);
            this.DeniedButton.TabIndex = 50;
            this.DeniedButton.UseVisualStyleBackColor = false;
            this.DeniedButton.Click += new System.EventHandler(this.DeniedButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.Transparent;
            this.AcceptButton.BackgroundImage = global::ЛабРаб7.Properties.Resources.accept;
            this.AcceptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AcceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptButton.Location = new System.Drawing.Point(27, 137);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(80, 80);
            this.AcceptButton.TabIndex = 51;
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // AddedPhoneList
            // 
            this.AddedPhoneList.FormattingEnabled = true;
            this.AddedPhoneList.Location = new System.Drawing.Point(12, 199);
            this.AddedPhoneList.Name = "AddedPhoneList";
            this.AddedPhoneList.Size = new System.Drawing.Size(201, 251);
            this.AddedPhoneList.TabIndex = 39;
            // 
            // Interface
            // 
            this.Interface.Controls.Add(this.BalanceButton);
            this.Interface.Controls.Add(this.SystemButton);
            this.Interface.Controls.Add(this.PhotoButton);
            this.Interface.Controls.Add(this.MessageButton);
            this.Interface.Controls.Add(this.CallButton);
            this.Interface.Controls.Add(this.simMenu);
            this.Interface.Controls.Add(this.PhotoMenu);
            this.Interface.Controls.Add(this.SystemMenu);
            this.Interface.Controls.Add(this.MessageMenu);
            this.Interface.Controls.Add(this.CallMenu);
            this.Interface.Location = new System.Drawing.Point(228, 9);
            this.Interface.Name = "Interface";
            this.Interface.Size = new System.Drawing.Size(444, 441);
            this.Interface.TabIndex = 52;
            this.Interface.TabStop = false;
            this.Interface.Text = "Интерфейс";
            // 
            // BalanceButton
            // 
            this.BalanceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BalanceButton.Location = new System.Drawing.Point(15, 375);
            this.BalanceButton.Name = "BalanceButton";
            this.BalanceButton.Size = new System.Drawing.Size(175, 45);
            this.BalanceButton.TabIndex = 43;
            this.BalanceButton.Text = "Баланс СИМ-карты:";
            this.BalanceButton.UseVisualStyleBackColor = true;
            this.BalanceButton.Click += new System.EventHandler(this.BalanceButton_Click);
            // 
            // SystemButton
            // 
            this.SystemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SystemButton.Location = new System.Drawing.Point(15, 194);
            this.SystemButton.Name = "SystemButton";
            this.SystemButton.Size = new System.Drawing.Size(175, 45);
            this.SystemButton.TabIndex = 43;
            this.SystemButton.Text = "Система";
            this.SystemButton.UseVisualStyleBackColor = true;
            this.SystemButton.Click += new System.EventHandler(this.SystemButton_Click);
            // 
            // PhotoButton
            // 
            this.PhotoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhotoButton.Location = new System.Drawing.Point(15, 140);
            this.PhotoButton.Name = "PhotoButton";
            this.PhotoButton.Size = new System.Drawing.Size(175, 45);
            this.PhotoButton.TabIndex = 43;
            this.PhotoButton.Text = "Фотографии";
            this.PhotoButton.UseVisualStyleBackColor = true;
            this.PhotoButton.Click += new System.EventHandler(this.PhotoButton_Click);
            // 
            // MessageButton
            // 
            this.MessageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MessageButton.Location = new System.Drawing.Point(15, 86);
            this.MessageButton.Name = "MessageButton";
            this.MessageButton.Size = new System.Drawing.Size(175, 45);
            this.MessageButton.TabIndex = 43;
            this.MessageButton.Text = "Сообщение";
            this.MessageButton.UseVisualStyleBackColor = true;
            this.MessageButton.Click += new System.EventHandler(this.MessageButton_Click);
            // 
            // CallButton
            // 
            this.CallButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CallButton.Location = new System.Drawing.Point(15, 32);
            this.CallButton.Name = "CallButton";
            this.CallButton.Size = new System.Drawing.Size(175, 45);
            this.CallButton.TabIndex = 43;
            this.CallButton.Text = "Звонок";
            this.CallButton.UseVisualStyleBackColor = true;
            this.CallButton.Click += new System.EventHandler(this.CallButton_Click);
            // 
            // simMenu
            // 
            this.simMenu.Controls.Add(this.simInfo);
            this.simMenu.Controls.Add(this.label11);
            this.simMenu.Controls.Add(this.label10);
            this.simMenu.Controls.Add(this.InfoButton);
            this.simMenu.Controls.Add(this.DepositButton);
            this.simMenu.Controls.Add(this.DepositType);
            this.simMenu.Location = new System.Drawing.Point(205, 19);
            this.simMenu.Name = "simMenu";
            this.simMenu.Size = new System.Drawing.Size(232, 416);
            this.simMenu.TabIndex = 54;
            this.simMenu.TabStop = false;
            this.simMenu.Text = "СИМ-карта";
            // 
            // simInfo
            // 
            this.simInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.simInfo.Location = new System.Drawing.Point(12, 150);
            this.simInfo.Name = "simInfo";
            this.simInfo.ReadOnly = true;
            this.simInfo.Size = new System.Drawing.Size(201, 260);
            this.simInfo.TabIndex = 53;
            this.simInfo.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Информация о СИМ-карте:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Введите сумму пополнения:";
            // 
            // InfoButton
            // 
            this.InfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoButton.Location = new System.Drawing.Point(113, 71);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(92, 45);
            this.InfoButton.TabIndex = 43;
            this.InfoButton.Text = "Информация";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // DepositButton
            // 
            this.DepositButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DepositButton.Location = new System.Drawing.Point(15, 71);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(92, 45);
            this.DepositButton.TabIndex = 43;
            this.DepositButton.Text = "Пополнить";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // DepositType
            // 
            this.DepositType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.DepositType.ForeColor = System.Drawing.Color.DimGray;
            this.DepositType.Location = new System.Drawing.Point(12, 39);
            this.DepositType.Mask = "000 р.";
            this.DepositType.Name = "DepositType";
            this.DepositType.Size = new System.Drawing.Size(201, 20);
            this.DepositType.TabIndex = 52;
            this.DepositType.Enter += new System.EventHandler(this.DepositType_Enter);
            // 
            // PhotoMenu
            // 
            this.PhotoMenu.Location = new System.Drawing.Point(205, 19);
            this.PhotoMenu.Name = "PhotoMenu";
            this.PhotoMenu.Size = new System.Drawing.Size(232, 416);
            this.PhotoMenu.TabIndex = 53;
            this.PhotoMenu.TabStop = false;
            this.PhotoMenu.Text = "Фотографии";
            // 
            // SystemMenu
            // 
            this.SystemMenu.Controls.Add(this.label9);
            this.SystemMenu.Controls.Add(this.SystemInfo);
            this.SystemMenu.Location = new System.Drawing.Point(205, 19);
            this.SystemMenu.Name = "SystemMenu";
            this.SystemMenu.Size = new System.Drawing.Size(232, 416);
            this.SystemMenu.TabIndex = 52;
            this.SystemMenu.TabStop = false;
            this.SystemMenu.Text = "Система";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Информация о системе:";
            // 
            // SystemInfo
            // 
            this.SystemInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SystemInfo.Location = new System.Drawing.Point(7, 40);
            this.SystemInfo.Name = "SystemInfo";
            this.SystemInfo.ReadOnly = true;
            this.SystemInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.SystemInfo.Size = new System.Drawing.Size(219, 370);
            this.SystemInfo.TabIndex = 0;
            this.SystemInfo.Text = "";
            // 
            // MessageMenu
            // 
            this.MessageMenu.Controls.Add(this.SendButton);
            this.MessageMenu.Controls.Add(this.Message);
            this.MessageMenu.Controls.Add(this.label8);
            this.MessageMenu.Controls.Add(this.MessagesWindow);
            this.MessageMenu.Location = new System.Drawing.Point(205, 19);
            this.MessageMenu.Name = "MessageMenu";
            this.MessageMenu.Size = new System.Drawing.Size(232, 416);
            this.MessageMenu.TabIndex = 52;
            this.MessageMenu.TabStop = false;
            this.MessageMenu.Text = "Сообщение";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(27, 53);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(176, 43);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.Message.ForeColor = System.Drawing.Color.DimGray;
            this.Message.Location = new System.Drawing.Point(15, 22);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(211, 20);
            this.Message.TabIndex = 1;
            this.Message.Text = "Сообщение...";
            this.Message.Enter += new System.EventHandler(this.MessageType_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Сообщения:";
            // 
            // MessagesWindow
            // 
            this.MessagesWindow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MessagesWindow.Location = new System.Drawing.Point(7, 137);
            this.MessagesWindow.Name = "MessagesWindow";
            this.MessagesWindow.ReadOnly = true;
            this.MessagesWindow.Size = new System.Drawing.Size(219, 273);
            this.MessagesWindow.TabIndex = 0;
            this.MessagesWindow.Text = "";
            // 
            // CallMenu
            // 
            this.CallMenu.Controls.Add(this.label3);
            this.CallMenu.Controls.Add(this.label4);
            this.CallMenu.Controls.Add(this.ModelShow);
            this.CallMenu.Controls.Add(this.NumberShow);
            this.CallMenu.Controls.Add(this.DeniedButton);
            this.CallMenu.Controls.Add(this.AcceptButton);
            this.CallMenu.Location = new System.Drawing.Point(205, 19);
            this.CallMenu.Name = "CallMenu";
            this.CallMenu.Size = new System.Drawing.Size(232, 416);
            this.CallMenu.TabIndex = 52;
            this.CallMenu.TabStop = false;
            this.CallMenu.Text = "Звонок";
            // 
            // userBalance
            // 
            this.userBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.userBalance.ForeColor = System.Drawing.Color.DimGray;
            this.userBalance.Location = new System.Drawing.Point(9, 180);
            this.userBalance.Mask = "000 р.";
            this.userBalance.Name = "userBalance";
            this.userBalance.Size = new System.Drawing.Size(201, 20);
            this.userBalance.TabIndex = 49;
            this.userBalance.Enter += new System.EventHandler(this.userBalance_Enter);
            // 
            // userNumber
            // 
            this.userNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.userNumber.ForeColor = System.Drawing.Color.DimGray;
            this.userNumber.Location = new System.Drawing.Point(9, 131);
            this.userNumber.Name = "userNumber";
            this.userNumber.Size = new System.Drawing.Size(201, 20);
            this.userNumber.TabIndex = 47;
            this.userNumber.Text = "Например: 88005553535";
            this.userNumber.Enter += new System.EventHandler(this.userNumber_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Введите модель телефона:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Введите баланс телефона:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Введите номер телефона:";
            // 
            // userModel
            // 
            this.userModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.userModel.ForeColor = System.Drawing.Color.DimGray;
            this.userModel.Location = new System.Drawing.Point(9, 84);
            this.userModel.Name = "userModel";
            this.userModel.Size = new System.Drawing.Size(201, 20);
            this.userModel.TabIndex = 45;
            this.userModel.Text = "Например: Nokia 3310";
            this.userModel.Enter += new System.EventHandler(this.userModel_Enter);
            // 
            // CreationMenu
            // 
            this.CreationMenu.Controls.Add(this.ChooseType);
            this.CreationMenu.Controls.Add(this.userModel);
            this.CreationMenu.Controls.Add(this.label5);
            this.CreationMenu.Controls.Add(this.label7);
            this.CreationMenu.Controls.Add(this.label6);
            this.CreationMenu.Controls.Add(this.CreateButton);
            this.CreationMenu.Controls.Add(this.userNumber);
            this.CreationMenu.Controls.Add(this.userBalance);
            this.CreationMenu.Location = new System.Drawing.Point(12, 9);
            this.CreationMenu.Name = "CreationMenu";
            this.CreationMenu.Size = new System.Drawing.Size(225, 441);
            this.CreationMenu.TabIndex = 53;
            this.CreationMenu.TabStop = false;
            this.CreationMenu.Text = "Создание телефона";
            // 
            // ChooseType
            // 
            this.ChooseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseType.FormattingEnabled = true;
            this.ChooseType.Items.AddRange(new object[] {
            "Стационарный",
            "Мобильный"});
            this.ChooseType.Location = new System.Drawing.Point(9, 29);
            this.ChooseType.Name = "ChooseType";
            this.ChooseType.Size = new System.Drawing.Size(201, 21);
            this.ChooseType.TabIndex = 50;
            this.ChooseType.SelectedValueChanged += new System.EventHandler(this.ChooseType_SelectedValueChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateButton.Location = new System.Drawing.Point(20, 375);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(175, 45);
            this.CreateButton.TabIndex = 43;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 462);
            this.Controls.Add(this.CreationMenu);
            this.Controls.Add(this.Interface);
            this.Controls.Add(this.AddPhone);
            this.Controls.Add(this.PhonesLabel);
            this.Controls.Add(this.ModelType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberType);
            this.Controls.Add(this.AddedPhoneList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание телефона";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.Interface.ResumeLayout(false);
            this.simMenu.ResumeLayout(false);
            this.simMenu.PerformLayout();
            this.SystemMenu.ResumeLayout(false);
            this.SystemMenu.PerformLayout();
            this.MessageMenu.ResumeLayout(false);
            this.MessageMenu.PerformLayout();
            this.CallMenu.ResumeLayout(false);
            this.CallMenu.PerformLayout();
            this.CreationMenu.ResumeLayout(false);
            this.CreationMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private TextBox NumberShow;
        private Button AddPhone;
        private TextBox ModelShow;
        private Label label4;
        private Label label3;
        private Label PhonesLabel;
        private TextBox ModelType;
        private Label label2;
        private Label label1;
        private TextBox NumberType;
        private Button DeniedButton;
        private Button AcceptButton;
        private ListBox AddedPhoneList;
        private GroupBox Interface;
        private Button CallButton;
        private GroupBox CallMenu;
        private Button SystemButton;
        private Button PhotoButton;
        private Button MessageButton;
        private MaskedTextBox userBalance;
        private TextBox userNumber;
        private Label label6;
        private Label label7;
        private Label label5;
        private TextBox userModel;
        private GroupBox CreationMenu;
        private GroupBox MessageMenu;
        private RichTextBox MessagesWindow;
        private Label label8;
        private GroupBox SystemMenu;
        private Label label9;
        private RichTextBox SystemInfo;
        private ComboBox ChooseType;
        private Button CreateButton;
        private Button BalanceButton;
        private Button SendButton;
        private TextBox Message;
        private GroupBox PhotoMenu;
        private GroupBox simMenu;
        private Label label10;
        private MaskedTextBox DepositType;
        private Button DepositButton;
        private Button InfoButton;
        private RichTextBox simInfo;
        private Label label11;
    }
}

