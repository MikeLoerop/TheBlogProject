using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TheBlogProject.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public string AuthorID { get; set; }
        public string ModeratorId { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and no more than {1}", MinimumLength = 2)]
        [Display(Name ="Comment")]
        public string Body { get; set; }


        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Moderated { get; set; }
        public DateTime? Deleted { get; set; }

        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and no more than {1}", MinimumLength = 2)]
        [Display(Name = "Comment")]
        public string? ModeratedBody { get; set; }

        //Navigation Properties
        public virtual Post post { get; set; }

        public virtual IdentityUser Author { get; set; }

        public virtual IdentityUser Moderator { get; set; }


    }
}
