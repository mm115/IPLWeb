using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IPLWeb.Models
{
    public class Match
    {
        [Key]
        public int TeamID { get; set; } // this is primary key

        [Required]
        [StringLength(100)]
        [Display(Name = "Venue Name")]
        public string VenueName { get; set; } // it will show the address of match

        [Required]
        [Display(Name = "Match Date")]
        public DateTime MatchDate { get; set; } // it will show the match date

        [Required]
        [StringLength(100)]
        [Display(Name = "Match Time")]
        public string MatchTime { get; set; } // it show the match time

        [Required]
        [Display(Name = "Season Year")]
        public int SeasonID { get; set; } // this is foreign key

        [ForeignKey("SeasonID")]
        [InverseProperty("Matches")]
        public virtual Season Season { get; set; } 

        [Required]
        [Display(Name = "Team 1")]
        public int TeamID1 { get; set; }

        [Required]
        [Display(Name = "Team 2")]
        public int TeamID2 { get; set; }

        [ForeignKey("TeamID1")]
        [InverseProperty("Team1Matches")]
        public virtual Team Team1 { get; set; }

        [ForeignKey("TeamID2")]
        [InverseProperty("Team2Matches")]
        public virtual Team Team2 { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
