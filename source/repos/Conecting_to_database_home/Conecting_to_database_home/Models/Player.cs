﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Conecting_to_database_home.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int playerID { get; set; }
        public String playerLastName { get; set; }
        public String playerFirstName { get; set; }

        [ForeignKey("Position")]
        public virtual String positionCode { get; set; }
        public virtual Position Position { get; set; }

        [ForeignKey("Team")]
        public virtual int teamID { get; set; }
        public virtual Team Team { get; set; }
    }
}