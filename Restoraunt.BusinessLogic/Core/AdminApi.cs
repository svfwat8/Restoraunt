using Restoraunt.BusinessLogic.DBModel;
using Restoraunt.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt.BusinessLogic.Core
{
    class AdminApi
    {
        public AdminApi() { }
        public List<UserDbModel> GetAllAPI()
        {
            try
            {
                using (var db = new UserContext())
                {
                    return db.Users.ToList();
                }
            }
            catch
            {
                return new List<UserDbModel>();
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

    }
}
