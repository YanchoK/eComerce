using System.ComponentModel.DataAnnotations;

namespace eComerce.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
