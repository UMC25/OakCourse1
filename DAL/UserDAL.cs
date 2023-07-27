using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL:PostContext
    {
        public UserDTO GetUserWithUserNameAndPassword(UserDTO model)
        {
            UserDTO dto = new UserDTO();
            /* List<T_User> list = db.T_User.Where(x=>x.UserName == model.UserName && x.Password == model.Password).ToList(); */
            T_User user = db.T_User.FirstOrDefault(x => x.UserName == model.UserName && x.Password == model.Password);
            if(user != null && user.ID != 0)
            {
                dto.ID = user.ID;
                dto.UserName = user.UserName;
                dto.Name = user.NameSurname;
                dto.ImagePath = user.ImagePath;
                dto.IsAdmin = user.isAdmin;
            }
            return dto;
        }
    }
}
