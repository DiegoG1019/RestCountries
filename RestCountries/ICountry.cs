using System;
using System.Collections.Generic;

namespace RestCountries
{
    public interface ICountry
    {
        public string Name { get; }

        public IEnumerable<string> TopLevelDomains { get; }

        public string Alpha2Code { get; }

        public string Alpha3Code { get; }

        public IEnumerable<string> CallingCodes { get; }

        public string CapitalCity { get; }

        public IEnumerable<string> AlternativeSpellings { get; }

        public Region Region { get; }

        public SubRegion SubRegion { get; }

        public long Population { get; }

        public double[] LatitudeLongitude { get; }

        public string Demonym { get; }

        /// <summary>
        /// Represented in SquareKilometers
        /// </summary>
        public double Area { get; }

        public double Gini { get; }
        public IEnumerable<TimeZoneInfo> TimeZones { get; }

        public IEnumerable<Countries> Borders { get; }

        public string NativeName { get; }

        public string NumericCodeString { get; }
        public int NumericCode { get; }

        public IEnumerable<ICurrencyInfo> Currencies { get; }

        public IEnumerable<ILanguageInfo> Languages { get; }

        public Dictionary<string, string> Translations { get; }

        public string FlagUriString { get; }

        public Uri FlagUri { get; }

        public string CIOC { get; }
    }
}