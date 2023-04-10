using System.Security.Permissions;
using ClaseTresHerramientas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase3.pages
{
    public class MovieDetailModel : PageModel
    {
        public Movie MovieDetail {get; set; } = new();
        public void OnGet(string code)
        {
            var responseServiceData = MovieService.Get(code);
            if(responseServiceData != null){
                MovieDetail = responseServiceData;
            }
        }

        public IActionResult OnPostDelete(string code){
            if(code != null){
                MovieService.Delete(code);
            }
            return RedirectToPage("Index");
        }
    }




}
