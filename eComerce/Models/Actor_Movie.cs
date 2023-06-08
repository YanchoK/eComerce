using System.ComponentModel.DataAnnotations.Schema;

namespace eComerce.Models
{
    [Table("Actor_Movie")]
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
