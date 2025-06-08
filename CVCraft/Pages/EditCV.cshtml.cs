using CVCraft.Mappers;
using CVCraft.Models.BindingModels;
using CVCraft.Models.Entities;
using CVCraft.Models.ViewModels;
using CVCraft.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CVCraft.Pages
{
    public class EditCVModel(ICVInfoService cvInfoService, IFileUploadService fileUploadService) : PageModel
    {
        public readonly ICVInfoService _cvInfoService = cvInfoService;
        public readonly IFileUploadService _fileUploadService = fileUploadService;

        public CVEditViewModel ViewModel { get; set; } = new();
        [BindProperty]
        public CVEditBindingModel Input { get; set; } = new();
        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            CVInfo? cvInfo = await _cvInfoService.GetCV(id);
            if (cvInfo is null) {
                ModelState.AddModelError(string.Empty, "No CV associated with this ID");
                return Page();
            }
            Input.Id = id;
            ViewModel = CVMapper.ToCVEditViewModel(cvInfo!);
            return Page();
        }

        public async Task<IActionResult> OnPost() {

            if (Input.UploadedPhoto is null) {
                ModelState.AddModelError(string.Empty, "Please upload a profile picture");
            }

            if (!ModelState.IsValid) {
                return Page(); // Stay on the same page if validation fails
            }

            // Handle successful submission

            Input.PhotoPath = await _fileUploadService.UploadAsync(Input.UploadedPhoto!, "uploads");

            var dto = CVMapper.ToDto(Input);
            if (!await _cvInfoService.TryUpdateCV(dto))
                return Page();
            return RedirectToPage("Success", new { id = dto.Id, randomNumber = new Random().Next(int.MaxValue) });
        }
    }
}
