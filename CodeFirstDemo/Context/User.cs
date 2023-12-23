using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Context
{
    public class User
    {
        [Key]
        public int PK_UserID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }
        public Nullable<int> RoleID { get; set; }

        [Required]
        public string? EmailID { get; set; }
    }
}
