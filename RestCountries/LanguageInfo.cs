using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RestCountries
{
    internal class LanguageInfo
    {
        [JsonPropertyName("iso639_1")]
        public string ISO639_1 { get; set; }

        [JsonPropertyName("iso639_2")]
        public string ISO639_2 { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nativeName")]
        public string NativeName { get; set; }
    }
}
