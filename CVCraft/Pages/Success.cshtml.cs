using CVCraft.Mappers;
using CVCraft.Models.Entities;
using CVCraft.Models.ViewModels;
using CVCraft.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CVCraft.Pages
{
    public class SuccessModel(ICVInfoService service) : PageModel
    {
        public readonly ICVInfoService _service = service;
        [BindProperty(SupportsGet = true)]
        public BindingModel Input { get; set; } = new();
        public CVSummaryViewModel ViewModel { get; set; } = new();

        public async Task<IActionResult> OnGet() {
            // Attempt to fetch the CVInfo from the service
            CVInfo? cvInfo = await _service.GetCV(Input.Id);

            // Handle case where CV is not found
            if (cvInfo is null) {
                ModelState.AddModelError(string.Empty, "CV not found.");
                return Page();
            }

            // Map to ViewModel
            ViewModel = CVMapper.ToCVSummaryViewModel(cvInfo, Input.randomNumber);

            return Page();
        }

    }

    public class BindingModel {
        public Guid Id { get; set; }
        public int randomNumber { get; set; }
    }
}
