using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones_Base
{
    public class NotificationEventArgs : EventArgs
    {
        public string Number { get; }
        public string Message { get; }

        public NotificationEventArgs(string message)
        {
            this.Message = message;
        }
        public NotificationEventArgs(string number, string message)
        {
            this.Number = number; this.Message = message;
        }
    }
}
