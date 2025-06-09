using Restoraunt.BusinessLogic.Core;
using Restoraunt.BusinessLogic.DBModel;
using Restoraunt.BusinessLogic.Interfaces;
using Restoraunt.Domain.Entities.User.Login;
using Restoraunt.Domain.Entities.User.Registration;
using System.Linq;
using System;
using System.Web;
using Restoraunt.Domain.Entities.User;

public class SessionBL : UserApi, ISession
{
    public UserLoginResult UserLogin(UserLoginData data) => LoginAPI(data);
    public UserRegistrationResult UserRegistration(UserRegistrationData data)
                                                             => RegisterAPI(data);
}
