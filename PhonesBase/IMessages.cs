﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones_Base
{
    interface IMessages
    {
        bool Send_Message(ref Phone phone, string message);
        string Check_Message(List<string> Messages);
    }
}
