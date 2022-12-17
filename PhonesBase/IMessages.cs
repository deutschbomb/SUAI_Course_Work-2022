using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones_Base
{
    interface IMessages
    {
        void Send_Message(ref Mobile phone, string message);
        string Check_Message(List<string> Messages);
    }
}
