using System;
namespace ProgramTest
{
    class Movie
    {
        public string title;
        public string director;
        // private - This variable will only be accessible within this class
        private string rating;


        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }


        // Propreties for Rating

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

    }

}

