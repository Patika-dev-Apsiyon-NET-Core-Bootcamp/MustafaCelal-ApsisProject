using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Role : IdentityRole
    {
        public Role()
        {
            Users = new List<User>();
        }

        public virtual ICollection<User> Users { get; set; }
    }
    public enum Roles
    {
        Admin,
        User
        //,Residents
    }
}
