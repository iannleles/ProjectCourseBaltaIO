using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWebStore.Domain.Entities
{
    public class Order
    {
        private IList<OrderItem> _orderItems;

        public Order(IList<OrderItem> orderItems, int userId)
        {
            this.Date = DateTime.Now;           
            this.OrderItems = orderItems;
            this.UserId = userId;
        }

        public int Id { get; private set; }

        public DateTime Date { get; private set; }

        public IEnumerable<OrderItem> OrderItems 
        {
            get { return _orderItems; }

            private set { _orderItems = new List<OrderItem>(value); }
        }

        public int UserId { get; private set; }

        public User User { get; private set; }

        public void AddItem(OrderItem item)
        {
            if (item == null)

                throw new Exception("Item inválido");

            if (item.Price <= 0)
                throw new Exception("Item inválido");

            if (item.Quantity <= 0)
                throw new Exception("Item inválido");

            _orderItems.Add(item);

        }
    }
}
