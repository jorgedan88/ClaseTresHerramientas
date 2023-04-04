using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClaseTres.Models;
using ClaseTres.Services;

namespace ClaseTres.Pages;

public class IndexModel : PageModel
{
    public List<Movie> MovieList { get; set;}
    public IndexModel()
    {
    }

    public void OnGet()
    {
        MovieList = MovieService.GetAll();
    }
}

