using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace portfolio_project.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="این فیلد اجباری است")]
        [MinLength(2,ErrorMessage ="حداقل کاراکتر ورودی، 2 می باشد")]
        [MaxLength(100, ErrorMessage = "حداکثر کاراکتر ورودی، 100 می باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage ="این فیلد اجباری است")]
        [EmailAddress(ErrorMessage ="ایمیل وارد شده، صحیح نمی باشد")]
        public string Email { get; set; }

        public string Message { get; set; }

        public int Service { get; set; }

        public SelectList Services { get; set; }
    }
}
