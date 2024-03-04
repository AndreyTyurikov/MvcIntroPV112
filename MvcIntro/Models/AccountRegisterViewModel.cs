using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MvcIntro.Models
{
    public class AccountRegisterViewModel
    {
        public int Id { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public int CityID { get; set; }
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords are not equal")]
        public string PasswordRepeat { get; set; }

        [AllowedValues([true], ErrorMessage = "You should agree to terms and conditions")]
        public bool AgreeToTerms { get; set; }

        public List<SelectListItem> Cities {  get; set; } = new List<SelectListItem>();
    }
}
