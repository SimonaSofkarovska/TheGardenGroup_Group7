
namespace TheGardenGroupModel
{
    public enum Permission { Admin = 1, Client}

    public class User
    {
        protected Permission permission;

        public string Username { get; set; }
        public string Password { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            this.permission = Permission.Client;
        }
    }
}
