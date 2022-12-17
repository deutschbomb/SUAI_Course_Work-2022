using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Phones_Base;

namespace ЛабРаб7
{
    public partial class MyForm : Form
    {
        Mobile userPhone; int SelectedPhone;

        List<Phone> PhonesList = new List<Phone>{ new Landline("Paralitic 404", "331100"),
            new Mobile("Cockia 1488", 100, "89003221337"), new Landline("Horny", "123456"),
            new Mobile("Glory H01", 100, "89001137777") };

        List<Mobile> mobilesList = new List<Mobile> { }; List<Landline> landsList = new List<Landline> { };

        Random random = new Random();
        GraphicsPath GP = new GraphicsPath();

        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            GP.AddEllipse(new Rectangle(5, 4, 71, 71));

            AddedPhoneList.DataSource = null;
            AddedPhoneList.DataSource = PhonesList;
            AddedPhoneList.DisplayMember = "Number";

            AcceptButton.Region = new Region(GP);
            DeniedButton.Region = new Region(GP);

            CallMenu.Hide(); MessageMenu.Hide(); SystemMenu.Hide();
            label7.Hide(); userBalance.Hide();
            Interface.Hide();
            DeniedButton.Hide();
            this.ClientSize = new System.Drawing.Size(244, 462);
        }

        #region Функции управления
        public static void CallMessage(object sender, NotificationEventArgs e)
        {
            if (e.Number == null)
                MessageBox.Show($"{e.Message}");
            else
                MessageBox.Show($"{e.Number}\n{e.Message}");
        }
        private void ModelType_Enter(object sender, EventArgs e)
        {
            if (ModelType.ForeColor == Color.DimGray)
            {
                ModelType.ForeColor = Color.Black;
                ModelType.Font = new Font(ModelType.Font, FontStyle.Regular);
                ModelType.Text = String.Empty;
                ModelType.Clear();
            }
        }
        private void NumberType_Enter(object sender, EventArgs e)
        {
            if (NumberType.ForeColor == Color.DimGray)
            {
                NumberType.ForeColor = Color.Black;
                NumberType.Font = new Font(NumberType.Font, FontStyle.Regular);
                NumberType.Text = String.Empty;
                NumberType.Clear();
            }
        }

        #region Область создания телефона
        private void userModel_Enter(object sender, EventArgs e)
        {
            if (userModel.ForeColor == Color.DimGray)
            {
                userModel.ForeColor = Color.Black;
                userModel.Font = new Font(userModel.Font, FontStyle.Regular);
                userModel.Text = String.Empty;
                userModel.Clear();
            }
        }
        private void userNumber_Enter(object sender, EventArgs e)
        {
            if (userNumber.ForeColor == Color.DimGray)
            {
                userNumber.ForeColor = Color.Black;
                userNumber.Font = new Font(userNumber.Font, FontStyle.Regular);
                userNumber.Text = String.Empty;
                userNumber.Clear();
            }
        }
        private void userBalance_Enter(object sender, EventArgs e)
        {
            if (userBalance.ForeColor == Color.DimGray)
            {
                userBalance.ForeColor = Color.Black;
                userBalance.Font = new Font(userBalance.Font, FontStyle.Regular);
                userBalance.Clear();
            }
        }
        #endregion

        #region Область интерфейса телефона
        private void MessageType_Enter(object sender, EventArgs e)
        {
            if (Message.ForeColor == Color.DimGray)
            {
                Message.ForeColor = Color.Black;
                Message.Font = new Font(Message.Font, FontStyle.Regular);
                Message.Text = String.Empty;
                Message.Clear();
            }
        }
        private void DepositType_Enter(object sender, EventArgs e)
        {
            if (DepositType.ForeColor == Color.DimGray)
            {
                DepositType.ForeColor = Color.Black;
                DepositType.Font = new Font(DepositType.Font, FontStyle.Regular);
                DepositType.Clear();
            }
        }
        private void MessageType_Default()
        {
            Message.Clear();
            Message.ForeColor = Color.DimGray;
            Message.Font = new Font(Message.Font, FontStyle.Italic);
            Message.Text = "Сообщение...";
        }
        private void DepositType_Default()
        {
            DepositType.Clear();
            DepositType.ForeColor = Color.DimGray;
            DepositType.Font = new Font(DepositType.Font, FontStyle.Italic);
        }
        #endregion

        #endregion

