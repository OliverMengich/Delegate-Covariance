using System;

namespace DelegateCovariance1
{
    public delegate Employee EmployeeDelegate();
    class Program
    {
        public static Employee GetEmployee()
        {
            return new Employee();
        }
         public static SalesEmployee GetSalesEmployee()
         {
             return new SalesEmployee();
         }
        static void Main(string[] args)
        {
            Employee emp = new Employee("Kipkemei","Oliver",4);
            EmployeeDelegate empdel = new EmployeeDelegate(GetEmployee);
            Employee employee_1 = empdel();

            EmployeeDelegate salesEmpDel = new EmployeeDelegate(GetSalesEmployee);
            SalesEmployee emp_2 = (SalesEmployee)salesEmpDel();
        }
    }
   public class Employee
    {
        protected string firstname;
        protected string lastname;
        protected int age;
        public Employee()
        {

        }
        public Employee(string _firstname,string _lastname,int _age)
        {
           firstname = _firstname;
           lastname = _lastname;
           age = _age;

           System.Console.WriteLine( firstname+ " "+lastname+" "+age);
        }
    }
    class SalesEmployee : Employee
    {
        protected int salesNumber;
        public SalesEmployee()
        {
             
        }
         public SalesEmployee(string _firstname , string  _lastname,int _age , int _salesNumber): base ( _firstname , _lastname , _age)
        {
             salesNumber = _salesNumber;

        }
    }
}
