using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones_Base
{
    interface ICalling
    {
        // Метод для совершения звонка
        bool Make_Call(ref Phone Phone);
        // Метод для завершения звонка
        bool End_Call(ref Phone phone);
    }
}
