using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduler.Data.Entities
{
    public class User : IdentityUser
    {
        public List<Task> Tasks { get; set; }
    }
}
