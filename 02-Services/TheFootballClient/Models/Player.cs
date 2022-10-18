namespace TheFootballClient.Models
{
    public class Player
    {
        public string? PlayerName { get; set; }
        public DateTime Birthday { get; set; }
        //public string? Birthplace { get; set; }

        public Player(string? playerName, DateTime birthday/*, string? birthplace*/)
        {
            PlayerName = playerName;
            Birthday = birthday;
            //Birthplace = birthplace;
        }
    }
}
