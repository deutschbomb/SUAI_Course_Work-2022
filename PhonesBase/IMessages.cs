using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones_Base
{
    interface IMessages
    {
        // Метод для отправки сообщений
        bool Send_Message(ref Phone phone, string message);
        // Метод для просмотра полученных сообщений
        string Check_Message(List<string> Messages);
    }
}
