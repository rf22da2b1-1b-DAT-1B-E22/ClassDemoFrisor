// See https://aka.ms/new-console-template for more information
using ClassDemoFrisor.model;

Console.WriteLine("Hello, World!");

Employee emp1 = new Employee();
Employee emp2 = new Employee("33445566","Peter","Elev");
Employee emp3 = new Employee("55667788", "Jakob", "Frisør");

Console.WriteLine(emp1);
Console.WriteLine(emp2);
Console.WriteLine(emp3);


EmployeeCatalog catalog = new EmployeeCatalog();
catalog.Add(emp1);
catalog.Add(emp2);
catalog.Add(emp3);

catalog.PrintAll();

Console.WriteLine("Phone 55667788");
Console.WriteLine("Fundet: " + catalog.GetByPhoneId("55667788"));

Console.WriteLine("Alle Elever");
List<Employee> list = catalog.GetAllTrainee(); 
foreach(Employee emp in list)
{
    Console.WriteLine(emp);
}

Console.WriteLine("Booking");
Customer customer = new Customer("77553311","Peter");
Console.WriteLine(customer);
Booking booking = new Booking(DateTime.Now, customer, emp2);
Console.WriteLine(booking);


try
{
    Employee findesIkke = catalog.GetByPhoneId("00000000");
}
catch(KeyNotFoundException knfe)
{
    Console.WriteLine(knfe.Message);
}
