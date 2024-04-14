using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HomeRunLeaders.Model
{

    public class Leaders
    {
        [JsonPropertyName("$ref")]
        public string _ref { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string abbreviation { get; set; }
        public string type { get; set; }
        public List<Category> categories { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public string displayName { get; set; }
        public string shortDisplayName { get; set; }
        public string abbreviation { get; set; }
        public List<Leader> leaders { get; set; }
    }

    public class Leader
    {
        public string displayValue { get; set; }
        public float value { get; set; }
        public List<string> rel { get; set; }
        public Athlete athlete { get; set; }
        public Team team { get; set; }
        public Statistics statistics { get; set; }
    }

    public class Athlete
    {
        [JsonPropertyName("$ref")]
        public string _ref { get; set; }
    }

}
