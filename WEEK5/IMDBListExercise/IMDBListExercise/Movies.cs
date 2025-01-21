using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBListExercise
{
    public class Movies
    {
        private double _movieRating; // Encapsulation mantigi kullanilarak field tanimlamasi yapildi...
        private string _name;

        public Movies(double rating, string name)
        {
            _movieRating = rating;
            _name = name;
            
        }

        public double MovieRating
        {
            get => _movieRating;
            set => _movieRating = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
