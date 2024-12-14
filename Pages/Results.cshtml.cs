using EncuestaRazor.Models;
using EncuestaRazor.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EncuestaRazor.Pages;

public class Results : PageModel
{
    private readonly ServiceSurvey _serviceSurvey;

    public Results(ServiceSurvey serviceSurvey)
    {
        _serviceSurvey = serviceSurvey;
    }
    public List<Survey> Surveys { get; set; }
    
    public void OnGet()
    {
        Surveys = _serviceSurvey.Surveys.ToList();        
    }
}