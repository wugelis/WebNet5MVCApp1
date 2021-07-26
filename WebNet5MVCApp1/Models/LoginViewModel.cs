using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebNet5MVCApp1.Models
{
    [Serializable]
    public class LoginViewModel
    {
        [Required(ErrorMessage = "請輸入帳號！")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "請輸入您的密碼！")]
        public string Password { get; set; }
    }
}
