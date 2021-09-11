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

        private Region? reg__;
        [JsonIgnore]
        public Region Region
        {
            get
            {
                if (reg__ is null)
                    reg__ = Enum.Parse<Region>(region__, true);
                return (Region)reg__;
            }
        }

        [JsonPropertyName("region")]
        public string region__ { get; set; }

        private SubRegion? subr__;
        [JsonIgnore]
        public SubRegion SubRegion
        { 
            get
            {
                if (subr__ is null)
                    subr__ = subregion__.GetSubRegion();
                return (SubRegion)subr__;
            } 
        }

        [JsonPropertyName("subregion")]
        public string subregion__ { get; set; }

        [JsonPropertyName("population")]
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
        public double? Area { get; set; }

        [JsonPropertyName("gini")]
        public double? Gini { get; set; }

        [JsonPropertyName("timezones")]
        public string[]? TimeZones_ { get; set; }

        private List<TimeZoneInfo>? Tz;
        [JsonIgnore]
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
        public List<string> borders__ { get; set; }

        private List<Country>? bord__;
        [JsonIgnore]
        public List<Country> Borders
        {
            get
            {
                if(bord__ is null)
                {
                    bord__ = new List<Country>(borders__.Count);
                    foreach (string c in borders__)
                        bord__.Add(Enum.Parse<Country>(c, true));
                }
                return bord__;
            }
        }

        [JsonPropertyName("nativeName")]
        public string NativeName { get; set; }

        [JsonPropertyName("numericCode")]
        public string NumericCodeString { get; set; }

        private int? NC_;
        [JsonIgnore]
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
        public Dictionary<string, string?> Translations { get; set; }

        [JsonPropertyName("flag")]
        public string FlagUriString { get; set; }

        private Uri? FlagUri__;
        [JsonIgnore]
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
        public string? CIOC { get; set; }

        [JsonIgnore] IEnumerable<string> ICountryInfo.TopLevelDomains => TopLevelDomains;
        [JsonIgnore] IEnumerable<string> ICountryInfo.CallingCodes => CallingCodes;
        [JsonIgnore] IEnumerable<string> ICountryInfo.AlternativeSpellings => AlternativeSpellings;
        [JsonIgnore] IEnumerable<Country> ICountryInfo.Borders => Borders;
        [JsonIgnore] IEnumerable<ICurrencyInfo> ICountryInfo.Currencies => Currencies;
        [JsonIgnore] IEnumerable<ILanguageInfo> ICountryInfo.Languages => Languages;
        [JsonIgnore] IReadOnlyDictionary<string, string?> ICountryInfo.Translations => Translations;
        [JsonIgnore] IEnumerable<IRegionalBlocInfo> ICountryInfo.RegionalBlocs => RegionalBlocs;
    }
}
