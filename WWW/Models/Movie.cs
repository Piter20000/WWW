
using System;
using System.ComponentModel.DataAnnotations;
using WWW.Models.Customer_Validations;

namespace WWW.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        [Display(Name = "Added Date")]
        public DateTime? DateAdded { get; set; }

        [Display(Name = "Release Date")]
        [Check_Movie_Releas_Data]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        [Display(Name = "Number of Available")]
        [Range(0,50)]
        public byte NumberAvailable { get; set; }
    }
}