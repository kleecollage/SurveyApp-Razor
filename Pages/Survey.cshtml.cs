using EncuestaRazor.Models;
using EncuestaRazor.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EncuestaRazor.Pages;
public class SurveyModel : PageModel
{
    private readonly ServiceSurvey _serviceSurvey;

    public SurveyModel(ServiceSurvey serviceSurvey)
    {
        _serviceSurvey = serviceSurvey;
    }
    
    [BindProperty] public Survey Survey { get; set; }
    
    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        _serviceSurvey.Add(Survey);
        return RedirectToPage("Thanx");
    }
}