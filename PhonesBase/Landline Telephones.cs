using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones_Base
{
    public sealed class Landline : Phone, ICalling
    {
        public delegate void CallingMessage(object sender, NotificationEventArgs e);
        public event CallingMessage Notify;

        public bool Power = true;
        private string number;

        #region Свойства
        public override string Number
        {
            get => number;
            set
            {
                if (value == "" || value[0] == '0' || value.Length != 6) number = "Номер введён неверно!";
                else number = value;
            }
        }
        #endregion

        #region Методы
        public void Make_Call (ref Phone phone)
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
        public void End_Call (ref Phone phone)
        {
            if (this.Call == true)
            {
                phone.Call = false;
                Notify?.Invoke(this, new NotificationEventArgs(phone.ToString(), "Вызов завершён."));
            }
            else Notify?.Invoke(this, new NotificationEventArgs("Входящего вызова нет."));

            this.Call = false;
        }
        #endregion

        public override string ToString()
        {
            if (String.IsNullOrEmpty(this.Number))
                return base.ToString();
            if (this.Number.Length == 6)
                return this.Number.Substring(0, 2) + "-" +
                    this.Number.Substring(2, 2) + "-" +
                   this.Number.Substring(4, 2);
            else
                return base.ToString();
        }

        public Landline() : base() { }
        public Landline(string Model, string Number) : base (Model)
        {
            this.Number = Number;
        }
    }
}
