using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IPLWeb.Models
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Required]
        [StringLength(20)]
        public string Extension { get; set; }

        [NotMapped]
        public SingleFileUpload File { get; set; }

        public virtual ICollection<Match> Team1Matches { get; set; }

        public virtual ICollection<Match> Team2Matches { get; set; }
    }
}
