using EncuestaRazor.Models;

namespace EncuestaRazor.Services;

public class ServiceSurvey
{
    public List<Survey> Surveys { get; set; } = new List<Survey>();

    public void Add(Survey survey)
    {
        Surveys.Add(survey);
    }
}