using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restoraunt.BusinessLogic.BL;
using Restoraunt.Domain.Entities.User;

namespace Restoraunt.BusinessLogic.Interfaces
{
    public interface IUser
    {
        List<UserDTO> GetAllUsers();
        UserDTO GetById(int id);
        bool Update(UserDTO User);
        bool Delete(int id);
        bool ChangePassword(int userId, string oldPassword, string newPassword, out string message);

    }
}
