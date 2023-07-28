using Microsoft.AspNetCore.Mvc;
using DTO;
using BLL;

namespace UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Login : Controller
    {
        UserBLL userbll = new UserBLL();
        public IActionResult Index()
        {   
            UserDTO dto = new UserDTO();
            return View(dto);
        }
        [HttpPost]
        public IActionResult Index(UserDTO model)
        {
            if (ModelState.IsValid)
            {
                UserDTO user = userbll.GetUserWithUserNameAndPassword(model);
                if(user.ID != 0)
                {
                    UserStatic.UserID = user.ID;
                    UserStatic.IsAdmin = user.IsAdmin;
                    UserStatic.NameSurname = user.Name;
                    UserStatic.ImagePath = user.ImagePath;
                    LogBLL.AddLog(1, "Login", 12);
                    return RedirectToAction("Index","Post");
                }
                else
                {
                    return View(model);
                }
                

            }
            else
            {
                return View(model);
            }
            
        }
    }
}
