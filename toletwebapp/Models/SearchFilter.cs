using System.ComponentModel.DataAnnotations;

namespace toletwebapp.Models
{
    public class SearchFilter
    { 
    
        [Key]
        public Guid SearchId { get; set; }
        public string Block { get; set; }
        public double MinRange { get; set; }
        public double MaxRange { get; set; }
    }
}
