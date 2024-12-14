using System.ComponentModel.DataAnnotations;
using EncuestaRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EncuestaRazor.Pages;

public class TagHelpers : PageModel
{
    [DataType(DataType.EmailAddress)]
    [Required]
    [Display(Name = "Correo Electrónico")]
    public string Email { get; set; }
    
    public List<SelectListItem> Numbers = Enumerable.Range(1, 10)
        .Select(n => new SelectListItem
        {
            Value = n.ToString(),
            Text = n.ToString()
        }).ToList();

    public int SelectedNumber { get; set; } = 7;

    [BindProperty] public int SelectedPerson { get; set; } = 3;
    public List<Person> Persons { get; set; }
    public DocumentState State { get; set; }
    public string Observations { get; set; }
    
    public void OnGet()
    {
        Persons = new List<Person>
        {
            new Person { Id = 1, Name = "John" },
            new Person { Id = 2, Name = "Geroge" },
            new Person { Id = 3, Name = "Paul" },
            new Person { Id = 4, Name = "Ringo" },
        };
    }
}














