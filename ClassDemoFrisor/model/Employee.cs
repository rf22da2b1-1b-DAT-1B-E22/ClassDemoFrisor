using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoFrisor.model
{
    public class Employee
    {
        public String Phone { get; set; }
        public String Name { get; set; }
        public String State { get; set; }

        public Employee(string phone, string name, string state)
        {
            Phone = phone;
            Name = name;
            State = state;
        }
        public Employee():this("11111111", "dummy", "Elev")
        { }

        public override string ToString()
        {
            return $"{{{nameof(Phone)}={Phone}, {nameof(Name)}={Name}, {nameof(State)}={State}}}";
        }


        
    }
}
