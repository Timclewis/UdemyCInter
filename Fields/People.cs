using System;
using System.Collections.Generic;

namespace Fields
{
    public class People
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public People(int id)
        {
            this.Id = id;
        }

        public People(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>();
        }

        public class Order
        {

        }
    }
}
