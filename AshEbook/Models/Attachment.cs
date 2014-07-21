using System;
using System.ComponentModel.DataAnnotations;

namespace AshEbook.Models
{
    public class Attachment 
    {
        public int Id{ get; set; }

        public DateTime DateCreated{ get; set; }

        [Display(Name = "Adı")]
        public string Name { set; get; }

        [Display(Name = "Kaldırılma Zamanı")]
        public DateTime? DateRemoved { set; get; }

        [Display(Name = "Yolu")]
        public string Path { get; set; }

    }
}
