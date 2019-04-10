using ActualDataBaseRepository;
using CustomModel;
using DatabaseRepository;
using IDataBaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRepository
{
    public class EmployeeBLRepository
    {
        IemployeeRepository e;
        Model1Container db = new Model1Container();
       // Emp e = new Emp();
       // emp1 e = new emp1();
       
        //public List<EmpData> DBgetAllEmployees()

        //{
        //    return e.DBgetAllEmployees();
        //    //  new List<EmpData>();

        //}
        public EmployeeBLRepository(int x)
        {
            //
            //IemployeeRepository e;
            if (x==1)
            {
                 e = new Emp();
            }
            if(x==2)
            {
                 e = new emp1();
            }
        }
        public  List<EmpData> getAllEmployees()

            {
            return e.getAllEmployees();
             //  new List<EmpData>();
            
            }

         public List<EmpData> getEmployeeById(int x)
            {
            return e.getEmployeeById(2);
                // new List<EmpData>();
            }
         public List<EmpData> saveEmployee()
            {
            return e.saveEmployee();
                // new List<EmpData>();
            }
            
        }
    }

