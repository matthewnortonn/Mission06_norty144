using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_norty144.Models
{
    //variables for inputs
    //making some variables required and with special messages for each of them
    public class MovieResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }


        [Required(ErrorMessage = "A title is required")]
        public string Title { get; set; }


        [Required(ErrorMessage = "A year is required")]
        public string Year { get; set; }


        [Required(ErrorMessage = "A director is required")]
        public string Director { get; set; }


        [Required(ErrorMessage = "A rating is required")]
        public string Rating { get; set; }


        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }


        //Build foreign key relationship
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
