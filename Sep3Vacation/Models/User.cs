using System.Threading;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace Sep3Vacation.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }

        public string role { get; set; }
        public string Email { get; set; }
        public string password { get; set; }

        public User(int id, string userName, string password, string email)
        {
            this.id = id;
            this.username = userName;
            this.password = password;
            this.Email = email;
        }

        public User(string userName, string password, string role,string email)
        {
            this.username = userName;
            this.password = password;
            this.role = role;
            this.Email = email;
        }
        public User(string userName, string password)
        {
            this.username = userName;
            this.password = password;
        }

        public User(string userName, string password, string email)
        {
            
        }

        public User()
        {
            
        }
    }
}