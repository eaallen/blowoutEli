using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Conecting_to_database_home.Models
{
    [Table("Team")]
    public class Team
    {
        [Key]
        public int teamID { get; set; }
        public String teamName { get; set; }
    }
}