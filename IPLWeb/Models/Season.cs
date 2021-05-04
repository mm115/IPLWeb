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
        public int SeasonID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Season Year")]
        public string SeasonYear { get; set; }

        public virtual ICollection<Match> Matches { get; set; }

    }
}
