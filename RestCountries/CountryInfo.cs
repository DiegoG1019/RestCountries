using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RestCountries
{
    internal class CountryInfo : ICountryInfo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("topLevelDomain")]
        public List<string> TopLevelDomains { get; set; }

        [JsonPropertyName("alpha2Code")]
        public string Alpha2Code { get; set; }

        [JsonPropertyName("alpha3Code")]
        public string Alpha3Code { get; set; }

        [JsonPropertyName("callingCodes")]
        public List<string> CallingCodes { get; set; }

        [JsonPropertyName("capital")]
        public string CapitalCity { get; set; }

        [JsonPropertyName("altSpellings")]
        public List<string> AlternativeSpellings { get; set; }

        [JsonPropertyName("regionalBlocs")]
        public List<RegionalBlocInfo> RegionalBlocs { get; set; }

        [JsonPropertyName("region")]
        public Region Region { get; set; }

        [JsonPropertyName("subregion")]
        public SubRegion SubRegion { get; set; }

        [JsonPropertyName("alpha2Code")]
        public long Population { get; set; }

        [JsonPropertyName("latlng")]
        public double[] LatitudeLongitude { get; set; }
        public double Latitude => LatitudeLongitude[0];
        public double Longitude => LatitudeLongitude[1];

        [JsonPropertyName("demonym")]
        public string Demonym { get; set; }

        /// <summary>
        /// Represented in SquareKilometers
        /// </summary>
        [JsonPropertyName("area")]
        public double Area { get; set; }

        [JsonPropertyName("gini")]
        public double Gini { get; set; }

        [JsonPropertyName("timezones")]
        public string[]? TimeZones_ { get; set; }

        private List<TimeZoneInfo>? Tz;
        public IEnumerable<TimeZoneInfo> TimeZones
        {
            get
            {
                if(Tz is null)
                {
                    Tz = new List<TimeZoneInfo>();
                    foreach (string s in TimeZones_)
                        Tz.Add(TimeZoneInfo.CreateCustomTimeZone(Name, TimeSpan.Parse(s.Replace("UTC", "").Replace("+", "")), Name, Name));
                }
                return Tz;
            }
        }

        [JsonPropertyName("borders")]
        public List<Country> Borders { get; set; }

        [JsonPropertyName("nativeName")]
        public string NativeName { get; set; }

        [JsonPropertyName("numericCode")]
        public string NumericCodeString { get; set; }

        private int? NC_;
        public int NumericCode
        {
            get
            {
                if (NC_ is null)
                    NC_ = int.Parse(NumericCodeString);
                return (int)NC_;
            }
        }

        [JsonPropertyName("currencies")]
        public List<CurrencyInfo> Currencies { get; set; }

        [JsonPropertyName("languages")]
        public List<LanguageInfo> Languages { get; set; }

        [JsonPropertyName("translations")]
        public Dictionary<string, string> Translations { get; set; }

        [JsonPropertyName("translations")]
        public string FlagUriString { get; set; }

        private Uri? FlagUri__;
        public Uri FlagUri
        {
            get
            {
                if (FlagUri__ is null)
                    FlagUri__ = new Uri(FlagUriString);
                return FlagUri__;
            }
        }

        [JsonPropertyName("cioc")]
        public string CIOC { get; set; }

        IEnumerable<string> ICountryInfo.TopLevelDomains => TopLevelDomains;
        IEnumerable<string> ICountryInfo.CallingCodes => CallingCodes;
        IEnumerable<string> ICountryInfo.AlternativeSpellings => AlternativeSpellings;
        IEnumerable<Country> ICountryInfo.Borders => Borders;
        IEnumerable<ICurrencyInfo> ICountryInfo.Currencies => Currencies;
        IEnumerable<ILanguageInfo> ICountryInfo.Languages => Languages;
        IReadOnlyDictionary<string, string> ICountryInfo.Translations => Translations;
        IEnumerable<IRegionalBlocInfo> ICountryInfo.RegionalBlocs => RegionalBlocs;
    }
}
