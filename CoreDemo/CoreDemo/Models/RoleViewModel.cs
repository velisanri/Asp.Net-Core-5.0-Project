using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Rol Adı Giriniz")]
        public string name { get; set; }
    }
}
