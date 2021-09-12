using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RestCountries
{
    internal class RegionalBlocInfo : IRegionalBlocInfo
    {
        [JsonPropertyName("acronym")]
        public string _acronym { get; set; }

        private RegionalBloc? acronymField_;
        [JsonIgnore]
        public RegionalBloc Acronym
        {
            get
            {
                if (acronymField_ is null)
                    acronymField_ = Enum.Parse<RegionalBloc>(_acronym);
                return (RegionalBloc)acronymField_;
            }
        }

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
