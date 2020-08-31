using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string EasyWords = "charades_easy";
            string ModerateWords = "charades_moderate";
            string HardWords = "charades_hard";
            string VeryHardWords = "charades_very_hard";
            string idioms = "idioms_popular";
            string Animals = "animal_names";
            string PopularTVShows = "tv_show_names_popular";
            string PopularBooks = "book_names_popular";
            string PopularMovies = "movie_names_popular";
            string people_character_names_popular = "people_character_names_popular";


            WebClient client = new WebClient();
            
            string RandomWords = client.DownloadString("https://www.wordgenerator.net/application/p.php?id="+ people_character_names_popular + "&type=1&spaceflag=false");
            string[] Wordlist = RandomWords.Split(",");


            foreach (string author in Wordlist)
                Console.WriteLine(author);
        }
    }
}
