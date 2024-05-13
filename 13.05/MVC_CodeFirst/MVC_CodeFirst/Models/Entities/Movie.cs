using MVC_CodeFirst.Models.Abstracts;

namespace MVC_CodeFirst.Models.Entities
{
    public class Movie:BaseClass
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
