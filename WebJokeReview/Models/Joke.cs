using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebJokeReview.Models
{
    public class Joke
    {
        public int id { get; set; }
        public string jokeQuestion { get; set; }
        public string jokeAnswer { get; set; }

        public string userCode { get; set; }
        public string userName { get; set; }

        public Joke()
        {

        }
    }
}
