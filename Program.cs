using EmployeePayRoll;
using System;
namespace EmployePayRoll
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Employee Pay Roll Program");
            EmployeeRepo repo= new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();
            employee.EmployeeName = "Joy";
            employee.PhoneNumber = "8574963214";
            employee.Address = "Kolkata";
            employee.Department = "Finaince";
            employee.Gender = "F";
            employee.BasicPay = 22000.00;
            employee.Deductions = 1500.00;
            employee.TaxablePay = 200.00;
            employee.Tax = 300.00;
            employee.NetPay = 2500.00;
            employee.City = "Gangnapur";
            employee.Country = "India";

            LockRecursionPolicy.AddEmployee(employee);
        }
    }
}