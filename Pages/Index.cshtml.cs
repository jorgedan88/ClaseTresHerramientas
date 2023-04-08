using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClaseTresHerramientas.Models;
using ClaseTresHerramientas.Service;

namespace ClaseTresHerramientas.Pages;

public class IndexModel : PageModel{


    public List<Movie> MovieList {get; set;}


    public IndexModel()
    {

    }

    public void OnGet()
    {
        // MovieList = MovieService.GetAll();
        MovieList = MovieService.GetAll();
    }
}