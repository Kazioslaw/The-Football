using System.Text.Json.Serialization;

namespace TheFootballClient.JsonModels
{
    public class City
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("unique_name")]
        public string? UniqueName { get; set; }
    }
}
