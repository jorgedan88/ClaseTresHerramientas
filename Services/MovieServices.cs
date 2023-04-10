using ClaseTresHerramientas.Models;

namespace ClaseTresHerramientas.Service{}

    public static class MovieService{
        static List<Movie> Movies {get; set;}

        static MovieService(){
            Movies = new List<Movie>{
            new Movie { Name = "Back to the future", Code = "BTF", Category = "Sci fi", Minutes = 100},                        
            new Movie { Name = "Avatar", Code = "AVT", Category = "Sci fi", Minutes = 500, Review = "Por que no aparece la reseña"} ,
            new Movie { Name = "Hannibal", Code = "HNL", Category = "Terror", Minutes = 110}

            };
    }

    public static List<Movie> GetAll() => Movies;

    public static void Add(Movie obj){
        if(obj == null){
            return;
        }
        Movies.Add(obj);
    }
    public static void Delete(string code){
        var movieToDelete = Get(code);

        if (movieToDelete != null){
            Movies.Remove(movieToDelete);
        }
    }
    public static Movie? Get(string code) => Movies.FirstOrDefault(x => x.Code.ToLower() == code.ToLower());//recibe un stting (el codigo)
}