﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWebStore.Domain.Entities
{
    public class Order
    {

        public Order()
        {
            this.OrderItems = new List<OrderItem>();
        }

        public int Id { get; private set; }

        public DateTime Date { get; private set; }

        public ICollection<OrderItem> OrderItems { get; private set; }
    }
}
