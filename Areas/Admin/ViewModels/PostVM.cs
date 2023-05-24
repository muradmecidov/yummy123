using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Areas.Admin.ViewModels
{
    public class PostVM
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
    }
}

