using System.Text.Json.Serialization;

namespace HomeRunLeaders.Model
{
    public class Team
    {
        [JsonPropertyName("$ref")]
        public string _ref { get; set; }
    }
}
