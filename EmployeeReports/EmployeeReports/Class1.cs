using ActualDataBaseRepository;
using CustomModel;
using IDataBaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseRepository
{
   
    public class Emp : IemployeeRepository
    {
        Model1Container db = new Model1Container();
        List<EmpData> ed = new List<EmpData>() {
            new EmpData() { EmpId=1, EmpName="Arun", EmpCity="Vizag" },
             new EmpData() { EmpId=2, EmpName="Bhanu", EmpCity="Chitoor" },
              new EmpData() { EmpId=3, EmpName="Kiran", EmpCity="Medak" },
               new EmpData() { EmpId=4, EmpName="Rajesh", EmpCity="Kurnool" },
                new EmpData() { EmpId=5, EmpName="Renu", EmpCity="Hyderabad" }


        };
       
        public List<EmpData> getAllEmployees()

        {
            return ed;
        }
       
        public List<EmpData> getEmployeeById(int x)
        {
            //var k = from s in ed
            //        where s.EmpId == 2
            //        select s;
            //foreach(var i in k)
            //{
            //    System.Console.WriteLine(i.EmpId);
            //    System.Console.WriteLine(i.EmpName);
            //    System.Console.WriteLine(i.EmpCity);

            //}
            return new List<EmpData>();
        }
        public List<EmpData> saveEmployee()
        {


            return new List<EmpData>();
        }
        
        
    }
}
