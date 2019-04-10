using CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataBaseRepository
{
   public interface IemployeeRepository
    {
        List<EmpData> getAllEmployees();
        //List<EmpData> DBgetAllEmployees();
        List<EmpData> getEmployeeById(int x);
        List<EmpData> saveEmployee();

    }
}
