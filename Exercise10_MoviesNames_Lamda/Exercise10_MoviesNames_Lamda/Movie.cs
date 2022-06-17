using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_MoviesNames_Lamda
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } 
    }

    public class MovieList
    {
        public int Code { get; set; }
        public int MovieId { get; set; }
        public List<string> MovieSequels { get; set; }
    }
}
