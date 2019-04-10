using BusinessRepository;
using DatabaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x;
            Console.WriteLine("enter option 1 or 2:");
         
            // EmployeeBLRepository(int x);
            //EmployeeBLRepository ebr = new EmployeeBLRepository(Convert.ToInt32(Console.ReadLine()));
            int n = (Convert.ToInt32(Console.ReadLine()));
           
            EmployeeBLRepository h = new EmployeeBLRepository(n);
            var a = h.getAllEmployees();
           // ebr.getEmployeeById(2);
          
            foreach (var i in a)
            {
                System.Console.WriteLine(i.EmpId);
                System.Console.WriteLine(i.EmpName);
                System.Console.WriteLine(i.EmpCity);

            }
            //var b = ebr.DBgetAllEmployees();
            
            //foreach(var k in b)
            //{
            //    System.Console.WriteLine(k.EmpId);
            //    System.Console.WriteLine(k.EmpName);
            //    System.Console.WriteLine(k.EmpCity);

            //}
            //ebr.getEmployeeById(2);
            // ebr.saveEmployee();
            Console.ReadLine();
        }
    }
}
