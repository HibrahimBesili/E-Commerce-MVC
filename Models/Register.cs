using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Commerce_MVC.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Ad")]
        public string  Name { get; set; }
        [Required]
        [DisplayName("Soyad")]
        public string Surname { get; set; }
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string  Username { get; set; }
        [Required]
        [DisplayName("E-Mail")]
        [EmailAddress(ErrorMessage ="Geçersiz Email Adresi")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="Şifre Tekrarı yanlış")]
        [DisplayName("Şifre Tekrarı")]
        public string RePassword { get; set; }
        
    }
}