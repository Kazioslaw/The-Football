namespace TfcDomain.Models
{
    public class PlayerAttributeSet : Entity
    {
        public int PlayerId { get; set; }
        public byte Acceleration { get; set; }
        public byte Adaptability { get; set; }
        public byte Aggression { get; set; }
        public byte Agility { get; set; }
        public byte Ambition { get; set; }
        public byte Anticipation { get; set; }
        public byte ArealReach { get; set; }
        public byte Balance { get; set; }
        public byte Bravery { get; set; }
        public byte CommandOfArea { get; set; }
        public byte Communication { get; set; }
        public byte Composure { get; set; }
        public byte Concentration { get; set; }
        public byte Consistency { get; set; }
        public byte Controversy { get; set; }
        public byte Corners { get; set; }
        public byte Crossing { get; set; }
        public byte Decisions { get; set; }
        public byte Determination { get; set; }
        public byte Dirtiness { get; set; }
        public byte Drybbling { get; set; }
        public byte Eccentricity { get; set; }
        public byte Finishing { get; set; }
        public byte FirstTouch { get; set; }
        public byte Flair { get; set; }
        public byte FreeKicks { get; set; }
        public byte Handling { get; set; }
        public byte Heading { get; set; }
        public byte ImportantMatches { get; set; }
        public byte InjuryProneness { get; set; }
        public byte JumpingReach { get; set; }
        public byte Kicking { get; set; }
        public byte Leadership { get; set; }
        public byte LongShots { get; set; }
        public byte LongThrows { get; set; }
        public byte Loyality { get; set; }
        public byte Marking { get; set; }
        public byte NaturalFitness { get; set; }
        public byte OffTheBall { get; set; }
        public byte OneOnOnes { get; set; }
        public byte Pace { get; set; }
        public byte Passing { get; set; }
        public byte PenalityTaking { get; set; }
        public byte Positioning { get; set; }
        public byte Pressure { get; set; }
        public byte Professionalism { get; set; }
        public byte Reflex { get; set; }
        public byte RushingOut { get; set; }
        public byte Sportmanship { get; set; }
        public byte Stamina { get; set; }
        public byte Strength { get; set; }
        public byte Tackling { get; set; }
        public byte Teamwork { get; set; }
        public byte Technique { get; set; }
        public byte Temperament { get; set; }
        public byte Throwing { get; set; }
        public byte TrendToPunch { get; set; }
        public byte Versatility { get; set; }
        public byte Vision { get; set; }
        public byte WorkRate { get; set; }       
        public DateTime LastUpdate { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
