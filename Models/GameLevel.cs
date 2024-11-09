using System.ComponentModel.DataAnnotations;

namespace lab2.Models
{
    public class GameLevel
    {
        [Key]
        public int LevelId { get; set; }
        public string title { get; set; }
        public string?  Desscription { get; set; }
    }
}
