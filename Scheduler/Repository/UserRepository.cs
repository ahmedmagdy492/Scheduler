using Microsoft.AspNetCore.Identity;
using Scheduler.Data;
using Scheduler.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduler.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _ctx;

        public UserRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public IdentityUser FindUserByName(string name)
        {
            return _ctx.Users.FirstOrDefault(u => u.Email == name);
        }

    }
}
