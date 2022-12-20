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
        Mobile userPhone;
        List<Phone> PhonesList = new List<Phone>{ new Landline("Paralitic 404", "936111"),
            new Mobile("Cockia 1488", 100, "89130401337"), new Landline("iPhonk 69", "228322"),
            new Mobile("Glory H01", 100, "89641017878") };

        OpenFileDialog openPhoto = new OpenFileDialog();
        Random random = new Random();

        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            #region Дизайн кнопок
            GraphicsPath callButton = new GraphicsPath();
            callButton.AddEllipse(new Rectangle(5, 4, 71, 71));
            AcceptButton.Region = new Region(callButton);
            DeniedButton.Region = new Region(callButton);
            #endregion

            CallMenu.Hide(); MessageMenu.Hide(); SystemMenu.Hide();
            //Введите_баланс_телефона_.Hide(); userBalance.Hide();
            Interface.Hide();
            DeniedButton.Hide();
            this.ClientSize = new System.Drawing.Size(244, 462);

            ChooseType.SelectedIndex = 1;
            AddedPhoneList.DataSource = null;
            AddedPhoneList.DataSource = PhonesList;
            AddedPhoneList.DisplayMember = "Number";
        }

        #region Функции управления
        public static void DisplayNotify(object sender, NotificationEventArgs e)
        {
            if (e.Number == null)
                MessageBox.Show($"{e.Message}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show($"{e.Number}\n{e.Message}",
                    "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //private void ChooseType_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    if (ChooseType.SelectedItem == "Стационарный")
        //    {
        //        Введите_баланс_телефона_.Hide(); userBalance.Hide();

        //    }
        //    if (ChooseType.SelectedItem == "Мобильный")
        //    {
        //        Введите_баланс_телефона_.Show(); userBalance.Show();

        //    }
        //}
        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (userBalance.Text.Substring(0, 3) != "   ")
                userPhone = new Mobile(userModel.Text, Convert.ToInt32(userBalance.Text.Substring(0, 3)), userNumber.Text);
            else
                userPhone = new Mobile(userModel.Text, 0, userNumber.Text);

            if (userPhone.Number == "Номер введён неверно!")
                MessageBox.Show(userPhone.Number, "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (userModel.Text == "" || userModel.ForeColor == Color.DimGray)
                MessageBox.Show("Модель указана неверно!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                CreationMenu.Hide();
                this.ClientSize = new System.Drawing.Size(434, 462);
                Interface.Show();
                this.ContactsArea.Controls.Add(this.Введите_модель_телефона_);
                this.ContactsArea.Controls.Add(this.Введите_номер_телефона_);
                this.Введите_модель_телефона_.Location = new System.Drawing.Point(12, 9);
                this.Введите_номер_телефона_.Location = new System.Drawing.Point(12, 57);
                Console.WriteLine($"{System.IO.Directory.GetCurrentDirectory()}");
            }
        }
        private void AddPhone_Click(object sender, EventArgs e)
        {
            Phone new_phone;
            if (NumberType.Text.Length < 7)
            {
                new_phone = new Landline(ModelType.Text, NumberType.Text);
            }
            else
                new_phone = new Mobile(ModelType.Text, random.Next(0, 100), NumberType.Text);

            if (new_phone.Number == "Номер введён неверно!")
                MessageBox.Show(new_phone.Number, "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ModelType.Text == "" || ModelType.ForeColor == Color.DimGray)
                MessageBox.Show("Модель указана неверно!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (PhonesList.Any(n => n.Number == new_phone.Number))
                    MessageBox.Show("Телефон с данным номером уже существует.",
                        "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    PhonesList.Add(new_phone);
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
            userPhone.Notify += DisplayNotify;
                Phone OutPhone = PhonesList[AddedPhoneList.SelectedIndex];
                if (userPhone.Make_Call(ref OutPhone)) DeniedButton.Show();
                PhonesList[AddedPhoneList.SelectedIndex] = OutPhone;
            userPhone.Notify -= DisplayNotify;
        }
        private void DeniedButton_Click(object sender, EventArgs e)
        {
            userPhone.Notify += DisplayNotify;
                Phone OutPhone = PhonesList[AddedPhoneList.SelectedIndex];
                if (userPhone.End_Call(ref OutPhone)) DeniedButton.Hide();
                PhonesList[AddedPhoneList.SelectedIndex] = OutPhone;
            userPhone.Notify -= DisplayNotify;
        }
        #endregion

        #region Управление сообщениями
        private void MessageButton_Click(object sebder, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(680, 462);
            ModelShow.DataBindings.Clear(); NumberShow.DataBindings.Clear();
            CallMenu.Hide(); PhotoMenu.Hide(); SystemMenu.Hide(); simMenu.Hide();
            MessageMenu.Show(); MessageType_Default();

            MessagesWindow.Text = String.Format($"Входящие:\n" +
                $"{userPhone.Check_Message(userPhone.Messages)}");
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            if (Message.ForeColor == Color.DimGray || String.IsNullOrEmpty(Message.Text))
                MessageBox.Show($"Для отправки введите сообщение.", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                userPhone.Notify += DisplayNotify;
                    Phone OutPhone = PhonesList[AddedPhoneList.SelectedIndex];
                    if (userPhone.Send_Message(ref OutPhone, Message.Text))
                        PhonesList[AddedPhoneList.SelectedIndex] = (Mobile)OutPhone;
                userPhone.Notify -= DisplayNotify;
            }
        }
        #endregion

        #region Управление фотографиями
        private void PhotoButton_Click(object sebder, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(680, 462);
            ModelShow.DataBindings.Clear(); NumberShow.DataBindings.Clear();
            CallMenu.Hide(); MessageMenu.Hide(); SystemMenu.Hide(); simMenu.Hide();
            PhotoMenu.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openPhoto.InitialDirectory = $@"{System.IO.Directory.GetCurrentDirectory()}\phone\photos";
            if (openPhoto.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox1.Image = new Bitmap(openPhoto.FileName);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openPhoto.InitialDirectory = $@"{System.IO.Directory.GetCurrentDirectory()}\phone\photos";
            if (openPhoto.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox2.Image = new Bitmap(openPhoto.FileName);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openPhoto.InitialDirectory = $@"{System.IO.Directory.GetCurrentDirectory()}\phone\photos";
            if (openPhoto.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox3.Image = new Bitmap(openPhoto.FileName);
            }
        }

        #endregion

        #region О системе
        private void SystemButton_Click(object sebder, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(680, 462);
            ModelShow.DataBindings.Clear(); NumberShow.DataBindings.Clear();
            CallMenu.Hide(); MessageMenu.Hide(); PhotoMenu.Hide(); simMenu.Hide();
            SystemMenu.Show();

            SystemInfo.Text = String.Format($" Модель телефона: {userPhone.Model}\n" +
                $" Вместимость фотографий: {Directory.EnumerateFiles($@"{System.IO.Directory.GetCurrentDirectory()}\phone\photos").Count()}\n" +
                $" Версия: 1.0\n" +
                $" ");
        }

        #endregion

        #region О СИМ-карте
        private void BalanceButton_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(680, 462);
            ModelShow.DataBindings.Clear(); NumberShow.DataBindings.Clear();
            CallMenu.Hide(); MessageMenu.Hide(); PhotoMenu.Hide(); SystemMenu.Hide();
            simMenu.Show(); DepositType_Default(); simInfo.Text = String.Empty;
        }
        private void DepositButton_Click(object sender, EventArgs e)
        {
            int depositSum = 0;
            if (DepositType.Text.Substring(0, 3) != "   ")
                depositSum = Convert.ToInt32(DepositType.Text.Substring(0, 3));
            if (depositSum != 0)
            {
                userPhone.Balance += depositSum;
                simInfo.Text += String.Format($" Баланс пополнен на сумму: {depositSum} р.\n" +
                                        $" Баланс СИМ-карты: {userPhone.Balance} р.\n");
            }
            else simInfo.Text += String.Format($" Укажите сумму для пополнения баланса!\n");
        }
        private void InfoButton_Click(object sender, EventArgs e)
        {
            simInfo.Text = String.Format($" Номер телефона: {userPhone.ToString()}\n" +
                                        $" Баланс СИМ-карты: {userPhone.Balance} р.\n");
        }
        #endregion

    }

}
