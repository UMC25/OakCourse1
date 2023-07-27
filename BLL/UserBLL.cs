using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {   UserDAL userdal = new UserDAL();
        public UserDTO GetUserWithUserNameAndPassword(UserDTO model)
        {
            UserDTO dto = new UserDTO();
            dto = userdal.GetUserWithUserNameAndPassword(model);

            return dto; 
        }

    }
}
