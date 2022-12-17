using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones_Base
{
    interface ICalling
    {
        void Make_Call(ref Phone Phone);
        void End_Call(ref Phone phone);
    }
}
