using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones_Base
{
    public class SIM_Card
    {
        public int Balance;
        private string number;

        public string Number
        {
            get => number;
            set
            {
                if (value == "" || value[0] != '8' || value.Length != 11) number = "Номер введён неверно!";
                else number = value;
            }
        }

        public SIM_Card(int Balance, string Number)
        {
            this.Balance = Balance; this.Number = Number;
        }
    }
}
