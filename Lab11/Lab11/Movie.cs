using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    public class Movie
    {
        private string _category;
        private string _title;

        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }

        public Movie()
        {

        }

        public void GetSciFi()
        {
            var movieList = PrintList();
            var scifiTitles = new List<string>();

            foreach (var movie in movieList)
            {
                if (movie._category == "scifi")
                {
                    scifiTitles.Add(movie._title);
                    

                }
            }
            scifiTitles.Sort();
            foreach (var film in scifiTitles)
            {
                Console.WriteLine(film);
            }
        }

        public void GetDrama()
        {
            var movieList = PrintList();
            var dramaTitles = new List<string>();


            foreach (var movie in movieList)
            {
                if (movie._category == "drama")
                {
                    dramaTitles.Add(movie._title);
                }
            }
            dramaTitles.Sort();
            foreach (var film in dramaTitles)
            {
                Console.WriteLine(film);
            }
        }

        public void GetAnimated()
        {
            var movieList = PrintList();
            var animatedTitles = new List<string>();

            foreach (var movie in movieList)
            {
                if (movie._category == "animated")
                {
                    animatedTitles.Add(movie._title);
                }
            }
            animatedTitles.Sort();
            foreach (var film in animatedTitles)
            {
                Console.WriteLine(film);

            }
        }

        public void GetHorror()
        {
            var movieList = PrintList();
            var horrorTitles = new List<string>();

            foreach (var movie in movieList)
            {
                if (movie._category == "horror")
                {
                    horrorTitles.Add(movie._title);
                }
            }
            horrorTitles.Sort();
            foreach (var film in horrorTitles)
            {
                Console.WriteLine(film);
            }
        }

        private List<Movie> PrintList()
        {
            var movieList = new List<Movie>();

            movieList.Add(new Movie("Star Wars", "scifi"));
            movieList.Add(new Movie("Aliens", "scifi"));
            movieList.Add(new Movie("The Notebook", "drama"));
            movieList.Add(new Movie("La La Land", "drama"));
            movieList.Add(new Movie("Toy Story", "animated"));
            movieList.Add(new Movie("A Bug's Life", "animated"));
            movieList.Add(new Movie("Evil Dead", "horror"));
            movieList.Add(new Movie("The Strangers", "horror"));
            movieList.Add(new Movie("Hush", "horror"));
            movieList.Add(new Movie("It", "horror"));

            return movieList;
        }
    }

}
