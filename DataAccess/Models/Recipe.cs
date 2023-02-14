using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The title is too long, try a shorter one (500 chars limit)")]
        public string Title { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "The description is too long, try a shorter one (1000 chars limit)")]
        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
