using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository

// A challenge for the students now:
/*
Users have been complaining about their family friendly content. Some users have been reporting that when filtering for family friendly, they're getting some content with inappropriate maturity ratings. We need to fix this. Currently the maturity rating and family friendly bool are independent, we need to tie them together. If something is rated R (or another similar rating), it should never be able to have a IsFamilyFriendly of true. 
We need you to refactor the code StreamingContent class. To help narrow down our problem, we want to replace the MaturityRating with a default set of options. Based on those options, we want our IsFamilyFriendly to return the appropriate true or false.

    Make a maturity rating enum with default options (constants)
update IsFamilyFriendly to use the Getter and the Maturity Rating 
*/


{


    // POCO
    // Plain Old C# Object

    public class StreamingContent
    {
        public StreamingContent() { }
        public StreamingContent(string title, string description, MaturityRating maturityRating, double starRating, int releaseYear, GenreType genre)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            ReleaseYear = releaseYear;
            TypeGenre = genre;
        }
        // this is a Property 
        public string Title { get; set; }
        public string Description { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public double StarRating { get; set; }
        public int ReleaseYear { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                if ((int)MaturityRating < 3) // casting: turning enum into an int
                    return true;
                // or 

                return (int)MaturityRating < 3;

                //or

                // Figure out if it is Family Friendly and return true or false
                // an option for learning... if (MaturityRating == MaturityRating.G) 
                // {
                //     return true;
                // }
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                        return true;
                    case MaturityRating.R:
                    case MaturityRating.PG13:
                    case MaturityRating.NC17:
                    case MaturityRating.TV_14:
                    case MaturityRating.TV_MA:
                        return false;
                    default:
                        return false;



                }

            }
        }
        public GenreType TypeGenre { get; set; }




    }


    public enum GenreType
    {
        ActionAdventure,
        Thriller,
        Horror,
        Comedy,
        Bromance,
        Mystery,
        Scifi
    }

    public enum MaturityRating
    {
        G,
        PG,
        TV_Y,
        PG13,
        R,
        NC17,
        TV_PG,
        TV_14,
        TV_MA
    }







}
