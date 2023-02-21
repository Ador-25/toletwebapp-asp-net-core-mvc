using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace toletwebapp.Models
{
    public class Flat
    {
        [Key]
        public int FlatId { get; set; }
        public Building ?Building { get; set; }
        public Guid ?Id { get; set; }
        public double Size { get; set; }
        public int Beds { get; set; }
        public int Baths { get; set; }
        public int Balcony { get; set; }
        public string PhoneNumber { get; set; }
        public double Rent { get; set; }


        //IMAGES
        public string Image1 { get; set; } = "noimage.png";
        [NotMapped]
        public IFormFile ImageUpload1 { get; set; }



        public string Image2 { get; set; } = "noimage.png";
        [NotMapped]
        public IFormFile ImageUpload2 { get; set; }



        public string Image3 { get; set; } = "noimage.png";
        [NotMapped]
        public IFormFile ImageUpload3 { get; set; }



        public string Image4 { get; set; } = "noimage.png";
        [NotMapped]
        public IFormFile ImageUpload4 { get; set; }


        public string Image5 { get; set; } = "noimage.png";
        [NotMapped]
        public IFormFile ImageUpload5 { get; set; }



    }
}
