using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CVCraft.Models.ViewModels {
    public class CVEditViewModel {
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "First name must be between 1 and 50 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Last name must be between 1 and 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Birth date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; } = DateTime.Now.AddYears(-25);

        [Required(ErrorMessage = "Please select at least one nationality")]
        [Display(Name = "Nationalities")]
        public List<string> SelectedNationalities { get; set; } = new List<string>();

        [Required(ErrorMessage = "Please select your gender")]
        public string SelectedGender { get; set; } = string.Empty;

        [Display(Name = "Java")]
        public bool HasJavaSkill { get; set; }

        [Display(Name = "Python")]
        public bool HasPythonSkill { get; set; }

        [Display(Name = "ASP.NET")]
        public bool HasAspNetSkill { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please confirm your email")]
        [Compare("Email", ErrorMessage = "Email addresses do not match")]
        [Display(Name = "Confirm Email")]
        public string EmailConfirmation { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters")]
        [RegularExpression(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[!@#$%^&*()_\-+=\[{\]};:'"",<.>/?\\|`~]).{8,}$",
            ErrorMessage = "Password must contain at least one letter, one digit, and one special character")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please choose a profile photo")]
        [Display(Name = "Profile Photo")]
        public IFormFile? UploadedPhoto { get; set; }
        public string PhotoPath { get; set; } = string.Empty;

        // Dropdown/Selection Options
        public IEnumerable<string> GenderOptions => new List<string>
        {
            "Male",
            "Female"
        };

        public IEnumerable<SelectListItem> NationalityOptions { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Text = "Select...", Value = "", Disabled = true },
            new SelectListItem { Text = "Lebanese", Value = "Lebanese" },
            new SelectListItem { Text = "Syrian", Value = "Syrian" },
            new SelectListItem { Text = "Egyptian", Value = "Egyptian" },
            new SelectListItem { Text = "Jordanian", Value = "Jordanian" },
            new SelectListItem { Text = "Palestinian", Value = "Palestinian" },
            new SelectListItem { Text = "Iraqi", Value = "Iraqi" },
            new SelectListItem { Text = "Other", Value = "Other" }
        };

        // Computed Properties
        public string FullName => $"{FirstName} {LastName}".Trim();
        public int Age => DateTime.Now.Year - BirthDate.Year - (DateTime.Now.DayOfYear < BirthDate.DayOfYear ? 1 : 0);
        public List<string> SelectedSkills {
            get {
                var skills = new List<string>();
                if (HasJavaSkill) skills.Add("Java");
                if (HasPythonSkill) skills.Add("Python");
                if (HasAspNetSkill) skills.Add("ASP.NET");
                return skills;
            }
        }

        // Constructor with initialization
        public CVEditViewModel() {
            BirthDate = DateTime.Now.AddYears(-25); // Default to 25 years old
        }
    }
}
