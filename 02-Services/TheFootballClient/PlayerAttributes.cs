using TfcDomain.Models;

namespace TheFootballClient
{
    public class PlayerAttributes
    {
        public static void Generating()
        {
            Random rnd = new Random();
            var playerAttributes = new PlayerAttributeSet();
            playerAttributes.Acceleration = (byte)rnd.Next(0, 21);
            playerAttributes.Adaptability = (byte)rnd.Next(0, 21);
            playerAttributes.Aggression = (byte)rnd.Next(0, 21);
            playerAttributes.Agility = (byte)rnd.Next(0, 21);
            playerAttributes.Ambition = (byte)rnd.Next(0, 21);
            playerAttributes.Anticipation = (byte)rnd.Next(0, 21);
            playerAttributes.ArealReach = (byte)rnd.Next(0, 21);
            playerAttributes.Balance = (byte)rnd.Next(0, 21);
            playerAttributes.Bravery = (byte)rnd.Next(0, 21);
            playerAttributes.CommandOfArea = (byte)rnd.Next(0, 21);
            playerAttributes.Communication = (byte)rnd.Next(0, 21);
            playerAttributes.Composure = (byte)rnd.Next(0, 21);
            playerAttributes.Concentration = (byte)rnd.Next(0, 21);
            playerAttributes.Consistency = (byte)rnd.Next(0, 21);
            playerAttributes.Controversy = (byte)rnd.Next(0, 21);
            playerAttributes.Corners = (byte)rnd.Next(0, 21);
            playerAttributes.Crossing = (byte)rnd.Next(0, 21);
            playerAttributes.Decisions = (byte)rnd.Next(0, 21);
            playerAttributes.Determination = (byte)rnd.Next(0, 21);
            playerAttributes.Dirtiness = (byte)rnd.Next(0, 21);
            playerAttributes.Dribbling = (byte)rnd.Next(0, 21);
            playerAttributes.Eccentricity = (byte)rnd.Next(0, 21);
            playerAttributes.Finishing = (byte)rnd.Next(0, 21);
            playerAttributes.FirstTouch = (byte)rnd.Next(0, 21);
            playerAttributes.Flair = (byte)rnd.Next(0, 21);
            playerAttributes.FreeKickTaking = (byte)rnd.Next(0, 21);
            playerAttributes.Handling = (byte)rnd.Next(0, 21);
            playerAttributes.Heading = (byte)rnd.Next(0, 21);
            playerAttributes.ImportantMatches = (byte)rnd.Next(0, 21);
            playerAttributes.InjuryProneness = (byte)rnd.Next(0, 21);
            playerAttributes.JumpingReach = (byte)rnd.Next(0, 21);
            playerAttributes.Kicking = (byte)rnd.Next(0, 21);
            playerAttributes.Leadership = (byte)rnd.Next(0, 21);
            playerAttributes.LongShots = (byte)rnd.Next(0, 21);
            playerAttributes.LongThrows = (byte)rnd.Next(0, 21);
            playerAttributes.Loyality = (byte)rnd.Next(0, 21);
            playerAttributes.Marking = (byte)rnd.Next(0, 21);
            playerAttributes.NaturalFitness = (byte)rnd.Next(0, 21);
            playerAttributes.OffTheBall = (byte)rnd.Next(0, 21);
            playerAttributes.OneOnOnes = (byte)rnd.Next(0, 21);
            playerAttributes.Pace = (byte)rnd.Next(0, 21);
            playerAttributes.Passing = (byte)rnd.Next(0, 21);
            playerAttributes.PenaltyTaking = (byte)rnd.Next(0, 21);
            playerAttributes.Positioning = (byte)rnd.Next(0, 21);
            playerAttributes.Pressure = (byte)rnd.Next(0, 21);
            playerAttributes.Professionalism = (byte)rnd.Next(0, 21);
            playerAttributes.Reflex = (byte)rnd.Next(0, 21);
            playerAttributes.RushingOut = (byte)rnd.Next(0, 21);
            playerAttributes.Sportmanship = (byte)rnd.Next(0, 21);
            playerAttributes.Stamina = (byte)rnd.Next(0, 21);
            playerAttributes.Strength = (byte)rnd.Next(0, 21);
            playerAttributes.Tackling = (byte)rnd.Next(0, 21);
            playerAttributes.Teamwork = (byte)rnd.Next(0, 21);
            playerAttributes.Technique = (byte)rnd.Next(0, 21);
            playerAttributes.Temperament = (byte)rnd.Next(0, 21);
            playerAttributes.Throwing = (byte)rnd.Next(0, 21);
            playerAttributes.TrendToPunch = (byte)rnd.Next(0, 21);
            playerAttributes.Versatility = (byte)rnd.Next(0, 21);
            playerAttributes.Vision = (byte)rnd.Next(0, 21);
            playerAttributes.WorkRate = (byte)rnd.Next(0, 21);
        }
    }
}
