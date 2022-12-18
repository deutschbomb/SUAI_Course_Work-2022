using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones_Base
{
    public class Mobile : Phone, ICalling, IMessages
    {
        public delegate void Notification(object sender, NotificationEventArgs e); // объявление делегата
        public event Notification Notify; // объявление события

        #region Поля
        SIM_Card simCard;
        public List<string> Messages = new List<string> { };
        #endregion

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
        // Реализация метода Make_Call
        public bool Make_Call(ref Phone phone)
        {
            if (this.Balance <= 0)
                Notify?.Invoke(this, new NotificationEventArgs("Недостаточно средств для совершения звонка.\n" +
                    "Пополните ваш баланс."));
            else
            {
                if (this.Call == true)
                    Notify?.Invoke(this, new NotificationEventArgs("Текущий вызов не завершён."));
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
                            this.Balance -= 10;
                            Notify?.Invoke(this, new NotificationEventArgs(phone.ToString(), "Набор номера..."));
                            return true;
                        }
                    }               
                }
            }
            return false;
        }
        // Реализация метода End_Call
        public bool End_Call(ref Phone phone)
        {
            if (this.Call == true && phone.Call == true)
            {
                this.Call = phone.Call = false;
                Notify?.Invoke(this, new NotificationEventArgs(phone.ToString(), "Вызов завершён."));
                return true;
            }
            else
            {
                Notify?.Invoke(this, new NotificationEventArgs("Текущий вызоов совершён не данному абоненту."));
                return false;
            }
        }
        // Реализация метода Send_Message
        public bool Send_Message(ref Phone phone_, string message)
        {
            if (this.Balance <= 0)
                Notify?.Invoke(this, new NotificationEventArgs("Недостаточно средств для отправки сообщения.\n" +
                    "Пополните ваш баланс."));
            else
            {
                if (phone_ is Mobile)
                {
                    Mobile phone = (Mobile)phone_;
                    phone.Messages.Add($" {this.Number}:\n  {message}");
                    this.Balance -= 5;
                    Notify?.Invoke(this, new NotificationEventArgs(phone.ToString(), "Сообщение успешно отправлено."));
                    return true;
                }
                else Notify?.Invoke(this, new NotificationEventArgs(phone_.ToString(),
                    "На данный номер невозможно отправить сообщение."));
            }
            return false;
        }
        // Реализация метода Check_Message
        public string Check_Message(List<string> Messages)
        {
            Messages = this.Messages;
            foreach (string message in Messages) return $"{message}\n";
            return "";
        }
        #endregion
        // Переопределённый стандартный метод ToString()
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
        // Конструкторы
        public Mobile() : base() { }
        public Mobile(string Model, int Balance, string Number) : base(Model)
        {
            this.simCard = new SIM_Card(Balance, Number);
        }
    }
}
