using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RestCountries
{
    internal class RegionalBlock
    {
        [JsonPropertyName("acronym")]
        public string Acronym { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("otherAcronyms")]
        public List<string> OtherAcronyms { get; set; }

        [JsonPropertyName("otherNames")]
        public List<string> OtherNames { get; set; }
    }
}
