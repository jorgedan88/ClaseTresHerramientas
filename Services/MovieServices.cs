using ClaseTresHerramientas.Models;

namespace ClaseTresHerramientas.Service{}

    public static class MovieService{
        static List<Movie> Movies {get; set;}

        static MovieService(){
            Movies = new List<Movie>{
            new Movie { Name = "Back to the future", Code = "BTF", Category = "Sci fi", Minutes = 100},                        
            new Movie { Name = "Avatar", Code = "AVT", Category = "Sci fi", Minutes = 500} ,
            new Movie { Name = "Hannibal", Code = "HNL", Category = "Terror", Minutes = 110}

            };
    }

    public static List<Movie> GetAll() => Movies;

// ADD
// DELETE
// UPDATE
}