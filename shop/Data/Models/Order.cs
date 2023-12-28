using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [MinLength(8)]
        [Required(ErrorMessage = "Не менее 8 символов")]
        public string Password { get; set; }

        public int CharID { get; set; }

        [BindNever]
        public DateTime Date { get; set; }
    }
}
