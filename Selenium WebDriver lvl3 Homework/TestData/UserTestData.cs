using BasicSelenium_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSelenium_Project.TestData
{
    public class UserTestData
    {
        public static User DefaultIncorrectUser = new()
        {
            UserName = "WrongUserName",
            Password = "WrongUserPassword"
        };
    }

}
