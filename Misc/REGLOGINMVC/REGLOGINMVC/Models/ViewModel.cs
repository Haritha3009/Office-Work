using CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REGLOGINMVC.Models
{
    public class ViewModel
    {
        public t_User_PersonalDetails userPersonal {get;set;}
        public t_Users user { get; set; }
    }
}