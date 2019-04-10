using CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDataBaseRepository;


namespace ActualDataBaseRepository
{
    //
    //interface IActualDataBase
    //{
    //    List<EmpData> DBgetAllEmployees();
    //}
    public class emp1 : IemployeeRepository
    {
        Model1Container db = new Model1Container();
        List<EmployeeInformation> ed1 = new List<EmployeeInformation>();
        List<EmpData> ed2 = new List<EmpData>();

        public List<EmpData> getAllEmployees()
        {
          
            var k = db.EmployeeInformations.ToList();
            foreach (var i in k) {
                ed2.Add(new EmpData() { EmpId = i.Id, EmpName = i.EmpName, EmpCity = i.EmpCity });
            }
            return ed2;
           // return db.EmployeeInformations.ToList();
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


