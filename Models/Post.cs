using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Post
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Language { get; set; }
        [MinLength(20)]
        public string Comment { get; set; }
    }
}