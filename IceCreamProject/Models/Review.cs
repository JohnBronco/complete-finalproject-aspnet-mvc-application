using System.ComponentModel.DataAnnotations;

namespace IceCreamProject.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        public string ReviewPhotoURL { get; set; }

        public string FullName { get; set; }

        public string Description { get; set; }
    }
}
