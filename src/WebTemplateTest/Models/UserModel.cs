using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTemplateTest.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public int UserId { get; set; }

        public UserModel ReturnUserModel()
        {
            UserModel newUser = new Models.UserModel();
            newUser.Name = "Chuck";
            newUser.UserId = 12345;
            return newUser;
        }
    }
}
