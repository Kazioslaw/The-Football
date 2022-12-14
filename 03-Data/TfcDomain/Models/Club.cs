using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TfcDomain.Models
{
    public class Club : Entity
    {
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime FoundingDate { get; set; }

        public Club(string name, DateTime foundingDate)
        {
                Name = name;
                FoundingDate = foundingDate;
        }

        [InverseProperty("FirstClub")]
        public ICollection<Match> FirstClubMatches { get; set; }
        [InverseProperty("SecondClub")]
        public ICollection<Match> SecondClubMatches { get; set; }
    }
}