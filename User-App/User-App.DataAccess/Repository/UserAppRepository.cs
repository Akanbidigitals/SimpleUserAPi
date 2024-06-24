using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_App.DataAccess.Interface;
using User_App.Domain.DTOs;
using User_App.Domain.Models;

namespace User_App.DataAccess.Repository
{
    public class UserAppRepository : IUserAppRepository
    {
        public Task<User> AddUser(CreateUserDto newUser)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteUser(int user_id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(int user_id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUser(CreateUserDto userToUpdate, int user_id)
        {
            throw new NotImplementedException();
        }
    }
}
