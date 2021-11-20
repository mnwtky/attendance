using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Display(Name = "名前")]
        [Required(ErrorMessage = "必須入力です")]
        public string Name { get; set; }

        [Display(Name = "メールアドレス")]
        [Required(ErrorMessage = "必須入力です")]
        public string Email { get; set; }

        [Display(Name = "パスワード")]
        [Required(ErrorMessage = "必須入力です")]
        public string Password { get; set; }

        public List<Attendance> Posts { get; set; }
    }
}
