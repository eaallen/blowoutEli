using First_database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace First_database.DAL
{
    public class BasketballContext : DbContext
    {
        public BasketballContext()
            : base("BasketballContext")
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<NewPlayer> NewPlayers { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}