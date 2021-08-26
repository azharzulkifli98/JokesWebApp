using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebAppMVC.Models
{
    public class Joke
    {
        public int Id { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 1)]
        public string JokeQuestion { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 1)]
        public string JokeAnswer { get; set; }

        public string Author { get; set; }

        // want them to fall under one of five groups: pun, meta, sarcasm, 
        public string Genre { get; set; }
        public string Date { get; set; }

        public Joke()
        {
            Date = DateTime.Today.ToString("d");
        }
    }
}
