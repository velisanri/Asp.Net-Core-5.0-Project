using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="kullancıı adını gir")]
        public string username { get; set; }
        [Required(ErrorMessage = "sifreni gir")]
        public string password { get; set; }
    }
}
