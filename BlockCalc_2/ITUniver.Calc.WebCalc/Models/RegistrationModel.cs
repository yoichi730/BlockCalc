using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebCalc.Models
{
    public class RegistrationModel
    {
        public RegistrationModel()
        {
            
        }

        [Display(Name = "Имя")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Заполните поле Имя")]
        public string UserName { get; set; }

        [Display(Name = "Login")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Заполните поле Login")]
        public string Login { get; set; }

        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Заполните поле Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "BirthDay")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Заполните поле BirthDay")]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

        [Display(Name = "Sex")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Выберите Sex")]
        public bool Sex { get; set; }
    }
}