using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieList
{
    internal class Movie
    {
        private string? _name;
        private double _rating;

        public Movie(string? name, double rating)
        {
            Name = name;
            Rating = rating;
        }

        public string? Name { get => _name; set => _name = value; }
        public double Rating { get => _rating; set => _rating = value; }
    }
}
