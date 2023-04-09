using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClaseTresHerramientas.Models;
using ClaseTresHerramientas.Service;

namespace ClaseTresHerramientas.Pages;

public class IndexModel : PageModel{

    public List<Movie> MovieList {get; set;}
    [BindProperty]
   public Movie NewMovie {get; set; }

    public IndexModel()
    {

    }

    public void OnGet(){
        MovieList = MovieService.GetAll();
    }

    public IActionResult OnPost(){
        if(!ModelState.IsValid){
        return RedirectToPage("/Error");
        }
        MovieService.Add(NewMovie);
        return RedirectToAction("get");
    }
}




