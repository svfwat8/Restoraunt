using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt.Domain.Enums.User
{
    public enum URole
    {
        Anonym = 0,
        Guest = 5,
        User = 15,
        Admin = 200,
        Banned = 500
    }
}