        private void ChooseType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ChooseType.SelectedItem == "Стационарный")
            {
                label7.Hide(); userBalance.Hide();

            }
            if (ChooseType.SelectedItem == "Мобильный")
            {
                label7.Show(); userBalance.Show();

            }
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (userBalance.Text.Substring(0, 3) != "   ")
                userPhone = new Mobile(userModel.Text, Convert.ToInt32(userBalance.Text.Substring(0, 3)), userNumber.Text);
            else
                userPhone = new Mobile(userModel.Text, 0, userNumber.Text);

            if (userPhone.Number == "Номер введён неверно!")
                MessageBox.Show(userPhone.Number);
            else
            {
                CreationMenu.Hide();
                this.ClientSize = new System.Drawing.Size(434, 462);
                Interface.Show();
            }
        }
        private void AddPhone_Click(object sender, EventArgs e)
        {
            Phone phone;
            if (NumberType.Text.Length < 7)
            {
                phone = new Landline(ModelType.Text, NumberType.Text);
            }
            else
                phone = new Mobile(ModelType.Text, random.Next(0, 100), NumberType.Text);

            if (phone.Number == "Номер введён неверно!")
                MessageBox.Show(phone.Number);
            else
            {
                if (PhonesList.Any(n => n.Number == phone.Number))
                    MessageBox.Show("Телефон с данным номером уже существует.");
                else
                {
                    PhonesList.Add(phone);
                    AddedPhoneList.DataSource = null;
                    AddedPhoneList.DataSource = PhonesList;
                    AddedPhoneList.DisplayMember = "Number";
                }
            }
        }

        #region Управление звонками
        private void CallButton_Click(object sebder, EventArgs e)
        {
            ModelShow.DataBindings.Clear(); NumberShow.DataBindings.Clear();
            ModelShow.DataBindings.Add("Text", PhonesList, "Model");
            NumberShow.DataBindings.Add("Text", PhonesList, "Number");
            MessageMenu.Hide(); PhotoMenu.Hide(); SystemMenu.Hide(); simMenu.Hide();
            CallMenu.Show();
            this.ClientSize = new System.Drawing.Size(680, 462);
        }
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            AddedPhoneList.Enabled = false;
            userPhone.Notify += CallMessage;
                Phone OutPhone = PhonesList[AddedPhoneList.SelectedIndex];
                userPhone.Make_Call(ref OutPhone);
                PhonesList[AddedPhoneList.SelectedIndex] = OutPhone;
                DeniedButton.Show();
            userPhone.Notify -= CallMessage;
        }
        private void DeniedButton_Click(object sender, EventArgs e)
        {
            AddedPhoneList.Enabled = true;
            userPhone.Notify += CallMessage;
                Phone OutPhone = PhonesList[AddedPhoneList.SelectedIndex];
                userPhone.End_Call(ref OutPhone);
                PhonesList[AddedPhoneList.SelectedIndex] = OutPhone;
                DeniedButton.Hide();
            userPhone.Notify -= CallMessage;
        }
        #endregion

        #region Управление сообщениями
        private void MessageButton_Click(object sebder, EventArgs e)
        {
            ModelShow.DataBindings.Clear(); NumberShow.DataBindings.Clear();
            CallMenu.Hide(); PhotoMenu.Hide(); SystemMenu.Hide(); simMenu.Hide();
            MessageMenu.Show(); MessageType_Default();

            this.ClientSize = new System.Drawing.Size(680, 462);
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            //Mobile OutPhone = PhonesList[AddedPhoneList.SelectedIndex];
            //userPhone.Send_Message(ref OutPhone, Message.Text);
        }
        #endregion

        #region Управление фотографиями
        private void PhotoButton_Click(object sebder, EventArgs e)
        {
            ModelShow.DataBindings.Clear(); NumberShow.DataBindings.Clear();
            CallMenu.Hide(); MessageMenu.Hide(); SystemMenu.Hide(); simMenu.Hide();
            PhotoMenu.Show();

            this.ClientSize = new System.Drawing.Size(680, 462);
        }

        #endregion

        #region Система
        private void SystemButton_Click(object sebder, EventArgs e)
        {
            ModelShow.DataBindings.Clear(); NumberShow.DataBindings.Clear();
            CallMenu.Hide(); MessageMenu.Hide(); PhotoMenu.Hide(); simMenu.Hide();
            SystemMenu.Show();

            SystemInfo.Text = String.Format($"Модель телефона: {userPhone.Model}\n");
            this.ClientSize = new System.Drawing.Size(680, 462);
        }

        #endregion

        #region СИМ-карта
        private void BalanceButton_Click(object sender, EventArgs e)
        {
            ModelShow.DataBindings.Clear(); NumberShow.DataBindings.Clear();
            CallMenu.Hide(); MessageMenu.Hide(); PhotoMenu.Hide(); SystemMenu.Hide();
            simMenu.Show(); DepositType_Default(); simInfo.Text = String.Empty;

            this.ClientSize = new System.Drawing.Size(680, 462);
        }
        private void DepositButton_Click(object sender, EventArgs e)
        {
            userPhone.Pay_Balance(Convert.ToInt32(DepositType.Text.Substring(0, 3)));
            simInfo.Text += String.Format($" Баланс пополнен на сумму: {DepositType.Text.Substring(0, 3)} р.\n" +
                                        $" Баланс СИМ-карты: {userPhone.Balance} р.\n");
        }
        private void InfoButton_Click(object sender, EventArgs e)
        {
            simInfo.Text = String.Format($" Номер телефона: {userPhone.Number}\n" +
                                        $" Баланс СИМ-карты: {userPhone.Balance} р.\n");
        }
        #endregion

    }

}
