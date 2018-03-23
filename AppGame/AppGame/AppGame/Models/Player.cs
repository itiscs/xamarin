using System;
using System.Collections.Generic;
using System.Text;

namespace AppGame.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Highscore { get; set; }
        public DateTime ScoreDate { get; set; }
    }
}
