using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBlogProject.Models
{
    public class Post
    {
        public int Id { get; set; }

        public int BlogId { get; set; }

        public string AuthorId { get; set; }

        [Required]
        [StringLength(75, ErrorMessage ="The {0} must be at least {2} and no more than {1}", MinimumLength = 2)]
        public string Title { get; set; }

        [StringLength(150, ErrorMessage = "The {0} must be at least {2} and no more than {1}", MinimumLength = 2)]
        public string Abstract { get; set; }

        [Required]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Created Date")]
        public DateTime Created { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Last Edited")]
        public DateTime? Updated { get; set; }

        public bool IsReady { get; set; }

        public string Slug { get; set; }

        public byte[] ImageData { get; set; }

        public string ContentType { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }



    }
}
