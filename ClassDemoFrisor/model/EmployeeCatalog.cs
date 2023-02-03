using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoFrisor.model
{
    public class EmployeeCatalog
    {

        private List<Employee> _employees;

        public EmployeeCatalog()
        {
            _employees= new List<Employee>();
        }

        public void Add(Employee newEmployee)
        {
            _employees.Add(newEmployee);
        }

        public void PrintAll()
        {
            Console.WriteLine("====  Ansatte  ====");
            foreach (Employee emp in _employees)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("======  SLUT ========");
        }


        public Employee GetByPhoneId(String phoneId)
        {
            foreach (Employee emp in _employees)
            {
                if (emp.Phone == phoneId)
                {
                    return emp;
                }
            }

            //return null;
            throw new KeyNotFoundException($"Det pågældende mobil nummer {phoneId} findes ikke");
        }


        public List<Employee> GetAllTrainee()
        {
            List<Employee> liste = new List<Employee>();

            foreach(Employee emp in _employees)
            {
                if (emp.State.ToLower() == "elev")
                {
                    liste.Add(emp);
                }
            }

            return liste;
        }





    }
}
