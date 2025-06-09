using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Restoraunt.Domain.Entities.User;
using Restoraunt.Domain.Entities.User.Login;
using Restoraunt.BusinessLogic.DBModel;
using Restoraunt.Domain.Enums.User;
using System.Security.Cryptography;
using System.Text;
using Restoraunt.Domain.Entities.User.Registration;
using System.ComponentModel.DataAnnotations;
using System.Web;
using Restoraunt.Helpers;
using Restoraunt.Helpers.LoginRegisterHelper;
using AutoMapper;
using Restoraunt.Domain.Entities.Contact;

namespace Restoraunt.BusinessLogic.Core
{
    public class UserApi
    {
        public UserApi() { }
        public List<UserDbModel> GetAllUsersAPI()
        {
            using (var context = new UserContext())
            {
                return context.Users.ToList();
            }
        }
        public UserDbModel GetByIdAPI(int id)
        {
            try
            {
                using (var db = new UserContext())
                {
                    return db.Users.Find(id);
                }
            }
            catch
            {
                return null;
            }
        }
        public bool UpdateAPI(UserDbModel entity)
        {
            try
            {
                using (var db = new UserContext())
                {
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteAPI(int id)
        {
            try
            {
                using (var db = new UserContext())
                {
                    var user = db.Users.Find(id);
                    if (user == null) return false;
                    db.Users.Remove(user);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public UserLoginResult LoginAPI(UserLoginData data)
        {
            try
            {
                using (var db = new UserContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.UserName == data.UserName);
                    if (user == null)
                    {
                        return new UserLoginResult
                        {
                            Status = false,
                            Message = "Пользователь не найден"
                        };
                    }

                    var hash = LoginRegisterHelper.HashGen(data.Password);
                    if (user.Password != hash)
                    {
                        return new UserLoginResult
                        {
                            Status = false,
                            Message = "Неверный пароль"
                        };
                    }

                    user.LastLogin = DateTime.Now;
                    db.SaveChanges();

                    var dto = new UserDTO
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        Email = user.Email,
                        LastLogin = user.LastLogin,
                        Role = user.Level.ToString(),
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        BirthDate = user.BirthDate,
                        PhoneNumber = user.PhoneNumber,
                        RegistrationDate = user.RegistrationDate,
                        Balance = user.Balance
                    };

                    return new UserLoginResult
                    {
                        Status = true,
                        Message = "Успешный вход",
                        UserDTO = dto
                    };
                }
            }
            catch (Exception ex)
            {
                return new UserLoginResult
                {
                    Status = false,
                    Message = ex.Message
                };
            }
        }

        public UserRegistrationResult RegisterAPI(UserRegistrationData data)
        {
            try
            {
                using (var db = new UserContext())
                {
                    if (db.Users.Any(u => u.UserName == data.UserName))
                        return new UserRegistrationResult
                        {
                            Status = false,
                            Message = "SuchCredentialsIsExist"
                        };

                    var encPassword = LoginRegisterHelper.HashGen(data.Password);
                    var user = new UserDbModel
                    {
                        UserName = data.UserName,
                        Password = encPassword,
                        Email = data.Email,
                        LastLogin = DateTime.Now,
                        Level = URole.User,
                        FirstName = data.FirstName,
                        LastName = data.LastName,
                        BirthDate = data.BirthDate,
                        PhoneNumber = data.PhoneNumber,
                        RegistrationDate = DateTime.UtcNow,
                        Balance = 0
                    };

                    db.Users.Add(user);
                    db.SaveChanges();

                    return new UserRegistrationResult
                    {
                        Status = true,
                        Message = "Successful",
                        User = user
                    };
                }
            }
            catch (Exception ex)
            {
                return new UserRegistrationResult
                {
                    Status = false,
                    Message = ex.Message,
                    User = null
                };
            }
        }
    }
}
