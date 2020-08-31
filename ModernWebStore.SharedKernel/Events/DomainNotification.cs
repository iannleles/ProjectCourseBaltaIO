﻿using ModernWebStore.SharedKernel.Events.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWebStore.SharedKernel.Events
{
    public class DomainNotification : IDomainEvent
    {
        public string Key{ get; private set; }
        public string Value { get; private set; }
        public DateTime DateOcurred { get; private set; }
        
        public DomainNotification(string key, string value)
        {
            this.Key = key;
            this.Value = value;
            this.DateOcurred = DateTime.Now;
        }
    }
}
