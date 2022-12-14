using System.ComponentModel.DataAnnotations;

namespace TfcDomain.Models
{
    public class Player : Entity
    {
        public string? PlayerName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string? Birthplace { get; set; }

        public ICollection<PlayerAttributeSet> PlayerAttributeSet { get; set; }

        public Player(string? playerName, DateTime birthday, string? birthplace)
        {
            PlayerName = playerName;
            Birthday = birthday;
            Birthplace = birthplace;
        }
    }
}
