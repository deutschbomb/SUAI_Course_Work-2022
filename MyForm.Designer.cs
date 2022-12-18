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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.NumberShow = new System.Windows.Forms.TextBox();
            this.AddPhone = new System.Windows.Forms.Button();
            this.ModelShow = new System.Windows.Forms.TextBox();
            this.Номер_входящего_телефона_ = new System.Windows.Forms.Label();
            this.Модель_входящего_телефона_ = new System.Windows.Forms.Label();
            this.Телефоны_ = new System.Windows.Forms.Label();
            this.ModelType = new System.Windows.Forms.TextBox();
            this.NumberType = new System.Windows.Forms.TextBox();
            this.AddedPhoneList = new System.Windows.Forms.ListBox();
            this.Interface = new System.Windows.Forms.GroupBox();
            this.simButton = new System.Windows.Forms.Button();
            this.SystemButton = new System.Windows.Forms.Button();
            this.PhotoButton = new System.Windows.Forms.Button();
            this.MessageButton = new System.Windows.Forms.Button();
            this.CallButton = new System.Windows.Forms.Button();
            this.MessageMenu = new System.Windows.Forms.GroupBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.Входящие_ = new System.Windows.Forms.Label();
            this.MessagesWindow = new System.Windows.Forms.RichTextBox();
            this.CallMenu = new System.Windows.Forms.GroupBox();
            this.DeniedButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.simMenu = new System.Windows.Forms.GroupBox();
            this.simInfo = new System.Windows.Forms.RichTextBox();
            this.Информация_о_СИМ_карте_ = new System.Windows.Forms.Label();
            this.Введите_сумму_пополнения_ = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Button();
            this.DepositButton = new System.Windows.Forms.Button();
            this.DepositType = new System.Windows.Forms.MaskedTextBox();
            this.PhotoMenu = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SystemMenu = new System.Windows.Forms.GroupBox();
            this.Информация_о_системе_ = new System.Windows.Forms.Label();
            this.SystemInfo = new System.Windows.Forms.RichTextBox();
            this.userBalance = new System.Windows.Forms.MaskedTextBox();
            this.userNumber = new System.Windows.Forms.TextBox();
            this.Введите_модель_телефона_ = new System.Windows.Forms.Label();
            this.Введите_баланс_телефона_ = new System.Windows.Forms.Label();
            this.Введите_номер_телефона_ = new System.Windows.Forms.Label();
            this.userModel = new System.Windows.Forms.TextBox();
            this.CreationMenu = new System.Windows.Forms.GroupBox();
            this.ChooseType = new System.Windows.Forms.ComboBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.Interface.SuspendLayout();
            this.MessageMenu.SuspendLayout();
            this.CallMenu.SuspendLayout();
            this.simMenu.SuspendLayout();
            this.PhotoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SystemMenu.SuspendLayout();
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
            this.AddPhone.BackColor = System.Drawing.Color.AliceBlue;
            this.AddPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPhone.Location = new System.Drawing.Point(27, 114);
            this.AddPhone.Name = "AddPhone";
            this.AddPhone.Size = new System.Drawing.Size(178, 44);
            this.AddPhone.TabIndex = 43;
            this.AddPhone.Text = "Добавить";
            this.AddPhone.UseVisualStyleBackColor = false;
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
            // Номер_входящего_телефона_
            // 
            this.Номер_входящего_телефона_.AutoSize = true;
            this.Номер_входящего_телефона_.Location = new System.Drawing.Point(15, 76);
            this.Номер_входящего_телефона_.Name = "Номер_входящего_телефона_";
            this.Номер_входящего_телефона_.Size = new System.Drawing.Size(154, 13);
            this.Номер_входящего_телефона_.TabIndex = 47;
            this.Номер_входящего_телефона_.Text = "Номер входящего телефона:";
            // 
            // Модель_входящего_телефона_
            // 
            this.Модель_входящего_телефона_.AutoSize = true;
            this.Модель_входящего_телефона_.Location = new System.Drawing.Point(15, 29);
            this.Модель_входящего_телефона_.Name = "Модель_входящего_телефона_";
            this.Модель_входящего_телефона_.Size = new System.Drawing.Size(159, 13);
            this.Модель_входящего_телефона_.TabIndex = 46;
            this.Модель_входящего_телефона_.Text = "Модель входящего телефона:";
            // 
            // Телефоны_
            // 
            this.Телефоны_.AutoSize = true;
            this.Телефоны_.Location = new System.Drawing.Point(12, 183);
            this.Телефоны_.Name = "Телефоны_";
            this.Телефоны_.Size = new System.Drawing.Size(63, 13);
            this.Телефоны_.TabIndex = 45;
            this.Телефоны_.Text = "Телефоны:";
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
            this.Interface.Controls.Add(this.simButton);
            this.Interface.Controls.Add(this.SystemButton);
            this.Interface.Controls.Add(this.PhotoButton);
            this.Interface.Controls.Add(this.MessageButton);
            this.Interface.Controls.Add(this.CallButton);
            this.Interface.Controls.Add(this.PhotoMenu);
            this.Interface.Controls.Add(this.SystemMenu);
            this.Interface.Controls.Add(this.MessageMenu);
            this.Interface.Controls.Add(this.CallMenu);
            this.Interface.Controls.Add(this.simMenu);
            this.Interface.Location = new System.Drawing.Point(228, 9);
            this.Interface.Name = "Interface";
            this.Interface.Size = new System.Drawing.Size(444, 441);
            this.Interface.TabIndex = 52;
            this.Interface.TabStop = false;
            this.Interface.Text = "Интерфейс";
            // 
            // simButton
            // 
            this.simButton.BackColor = System.Drawing.Color.Ivory;
            this.simButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simButton.Location = new System.Drawing.Point(15, 375);
            this.simButton.Name = "simButton";
            this.simButton.Size = new System.Drawing.Size(175, 45);
            this.simButton.TabIndex = 43;
            this.simButton.Text = "О СИМ-карте:";
            this.simButton.UseVisualStyleBackColor = false;
            this.simButton.Click += new System.EventHandler(this.BalanceButton_Click);
            // 
            // SystemButton
            // 
            this.SystemButton.BackColor = System.Drawing.Color.Ivory;
            this.SystemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SystemButton.Location = new System.Drawing.Point(15, 194);
            this.SystemButton.Name = "SystemButton";
            this.SystemButton.Size = new System.Drawing.Size(175, 45);
            this.SystemButton.TabIndex = 43;
            this.SystemButton.Text = "Система";
            this.SystemButton.UseVisualStyleBackColor = false;
            this.SystemButton.Click += new System.EventHandler(this.SystemButton_Click);
            // 
            // PhotoButton
            // 
            this.PhotoButton.BackColor = System.Drawing.Color.AliceBlue;
            this.PhotoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhotoButton.Location = new System.Drawing.Point(15, 140);
            this.PhotoButton.Name = "PhotoButton";
            this.PhotoButton.Size = new System.Drawing.Size(175, 45);
            this.PhotoButton.TabIndex = 43;
            this.PhotoButton.Text = "Фотографии";
            this.PhotoButton.UseVisualStyleBackColor = false;
            this.PhotoButton.Click += new System.EventHandler(this.PhotoButton_Click);
            // 
            // MessageButton
            // 
            this.MessageButton.BackColor = System.Drawing.Color.Honeydew;
            this.MessageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MessageButton.Location = new System.Drawing.Point(15, 86);
            this.MessageButton.Name = "MessageButton";
            this.MessageButton.Size = new System.Drawing.Size(175, 45);
            this.MessageButton.TabIndex = 43;
            this.MessageButton.Text = "Сообщение";
            this.MessageButton.UseVisualStyleBackColor = false;
            this.MessageButton.Click += new System.EventHandler(this.MessageButton_Click);
            // 
            // CallButton
            // 
            this.CallButton.BackColor = System.Drawing.Color.Honeydew;
            this.CallButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CallButton.Location = new System.Drawing.Point(15, 32);
            this.CallButton.Name = "CallButton";
            this.CallButton.Size = new System.Drawing.Size(175, 45);
            this.CallButton.TabIndex = 43;
            this.CallButton.Text = "Звонок";
            this.CallButton.UseVisualStyleBackColor = false;
            this.CallButton.Click += new System.EventHandler(this.CallButton_Click);
            // 
            // MessageMenu
            // 
            this.MessageMenu.Controls.Add(this.SendButton);
            this.MessageMenu.Controls.Add(this.Message);
            this.MessageMenu.Controls.Add(this.Входящие_);
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
            this.SendButton.BackColor = System.Drawing.Color.Honeydew;
            this.SendButton.Location = new System.Drawing.Point(27, 53);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(176, 43);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = false;
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
            // Входящие_
            // 
            this.Входящие_.AutoSize = true;
            this.Входящие_.Location = new System.Drawing.Point(12, 121);
            this.Входящие_.Name = "Входящие_";
            this.Входящие_.Size = new System.Drawing.Size(61, 13);
            this.Входящие_.TabIndex = 45;
            this.Входящие_.Text = "Входящие:";
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
            this.CallMenu.Controls.Add(this.Модель_входящего_телефона_);
            this.CallMenu.Controls.Add(this.Номер_входящего_телефона_);
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
            // DeniedButton
            // 
            this.DeniedButton.BackColor = System.Drawing.Color.Transparent;
            this.DeniedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeniedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeniedButton.Image = global::Телефон.Properties.Resources.denied;
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
            this.AcceptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AcceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptButton.Image = global::Телефон.Properties.Resources.accept;
            this.AcceptButton.Location = new System.Drawing.Point(27, 137);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(80, 80);
            this.AcceptButton.TabIndex = 51;
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // simMenu
            // 
            this.simMenu.Controls.Add(this.simInfo);
            this.simMenu.Controls.Add(this.Информация_о_СИМ_карте_);
            this.simMenu.Controls.Add(this.Введите_сумму_пополнения_);
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
            // Информация_о_СИМ_карте_
            // 
            this.Информация_о_СИМ_карте_.AutoSize = true;
            this.Информация_о_СИМ_карте_.Location = new System.Drawing.Point(12, 134);
            this.Информация_о_СИМ_карте_.Name = "Информация_о_СИМ_карте_";
            this.Информация_о_СИМ_карте_.Size = new System.Drawing.Size(144, 13);
            this.Информация_о_СИМ_карте_.TabIndex = 51;
            this.Информация_о_СИМ_карте_.Text = "Информация о СИМ-карте:";
            // 
            // Введите_сумму_пополнения_
            // 
            this.Введите_сумму_пополнения_.AutoSize = true;
            this.Введите_сумму_пополнения_.Location = new System.Drawing.Point(12, 22);
            this.Введите_сумму_пополнения_.Name = "Введите_сумму_пополнения_";
            this.Введите_сумму_пополнения_.Size = new System.Drawing.Size(150, 13);
            this.Введите_сумму_пополнения_.TabIndex = 51;
            this.Введите_сумму_пополнения_.Text = "Введите сумму пополнения:";
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.Ivory;
            this.InfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoButton.Location = new System.Drawing.Point(113, 71);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(92, 45);
            this.InfoButton.TabIndex = 43;
            this.InfoButton.Text = "Информация";
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // DepositButton
            // 
            this.DepositButton.BackColor = System.Drawing.Color.GhostWhite;
            this.DepositButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DepositButton.Location = new System.Drawing.Point(15, 71);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(92, 45);
            this.DepositButton.TabIndex = 43;
            this.DepositButton.Text = "Пополнить";
            this.DepositButton.UseVisualStyleBackColor = false;
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
            this.PhotoMenu.Controls.Add(this.pictureBox3);
            this.PhotoMenu.Controls.Add(this.pictureBox2);
            this.PhotoMenu.Controls.Add(this.pictureBox1);
            this.PhotoMenu.Location = new System.Drawing.Point(205, 19);
            this.PhotoMenu.Name = "PhotoMenu";
            this.PhotoMenu.Size = new System.Drawing.Size(232, 416);
            this.PhotoMenu.TabIndex = 53;
            this.PhotoMenu.TabStop = false;
            this.PhotoMenu.Text = "Фотографии";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Телефон.Properties.Resources.Tulips;
            this.pictureBox3.Location = new System.Drawing.Point(18, 283);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(198, 118);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Телефон.Properties.Resources.Penguins;
            this.pictureBox2.Location = new System.Drawing.Point(18, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Телефон.Properties.Resources.Hydrangeas;
            this.pictureBox1.Location = new System.Drawing.Point(18, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SystemMenu
            // 
            this.SystemMenu.Controls.Add(this.Информация_о_системе_);
            this.SystemMenu.Controls.Add(this.SystemInfo);
            this.SystemMenu.Location = new System.Drawing.Point(205, 19);
            this.SystemMenu.Name = "SystemMenu";
            this.SystemMenu.Size = new System.Drawing.Size(232, 416);
            this.SystemMenu.TabIndex = 52;
            this.SystemMenu.TabStop = false;
            this.SystemMenu.Text = "Система";
            // 
            // Информация_о_системе_
            // 
            this.Информация_о_системе_.AutoSize = true;
            this.Информация_о_системе_.Location = new System.Drawing.Point(12, 24);
            this.Информация_о_системе_.Name = "Информация_о_системе_";
            this.Информация_о_системе_.Size = new System.Drawing.Size(131, 13);
            this.Информация_о_системе_.TabIndex = 45;
            this.Информация_о_системе_.Text = "Информация о системе:";
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
            // Введите_модель_телефона_
            // 
            this.Введите_модель_телефона_.AutoSize = true;
            this.Введите_модель_телефона_.Location = new System.Drawing.Point(9, 67);
            this.Введите_модель_телефона_.Name = "Введите_модель_телефона_";
            this.Введите_модель_телефона_.Size = new System.Drawing.Size(145, 13);
            this.Введите_модель_телефона_.TabIndex = 46;
            this.Введите_модель_телефона_.Text = "Введите модель телефона:";
            // 
            // Введите_баланс_телефона_
            // 
            this.Введите_баланс_телефона_.AutoSize = true;
            this.Введите_баланс_телефона_.Location = new System.Drawing.Point(9, 163);
            this.Введите_баланс_телефона_.Name = "Введите_баланс_телефона_";
            this.Введите_баланс_телефона_.Size = new System.Drawing.Size(143, 13);
            this.Введите_баланс_телефона_.TabIndex = 46;
            this.Введите_баланс_телефона_.Text = "Введите баланс телефона:";
            // 
            // Введите_номер_телефона_
            // 
            this.Введите_номер_телефона_.AutoSize = true;
            this.Введите_номер_телефона_.Location = new System.Drawing.Point(9, 115);
            this.Введите_номер_телефона_.Name = "Введите_номер_телефона_";
            this.Введите_номер_телефона_.Size = new System.Drawing.Size(139, 13);
            this.Введите_номер_телефона_.TabIndex = 48;
            this.Введите_номер_телефона_.Text = "Введите номер телефона:";
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
            this.CreationMenu.BackColor = System.Drawing.SystemColors.Control;
            this.CreationMenu.Controls.Add(this.ChooseType);
            this.CreationMenu.Controls.Add(this.userModel);
            this.CreationMenu.Controls.Add(this.Введите_номер_телефона_);
            this.CreationMenu.Controls.Add(this.Введите_баланс_телефона_);
            this.CreationMenu.Controls.Add(this.Введите_модель_телефона_);
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
            this.ChooseType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChooseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ChooseType.FormattingEnabled = true;
            this.ChooseType.Items.AddRange(new object[] {
            "Стационарный",
            "Мобильный"});
            this.ChooseType.Location = new System.Drawing.Point(9, 29);
            this.ChooseType.Name = "ChooseType";
            this.ChooseType.Size = new System.Drawing.Size(201, 21);
            this.ChooseType.TabIndex = 50;
            this.ChooseType.Visible = false;
            //this.ChooseType.SelectedValueChanged += new System.EventHandler(this.ChooseType_SelectedValueChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.GhostWhite;
            this.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateButton.Location = new System.Drawing.Point(20, 375);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(175, 45);
            this.CreateButton.TabIndex = 43;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.Телефоны_);
            this.Controls.Add(this.ModelType);
            this.Controls.Add(this.NumberType);
            this.Controls.Add(this.AddedPhoneList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.Interface.ResumeLayout(false);
            this.MessageMenu.ResumeLayout(false);
            this.MessageMenu.PerformLayout();
            this.CallMenu.ResumeLayout(false);
            this.CallMenu.PerformLayout();
            this.simMenu.ResumeLayout(false);
            this.simMenu.PerformLayout();
            this.PhotoMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SystemMenu.ResumeLayout(false);
            this.SystemMenu.PerformLayout();
            this.CreationMenu.ResumeLayout(false);
            this.CreationMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private TextBox NumberShow;
        private Button AddPhone;
        private TextBox ModelShow;
        private Label Номер_входящего_телефона_;
        private Label Модель_входящего_телефона_;
        private Label Телефоны_;
        private TextBox ModelType;
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
        private Label Введите_модель_телефона_;
        private Label Введите_баланс_телефона_;
        private Label Введите_номер_телефона_;
        private TextBox userModel;
        private GroupBox CreationMenu;
        private GroupBox MessageMenu;
        private RichTextBox MessagesWindow;
        private Label Входящие_;
        private GroupBox SystemMenu;
        private Label Информация_о_системе_;
        private RichTextBox SystemInfo;
        private ComboBox ChooseType;
        private Button CreateButton;
        private Button simButton;
        private Button SendButton;
        private TextBox Message;
        private GroupBox PhotoMenu;
        private GroupBox simMenu;
        private Label Введите_сумму_пополнения_;
        private MaskedTextBox DepositType;
        private Button DepositButton;
        private Button InfoButton;
        private RichTextBox simInfo;
        private Label Информация_о_СИМ_карте_;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}

