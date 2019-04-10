using CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class DALClass
    {
        mvcEntities db = new mvcEntities();
        public bool addData(CommonClass custom)
        {
            t_Users tu = new t_Users();
            tu.EMail = custom.EMail;
            tu.Password = custom.Password;
            tu.IsActive = true;
            tu.CreatedDate = DateTime.Now;
            int? id = (from s in db.t_Users
                      orderby s.UserId descending
                      select s.UserId).Take(1).SingleOrDefault();

            t_User_PersonalDetails tp = new t_User_PersonalDetails();
            tp.Address = custom.Address;
            tp.DOB = custom.DOB;
            tp.FName = custom.FName;
            tp.LName = custom.LName;
            tp.Phone = custom.Phone;
            tp.UserId = (int) id;
            return true;
        }
    }
}
