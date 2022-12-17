using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones_Base
{
    public abstract class Phone
    {
        public bool Call = false;
        private string model;

        public string Model
        {
            get => model;
            set
            {
                if (String.IsNullOrWhiteSpace(value)) model = "Модель указана неверно!";
            }
        }
        public abstract string Number { get; set; }
        public string OutCall_Number { get; set; }

        public Phone() { }
        public Phone(string Name)
        {
            this.Model = Name;
        }
    }
}
