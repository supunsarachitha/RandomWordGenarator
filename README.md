# RandomWordGenarator
this is a sample Concept of random dictionary words generator by C# 


This Code call https://www.wordgenerator.net API. It will returns a set of 50 different words each time.
we can get different types of words by changing "id"

ex id="charades_easy" returns simple words

```sh
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
                
                
```                


