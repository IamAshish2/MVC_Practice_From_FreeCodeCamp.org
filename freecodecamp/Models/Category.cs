using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace freecodecamp.Models
{
    public class Category
    {
        //data annotations
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name{ get; set; }
        [DisplayName("Dispaly Order")]
        [Range(1,100,ErrorMessage ="Display order must be between 1 and 100 only.")]
        public int  DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
