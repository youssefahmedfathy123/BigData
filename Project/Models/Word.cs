using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Word
    {
        [Key]
        public string Name { get; set; }
        List<Url> urls { get; set; }

    }
}



