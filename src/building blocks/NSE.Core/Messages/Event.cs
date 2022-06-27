using System;
using MediatR;

namespace NSE.Core.Messages
{
    public class Event:Message,INotification
    {
        public DateTime TimesTamp { get; private set; }

        protected Event()
        {
            TimesTamp = DateTime.Now;
        }
    }
}