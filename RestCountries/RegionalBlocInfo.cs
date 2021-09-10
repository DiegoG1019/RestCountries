using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RestCountries
{
    internal class RegionalBlocInfo : IRegionalBlocInfo
    {
        [JsonPropertyName("acronym")]
        public RegionalBloc Acronym { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("otherAcronyms")]
        public List<string> OtherAcronyms { get; set; }

        [JsonPropertyName("otherNames")]
        public List<string> OtherNames { get; set; }

        IEnumerable<string> IRegionalBlocInfo.OtherAcronyms => OtherAcronyms;
        IEnumerable<string> IRegionalBlocInfo.OtherNames => OtherNames;
    }
}
