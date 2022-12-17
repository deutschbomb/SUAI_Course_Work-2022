using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones_Base
{
    public class Mobile : Phone, ICalling, IMessages, ISIM_Card
    {
        public delegate void Notification(object sender, NotificationEventArgs e);
        public event Notification Notify;

        SIM_Card simCard;
        public List<string> Messages;

        #region Свойства
        public int Balance
        {
            get => simCard.Balance;
            set => simCard.Balance = value;
        }
        public override string Number
        {
            get => simCard.Number;
            set => simCard.Number = value;
        }

        #endregion

        #region Методы
        public void Make_Call(ref Phone phone)
        {
            if (this.Balance <= 0)
                Notify?.Invoke(this, new NotificationEventArgs("Недостаточно средств для совершения звонка.\n" +
                    "Пополните ваш баланс."));
            else
            {
                if (this.Call == true)
                    Notify?.Invoke(this, new NotificationEventArgs(phone.ToString(), "Текущий вызов не завершён."));
                else            
                    {
                    if (phone.Number == this.Number)
                        Notify?.Invoke(this, new NotificationEventArgs(phone.ToString(), "Входящий и исходящий номера совпадают.\n" +
                        "Вызов завершён."));
                    else
                    {
                        if (phone.Call == true)
                            Notify?.Invoke(this, new NotificationEventArgs(phone.ToString(), "Номер занят."));
                        else
                        {
                            this.Call = phone.Call = true;
                            Notify?.Invoke(this, new NotificationEventArgs(phone.ToString(), "Набор номера..."));
                        }
                    }               
                }
            }            
        }
        public void End_Call(ref Phone phone)
        {
            if (this.Call == true)
            {
                phone.Call = false;
                Notify?.Invoke(this, new NotificationEventArgs(phone.ToString(), "Вызов завершён."));
            }
            else Notify?.Invoke(this, new NotificationEventArgs("Входящего вызова нет."));

            this.Call = false;
        }
        public void Send_Message(ref Mobile phone, string message)
        {
            if (this.Balance <= 0)
                Notify?.Invoke(this, new NotificationEventArgs("Недостаточно средств для отправки сообщения.\n" +
                    "Пополните ваш баланс."));
            else
            {
                phone.Messages.Add($"{this.Number}\n{message}");
                Notify?.Invoke(this, new NotificationEventArgs("Сообщение отправлено."));
            }
        }
        public string Check_Message(List<string> Messages)
        {
            Messages = this.Messages;
            foreach (string message in Messages) return $"{message}\n";
            return "";
        }
        public void Pay_Balance(int balance)
        {
            this.Balance += balance;
        }
        #endregion

        public override string ToString()
        {
            if (String.IsNullOrEmpty(this.Number))
                return base.ToString();
            if (this.Number.Length == 11)
                return "+7(" + this.Number.Substring(1, 3) + ")" +
                    this.Number.Substring(4, 3) + "-" + this.Number.Substring(7, 2) + "-" + this.Number.Substring(9, 2);
            else
                return base.ToString();
        }

        public Mobile() : base() { }
        public Mobile(string Model, int Balance, string Number) : base(Model)
        {
            this.simCard = new SIM_Card(Balance, Number);
        }
    }
}
