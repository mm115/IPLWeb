using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IPLWeb.Models
{
    public class SingleFileUpload
    {
        [Required]
        [Display(Name = "Image File")] // this code will pick image
        public IFormFile FormFile { get; set; }
    }
}
