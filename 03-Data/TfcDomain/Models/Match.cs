using System.ComponentModel.DataAnnotations.Schema;

namespace TfcDomain.Models
{
    public class Match : Entity
    {
        [ForeignKey(nameof(FirstClub)), Column(Order = 0)]
        public int FirstClubId { get; set; }
        [ForeignKey(nameof(SecondClub)), Column(Order = 1)]
        public int SecondClubId { get; set; }
        public int FirstTeamScore { get; set; }
        public int SecondTeamScore  { get; set; }
        public int CompetitionId { get; set; }
        public DateTime Date { get; set; }

        public Club FirstClub { get; set; }
        public Club SecondClub { get; set; }
    }
}