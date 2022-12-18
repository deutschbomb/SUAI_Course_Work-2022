using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones_Base
{
    public abstract class Phone
    {
        #region Поля
        public bool Call = false;
        private string model;
        #endregion

        #region Свойства
        public string Model
        {
            get => model;
            set
            {
                if (String.IsNullOrEmpty(value)) model = String.Empty;
                else model = value;
            }
        }
        public abstract string Number { get; set; }
        #endregion

        // Конструкторы
        public Phone() { }
        public Phone(string Name)
        {
            this.Model = Name;
        }
    }
}
