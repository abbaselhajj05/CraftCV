using CVCraft.DTOs;
using CVCraft.Models.BindingModels;
using CVCraft.Models.Entities;
using CVCraft.Models.ViewModels;
using System.Reflection;

namespace CVCraft.Mappers {
    public class CVMapper {
        public static CreateCVInfoCommand ToDto(CVCreateBindingModel model) {
            return new CreateCVInfoCommand
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                BirthDate = model.BirthDate,
                Nationalities = model.SelectedNationalities,
                Gender = model.SelectedGender,
                HasJavaSkill = model.HasJavaSkill,
                HasPythonSkill = model.HasPythonSkill,
                HasAspNetSkill = model.HasAspNetSkill,
                Email = model.Email,
                Password = model.Password,
                PhotoPath = model.PhotoPath,
            };
        }

        public static UpdateCVInfoCommand ToDto(CVEditBindingModel model) {
            return new UpdateCVInfoCommand
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                BirthDate = model.BirthDate,
                Nationalities = model.SelectedNationalities,
                Gender = model.SelectedGender,
                HasJavaSkill = model.HasJavaSkill,
                HasPythonSkill = model.HasPythonSkill,
                HasAspNetSkill = model.HasAspNetSkill,
                Email = model.Email,
                Password = model.Password,
                PhotoPath = model.PhotoPath,
            };
        }

        public static CVSummaryViewModel ToCVSummaryViewModel(CVInfo info, int randomNumber = 0) {
            List<string> Skills = new();
            if (info.HasJavaSkill) Skills.Add("Java");
            if (info.HasPythonSkill) Skills.Add("Python");
            if (info.HasAspNetSkill) Skills.Add("ASP.NET");

            return new CVSummaryViewModel
            {
                Id = info.Id,
                FirstName = info.FirstName,
                LastName = info.LastName,
                BirthDate = info.BirthDate,
                Nationalities = info.Nationalities,
                GenderDisplay = info.Gender,
                Skills = Skills,
                Email = info.Email,
                CreatedAt = info.CreatedAt,
                PhotoPath = info.PhotoPath,
                RandomNumber = randomNumber
            };
        }

        public static CVEditViewModel ToCVEditViewModel(CVInfo cvInfo) {

            return new CVEditViewModel
            {
                FirstName = cvInfo.FirstName,
                LastName = cvInfo.LastName,
                BirthDate = cvInfo.BirthDate,
                SelectedNationalities = cvInfo.Nationalities,
                SelectedGender = cvInfo.Gender,
                HasJavaSkill = cvInfo.HasJavaSkill,
                HasPythonSkill = cvInfo.HasPythonSkill,
                HasAspNetSkill = cvInfo.HasAspNetSkill,
                Email = cvInfo.Email,
                Password = cvInfo.Password,
                PhotoPath = cvInfo.PhotoPath,
            };
        }
    }
}
