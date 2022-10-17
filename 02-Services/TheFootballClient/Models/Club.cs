namespace TheFootballClient.Models
{
    public class Club
    {
        public string? ClubName { get; set; }
        public DateTime ClubFounded { get; set; }

        public Club(string? clubName, DateTime clubFounded)
        {
            ClubName = clubName;
            ClubFounded = clubFounded;
        }
    }
}
