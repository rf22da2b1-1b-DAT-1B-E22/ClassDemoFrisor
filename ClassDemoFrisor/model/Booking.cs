using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoFrisor.model
{
    public class Booking
    {
        public DateTime tidspunkt { get; set; }

        private Customer _customer;
        private Employee _employee;

        public Customer Customer { get { return _customer; } }
        public Employee Employee { get { return _employee; } }

        public Booking(DateTime tidspunkt, Customer customer, Employee employee)
        {
            this.tidspunkt = tidspunkt;
            _customer = customer;
            _employee = employee;
        }

        public Booking():this(DateTime.Today, null, null)
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(tidspunkt)}={tidspunkt.ToString("dd/MM-yyyy HH:mm")}, {nameof(Customer)}={Customer}, {nameof(Employee)}={Employee}}}";
        }
    }
}
