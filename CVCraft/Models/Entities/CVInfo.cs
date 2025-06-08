
namespace CVCraft.Models.Entities {
    public class CVInfo {
        public Guid Id { get; set; }

        // Personal Information
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public List<string> Nationalities { get; set; } = new();
        public string Gender { get; set; }

        // Skills
        public bool HasJavaSkill { get; set; }
        public bool HasPythonSkill { get; set; }
        public bool HasAspNetSkill { get; set; }

        // Contact Information
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PhotoPath { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
