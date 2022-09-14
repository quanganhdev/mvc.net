using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace validate.Models
{
    public class User
    {
        [Display(Name ="Id")]
        [Required (ErrorMessage ="khong the bo trong id")]
        public int Id { get; set; }
        [Display (Name="ten")]
        [StringLength (maximumLength:30,MinimumLength =2 ,ErrorMessage ="ky tu tu 16 den 30")]
        [Required(ErrorMessage ="khong bo trong ten")]
        public string Name { get; set; }
        [Display (Name ="email")]
        [Required (ErrorMessage ="khong duoc bo trong email")]
        [DataType(DataType.EmailAddress,ErrorMessage ="phai la dien chi email")]
        public String Email { get; set; }
        [Display(Name ="pass")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="khong bo trong")]
        [ScaffoldColumn(false)]
        public string Password { get; set; }
        [Display(Name = "re-pass")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "khong bo trong")]
        [Compare("Password",ErrorMessage ="khong trung voi pass")]
        public String RePassword {get;set;}

        [Display (Name ="tuoi")]
        [Required (ErrorMessage ="bo trong")]
        [Range(12,100,ErrorMessage ="tuoi tu 12 den 100")]

        public int Age { get; set; }

         public static List<User> Users()
        {
           List<User> Users = new List<User>();
           return Users;
        }
       


    }
}