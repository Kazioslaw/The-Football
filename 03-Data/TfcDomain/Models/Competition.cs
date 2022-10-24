namespace TfcDomain.Models
{
    public class Competition : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Competition(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public ICollection<Match> Matches { get; set; }
    }
}