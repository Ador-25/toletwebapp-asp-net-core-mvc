using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace toletwebapp.Models
{
    public class Building
    {
        [Key]

        public Guid Id { get; set; }= Guid.NewGuid();
        public string Block { get; set; }
        public string Road { get; set; }
        public DateTime ClosingTime { get; set; }
        public string Image { get; set; } = "noimage.png";
        public string Description { get; set; } = "Notes";
        public string Note { get; set; } = "Note about building";

        [NotMapped]
        public IFormFile ImageUpload { get; set; }

    }
}
