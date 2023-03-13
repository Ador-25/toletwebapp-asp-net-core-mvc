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
        public string House { get; set; }
        public DateTime ClosingTime { get; set; }
        public string Image { get; set; } = "noimage.png";
        public string Description { get; set; } = "Notes";
        public string Note { get; set; } = "Note about building";
        public bool GarageAvailable { get; set; } = true;
        public bool LiftAvailable { get; set; } = true;
        public string Security { get; set; } = "Highly secured 24/7 ";

        [NotMapped]
        public IFormFile ImageUpload { get; set; }

    }
}
