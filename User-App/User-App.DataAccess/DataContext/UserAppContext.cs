using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_App.Domain.Models;

namespace User_App.DataAccess.UserContext
{
    public class UserAppContext : DbContext
    {
        public UserAppContext(DbContextOptions options) : base(options) { }

        public DbSet<User>Users { get; set; }
    }
}
