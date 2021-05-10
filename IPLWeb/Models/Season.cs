using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IPLWeb.Models
{
    public class Season
    {
        [Key]
        public int SeasonID { get; set; } // this is primary key

        [Required]
        [StringLength(100)]
        [Display(Name = "Season Year")]
        public string SeasonYear { get; set; } // this show the year of season

        public virtual ICollection<Match> Matches { get; set; }

    }
}
