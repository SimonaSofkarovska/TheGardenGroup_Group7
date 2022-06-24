using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGardenGroupModel;

namespace TheGardenGroupDAL
{
    public class UserDAO : Base
    {
        private static IMongoCollection<User> collection;

        public UserDAO()
        {
            collection = db.GetCollection<User>("users");
        }

        //TODO: code for retrieving and comparing user data
        // - public List<User> ReadAllUsers(){} ???
        // - public User CheckUser() / ComparePassword() ???

    }
}