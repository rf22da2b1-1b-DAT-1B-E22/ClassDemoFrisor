using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoFrisor.model
{
    public class Customer
    {
        public String Phone { get; set; }
        public String Name { get; set; }

        public Customer(string phone, string name)
        {
            Phone = phone;
            Name = name;
        }
        public Customer() :this("11111111", "Dummy"){ }

        public override string ToString()
        {
            return $"{{{nameof(Phone)}={Phone}, {nameof(Name)}={Name}}}";
        }
    }
}
