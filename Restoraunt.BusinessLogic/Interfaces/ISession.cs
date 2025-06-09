using Restoraunt.Domain.Entities.User;
using Restoraunt.Domain.Entities.User.Login;
using Restoraunt.Domain.Entities.User.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Restoraunt.BusinessLogic.Interfaces
{
    public interface ISession
    {
        UserLoginResult UserLogin(UserLoginData data);
        UserRegistrationResult UserRegistration(UserRegistrationData data);
    }
}
