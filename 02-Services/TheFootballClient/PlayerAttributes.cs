using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace TheFootballClient
{
    public class PlayerAttributes
    {
        public static void Generating()
        {
            Random rnd = new Random();
            var acceleration = rnd.Next(0, 21);
            var adaptability = rnd.Next(0, 21);
            var aggression = rnd.Next(0,21);
            var agility = rnd.Next(0,21);
            var ambition = rnd.Next(0,21);
            var anticipation = rnd.Next(0,21);
            var arealReach = rnd.Next(0,21);
            var balance = rnd.Next(0,21);
            var bravery = rnd.Next(0,21);
            var commandOfArea = rnd.Next(0,21);
            var communication = rnd.Next(0,21);
            var composure = rnd.Next(0,21);
            var concentration = rnd.Next(0,21);
            var consistency = rnd.Next(0,21);
            var controversy = rnd.Next(0,21);
            var corners = rnd.Next(0,21);
            var crossing = rnd.Next(0,21);
            var decisions = rnd.Next(0,21);
            var determination = rnd.Next(0,21);
            var dirtiness = rnd.Next(0,21);
            var drybbling = rnd.Next(0,21);
            var eccentricity = rnd.Next(0,21);
            var finishing = rnd.Next(0,21);
            var firstTouch = rnd.Next(0,21);
            var flair = rnd.Next(0,21);
            var freeKicks = rnd.Next(0,21);
            var handling = rnd.Next(0,21);
            var heading = rnd.Next(0,21);
            var importantMatches = rnd.Next(0,21);
            var injuryProneness = rnd.Next(0,21);
            var jumpingReach = rnd.Next(0,21);
            var kicking = rnd.Next(0,21);
            var leadership = rnd.Next(0,21);
            var longShots = rnd.Next(0,21);
            var longThrows = rnd.Next(0,21);
            var loyality = rnd.Next(0,21);
            var marking = rnd.Next(0,21);
            var naturalFitness = rnd.Next(0,21);
            var offTheBall = rnd.Next(0,21);
            var oneOnOnes = rnd.Next(0,21);
            var pace = rnd.Next(0,21);
            var passing = rnd.Next(0,21);
            var penalityTaking = rnd.Next(0,21);
            var positioning = rnd.Next(0,21);
            var pressure = rnd.Next(0,21);
            var professionalism = rnd.Next(0,21);
            var reflex = rnd.Next(0,21);
            var rushingOut = rnd.Next(0,21);
            var sportmanship = rnd.Next(0,21);
            var stamina = rnd.Next(0,21);
            var strength = rnd.Next(0,21);
            var tackling = rnd.Next(0,21);
            var teamwork = rnd.Next(0,21);
            var technique = rnd.Next(0,21);
            var temperament = rnd.Next(0,21);
            var throwing = rnd.Next(0,21);
            var trendToPunch = rnd.Next(0,21);
            var versatility = rnd.Next(0,21);
            var vision = rnd.Next(0,21);
            var workRate = rnd.Next(0,21);
        }
    }
}
