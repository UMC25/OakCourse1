using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class UserDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please fill the Username area")]
        public string UserName { get; set; }
        [Required(ErrorMessage =" Please fill the Password area")]
        public string Password { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
    }
}
