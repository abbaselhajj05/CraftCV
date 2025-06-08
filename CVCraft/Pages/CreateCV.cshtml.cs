using CVCraft.Mappers;
using CVCraft.Models.BindingModels;
using CVCraft.Models.ViewModels;
using CVCraft.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CVCraft.Pages
{
    public class CreateCVModel : PageModel
    {
        public readonly ICVInfoService _cvInfoService;
        public readonly IArithmeticService _arithmeticService;
        public readonly IFileUploadService _fileUploadService;
        public CreateCVModel(ICVInfoService cvInfoService, IArithmeticService arithmeticService, IFileUploadService fileUploadService) {
            _cvInfoService = cvInfoService;
            _arithmeticService = arithmeticService;
            _fileUploadService = fileUploadService;
        }
        public CVCreateViewModel ViewModel { get; set; } = new();
        [BindProperty]
        public CVCreateBindingModel Input { get; set; } = new();
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost() {

            if (_arithmeticService.Sum(Input.VerificationOperand1, Input.VerificationOperand2) != Input.VerificationSum)
                ModelState.AddModelError(string.Empty, "Human verification has failed");

            if (Input.UploadedPhoto is null) {
                ModelState.AddModelError(string.Empty, "Please upload a profile picture");
            }

            if (!ModelState.IsValid) {
                return Page(); // Stay on the same page if validation fails
            }

            // Handle successful submission

            Input.PhotoPath = await _fileUploadService.UploadAsync(Input.UploadedPhoto!, "uploads");

            var dto = CVMapper.ToDto(Input);
            await _cvInfoService.AddCVAsync(dto);
            return RedirectToPage("Success", new {id = dto.Id, randomNumber = new Random().Next(int.MaxValue)});
        }
    }
}
