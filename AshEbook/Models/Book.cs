using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AshEbook.Models
{
    public class Book
    { 
        public Book()
        {
            DateCreated = DateTime.Now;
        }

        public int Id { set;get;}

        [DataType(DataType.DateTime)]
        public DateTime DateCreated{ get; set; }

        [Required]
        [MinLength(3)]
        public string Title{ get; set; }

        [AllowHtml]
        public string Description{ get; set; }

        public Attachment Attachment{ get; set; }

        public virtual ApplicationUser UserCreated{ get; set; }

        public int ViewCount { get; set; }

    }
}