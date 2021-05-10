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
        public int CommentID { get; set; } // this is primary key

        [Required]
        [StringLength(1000)]
        [Display(Name = "Comment Text")]
        public string CommentText { get; set; } // code for comment

        [Display(Name = "Comment Date")]
        public DateTime CommentDate { get; set; } // it will show the date opf each comment

        [Required]
        [StringLength(200)]
        [Display(Name = "User ID")]
        public string UserID { get; set; } // this will show id of user

        [Required]
        public int MatchID { get; set; } // this is foreign key

        [ForeignKey("MatchID")]
        [InverseProperty("Comments")]
        public Match Match { get; set; }

        
    }
}
