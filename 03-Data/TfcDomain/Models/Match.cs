namespace TfcDomain.Models
{
    internal class Match : Entity
    {
        public int FirstTeamId { get; set; }
        public int SecondTeamId { get; set; }
        public int FirstTeamScore { get; set; }
        public int SecondTeamScore  { get; set; }
        public int CompetitionId { get; set; }
        public DateTime Date { get; set; }
    }
}
