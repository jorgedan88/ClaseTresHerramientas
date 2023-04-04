using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClaseTres.Models;

namespace ClaseTres.Services;

public static class MovieService
{
    static List<Movie> Movies { get; set; }


    static MovieService()
    {
        Movies = new List<Movie>
        {
            new Movie { Name = "Pepe1", Code = "001", Category = "Sci fi", Minutes = 110},
            new Movie { Name = "Pepe2", Code = "001", Category = "Sci fi", Minutes = 110 },
            new Movie { Name = "Pepe3", Code = "001", Category = "Sci fi", Minutes = 110 }
        };
    }

    public static List<Movie> GetAll() => Movies;
}

