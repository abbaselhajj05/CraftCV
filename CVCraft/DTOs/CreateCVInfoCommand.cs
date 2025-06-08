using CVCraft.Models.Entities;

namespace CVCraft.DTOs {
    public class CreateCVInfoCommand : EditCVBase {

        public CVInfo ToCVInfo() {
            return new CVInfo
            {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                BirthDate = BirthDate,
                Nationalities = Nationalities,
                Gender = Gender,
                HasJavaSkill = HasJavaSkill,
                HasPythonSkill = HasPythonSkill,
                HasAspNetSkill = HasAspNetSkill,
                Email = Email,
                Password = Password,
                PhotoPath = PhotoPath
            };
        }
    }
}
