using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargilForTest250819
{
    class ViewModelOrder
    {

        List<Order> orders = new List<Order>();
        public ViewModelOrder()
        {
            orders.Add(new Order {ID = 1, FirstName = "e", LastName= "z", Age = 54, Email ="123", IsMember = true, OrderValue = 1.3, OrderStatus= MyEnum.Recived });
        }           
    }
    
    public enum MyEnum {New = 1, Shipped = 2, Processing = 3, Recived = 4, None = 5 }
    class Order
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool IsMember { get; set; }
        public double OrderValue { get; set; }
        public MyEnum OrderStatus { get; set; }
    }
}


