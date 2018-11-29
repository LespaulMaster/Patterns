using Showroom.Common;
using Showroom.Specification;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Showroom
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var movies = program.GetMovies();

            var newSpec = (new OldMovieSpecification()).Not();

            var oldMovies = movies.Where(x => newSpec.IsSatisfied(x)).ToList();

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(oldMovies));

            Console.ReadLine();

        }

        public IReadOnlyList<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Id=1,
                    Name="Test",
                    Year=1930
                },
                new Movie
                {
                    Id=2,
                    Name="Test2",
                    Year=1990
                }
            };
        }


    }
}
