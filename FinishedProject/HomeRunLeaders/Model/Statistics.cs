using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HomeRunLeaders.Model
{
    public class Statistics
    {
        [JsonPropertyName("$ref")]
        public string _ref { get; set; }
    }

}
