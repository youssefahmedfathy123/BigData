using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Url
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Word word { get; set; }
        [ForeignKey("word")]
        public string Word { get; set; }
        public int Number { get; set; }
    }
}


