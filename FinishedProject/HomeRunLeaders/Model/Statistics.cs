using System.Text.Json.Serialization;

namespace HomeRunLeaders.Model
{
    public class Statistics
    {
        [JsonPropertyName("$ref")]
        public string _ref { get; set; }
    }

}
