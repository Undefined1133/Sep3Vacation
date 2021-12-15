using System.Collections.Generic;
using System.Threading.Tasks;
using Sep3Vacation.Models;

namespace Sep3Vacation.Data
{
    public interface IUserService
    {
        Task<User> ValidateRegister(string userName, string password,string email);
        Task<User> ValidateLogin(string userName, string password);
        Task<User> GetUserByUserName(string userName);
        Task<IList<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> UpdateUsersRole(User user);
        Task<User> UpdateUsersInfo(User user);
    }
}