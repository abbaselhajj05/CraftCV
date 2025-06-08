using CVCraft.Models.Entities;

namespace CVCraft.DTOs {
    public class UpdateCVInfoCommand : EditCVBase {
        public void UpdateCV(CVInfo cvInfo) {
            cvInfo.FirstName = FirstName;
            cvInfo.LastName = LastName;
            cvInfo.BirthDate = BirthDate;
            cvInfo.Nationalities = Nationalities;
            cvInfo.Gender = Gender;

            cvInfo.HasJavaSkill = HasJavaSkill;
            cvInfo.HasPythonSkill = HasPythonSkill;
            cvInfo.HasAspNetSkill = HasAspNetSkill;

            cvInfo.Email = Email;
            cvInfo.Password = Password;
            cvInfo.PhotoPath = PhotoPath;
        }
    }
}
