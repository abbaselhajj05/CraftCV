namespace CVCraft.Models.ViewModels {
    public class CVSummaryViewModel {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}";
        public DateTime BirthDate { get; set; }
        public string FormattedBirthDate => BirthDate.ToString("MMMM dd, yyyy");
        public int Age => DateTime.Now.Year - BirthDate.Year;
        public List<string> Nationalities { get; set; } = new();
        public string NationalityDisplay => string.Join(", ", Nationalities);
        public string GenderDisplay { get; set; } = string.Empty;
        public List<string> Skills { get; set; } = new();
        public string SkillsDisplay => string.Join(", ", Skills);
        public string Email { get; set; } = string.Empty;
        public string? PhotoPath { get; set; }
        public int RandomNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FormattedCreatedAt => CreatedAt.ToString("MMMM dd, yyyy 'at' h:mm tt");
    }
}
