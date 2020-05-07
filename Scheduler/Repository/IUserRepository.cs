using Microsoft.AspNetCore.Identity;
using Scheduler.Data.Entities;

namespace Scheduler.Repository
{
    public interface IUserRepository
    {
        IdentityUser FindUserByName(string name);
    }
}