using CVCraft.Mappers;
using CVCraft.Models.ViewModels;
using CVCraft.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CVCraft.Pages
{
    public class ManageCVsModel(ICVInfoService cvInfoService) : PageModel
    {
        public readonly ICVInfoService _cvInfoService = cvInfoService;
        public required List<CVSummaryViewModel> cVSummaryViewModels;

        public async void OnGetAsync()
        {
            cVSummaryViewModels = (await _cvInfoService.GetAllAsync()).Select(x => CVMapper.ToCVSummaryViewModel(x)).ToList();
        }

        public async Task<IActionResult> OnPost(Guid deleteId) {
            if (!(await _cvInfoService.TryDeleteCV(deleteId)))
                ModelState.AddModelError(string.Empty, "Error occured while trying to delete CV!");
            cVSummaryViewModels = (await _cvInfoService.GetAllAsync()).Select(x => CVMapper.ToCVSummaryViewModel(x)).ToList();
            return Page();
        }
    }
}
