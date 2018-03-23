using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PlayerService.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Highscore { get; set; }
        public DateTime ScoreDate { get; set; }
    }

    public class PlayersDB:DbContext
    {
        public PlayersDB():base("PlayersDB")
        {           
        }

        public DbSet<Player> Players { get; set; }

    }



}