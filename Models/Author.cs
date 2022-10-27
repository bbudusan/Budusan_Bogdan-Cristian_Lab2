using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Budusan_Bogdan_Cristian_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Display(Name = "Author Name")]
        public string FullName { get { return FirstName + " " + LastName; } }
        public ICollection<Book>? Books { get; set; } //navigation property

    }
}
