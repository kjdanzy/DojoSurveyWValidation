using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWValidation.Models
{

    public class InfoEntry
    {
        [Required(ErrorMessage ="Your name is required!")]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Language { get; set; }
        [MinLength(20, ErrorMessage = "Your comment must be at least 20 characteres.")]        
        public string Comment { get; set; }

    }

}