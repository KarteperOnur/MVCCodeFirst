//Data Annotation


using System.ComponentModel.DataAnnotations;

namespace MVC_TagHelpers.RequestModels
{
    public class CategoryRequestModel
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Kategori adı boş geçilemez!")]
        [Display(Name ="Kategori Adı")]
        public string CategoryName { get; set; }
        public string? Description { get; set; }
    }
}
