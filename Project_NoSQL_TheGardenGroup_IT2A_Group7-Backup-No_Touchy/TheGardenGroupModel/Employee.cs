
namespace TheGardenGroupModel
{
    class Employee : User
    {
        public Employee(string username, string password)
            :base (username, password)
        {
            this.permission = Permission.Admin;
        }
    }
}
