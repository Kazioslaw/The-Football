namespace TfcDomain.Models
{
    public class Player : Entity
    {
        public string? PlayerName { get; set; }
        public DateTime Birthday { get; set; }
        public string? Birthplace { get; set; }

        public Player(string? playerName, DateTime birthday, string? birthplace)
        {
            PlayerName = playerName;
            Birthday = birthday;
            Birthplace = birthplace;
        }
    }
}
