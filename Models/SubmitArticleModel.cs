using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CISTermProject634.Models
{
    public class NewArticleModel
    {
        [Required(ErrorMessage="Please include a title for your website submission!")]
        public string title { get; set; }

        [Required(ErrorMessage = "Please include a website address for your submission!")]
        public string Site { get; set; }
    }
}