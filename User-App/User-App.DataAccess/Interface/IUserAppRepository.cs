using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_App.Domain.DTOs;
using User_App.Domain.Models;

namespace User_App.DataAccess.Interface
{
    public interface IUserAppRepository
    {
        public Task<User> AddUser(CreateUserDto newUser);

        public Task<User> UpdateUser(CreateUserDto userToUpdate, int user_id);

        public Task<string> DeleteUser(int user_id);

        public Task<User> GetUserById(int user_id);

        public Task<List<User>> GetAllUsers();
    }
}
