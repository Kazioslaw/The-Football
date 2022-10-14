using System.Text.Json.Serialization;

namespace TheFootballClient
{
    public class Cities
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("unique_name")]
        public string? UniqueName { get; set; }
    }
}
