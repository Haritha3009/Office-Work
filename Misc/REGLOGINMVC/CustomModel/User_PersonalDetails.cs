using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomModel
{
    public  class t_User_PersonalDetails
    {
        public int UserPersonalId { get; set; }
        public int UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public bool Gender { get; set; }
        public System.DateTime DOB { get; set; }
        public string Address { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }

        public virtual t_Users t_Users { get; set; }
    }
}
