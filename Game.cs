﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_DeBord_Joshua
{
    class Game : IGenre//Im trying to rush these assignments and I don't completely understand what the comments for these should be. Sorry.
    {
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Game(string esrbParam, string genreParam, string titleParam) 
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting! Game ON!");
        }
        public string Describe()
        {
            return $"{Title} is a {Genre} game, rated {Esrb}!";

        }

    }
}
