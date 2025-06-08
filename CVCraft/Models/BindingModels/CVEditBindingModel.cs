using System.ComponentModel.DataAnnotations;

namespace CVCraft.Models.BindingModels {
    public class CVEditBindingModel {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "First name is required on server")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 25 characters")]
        [RegularExpression(@"^[a-zA-Z\s\-'\.]+$", ErrorMessage = "First name can only contain letters, spaces, hyphens, apostrophes, and periods")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required on server")]
        [StringLength(35, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 35 characters")]
        [RegularExpression(@"^[a-zA-Z\s\-'\.]+$", ErrorMessage = "Last name can only contain letters, spaces, hyphens, apostrophes, and periods")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Birth date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "At least one nationality must be selected")]
        [MinLength(1, ErrorMessage = "Please select at least one nationality")]
        [MaxLength(3, ErrorMessage = "You can select maximum 3 nationalities")]
        [Display(Name = "Nationalities")]
        public List<string> SelectedNationalities { get; set; } = new List<string>();

        [Required(ErrorMessage = "Gender selection is required")]
        [RegularExpression(@"^(Male|Female|Other|PreferNotToSay)$", ErrorMessage = "Please select a valid gender option")]
        public string SelectedGender { get; set; } = string.Empty;

        [Display(Name = "Java")]
        public bool HasJavaSkill { get; set; }

        [Display(Name = "Python")]
        public bool HasPythonSkill { get; set; }

        [Display(Name = "ASP.NET")]
        public bool HasAspNetSkill { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email format is invalid")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email confirmation is required")]
        [Compare("Email", ErrorMessage = "Email and confirmation do not match")]
        [Display(Name = "Confirm Email")]
        public string EmailConfirmation { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [StringLength(128, MinimumLength = 12, ErrorMessage = "Password must be between 12 and 128 characters (server validation)")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_\-+=\[{\]};:'"",<.>/?\\|`~])[A-Za-z\d!@#$%^&*()_\-+=\[{\]};:'"",<.>/?\\|`~]{12,}$",
            ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character (server validation)")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Profile photo is required")]
        [Display(Name = "Profile Photo")]
        public IFormFile? UploadedPhoto { get; set; }

        public string PhotoPath { get; set; } = string.Empty;
    }
}
