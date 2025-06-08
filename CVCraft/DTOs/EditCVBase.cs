namespace CVCraft.DTOs {
    public class EditCVBase {
        public Guid Id { get; set; } = Guid.NewGuid();

        // Personal Information
        public required string FirstName { get; set; } = string.Empty;
        public required string LastName { get; set; } = string.Empty;
        public required DateTime BirthDate { get; set; }
        public required List<string> Nationalities { get; set; } = new();
        public required string Gender { get; set; }

        // Skills
        public bool HasJavaSkill { get; set; }
        public bool HasPythonSkill { get; set; }
        public bool HasAspNetSkill { get; set; }

        // Contact Information
        public required string Email { get; set; } = string.Empty;
        public required string Password { get; set; } = string.Empty;
        public string PhotoPath { get; set; } = string.Empty;
    }
}
