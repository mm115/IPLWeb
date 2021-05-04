using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IPLWeb.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Comment Text")]
        public string CommentText { get; set; }

        [Display(Name = "Comment Date")]
        public DateTime CommentDate { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "User ID")]
        public string UserID { get; set; }

        [Required]
        public int MatchID { get; set; }

        [ForeignKey("MatchID")]
        [InverseProperty("Comments")]
        public Match Match { get; set; }

        
    }
}
