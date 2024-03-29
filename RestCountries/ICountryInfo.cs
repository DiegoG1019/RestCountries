﻿using System;
using System.Collections.Generic;

namespace RestCountries
{
    public interface ICountryInfo
    {
        public string Name { get; }

        public IEnumerable<string> TopLevelDomains { get; }

        public string Alpha2Code { get; }

        public string Alpha3Code { get; }

        /// <summary>
        /// Strong-typed Alpha3Code
        /// </summary>
        public Country CountryCode { get; }

        public IEnumerable<string> CallingCodes { get; }

        public string CapitalCity { get; }

        public IEnumerable<string> AlternativeSpellings { get; }

        public IEnumerable<IRegionalBlocInfo> RegionalBlocs { get; }

        public Region Region { get; }

        public SubRegion SubRegion { get; }

        public long Population { get; }

        public double[] LatitudeLongitude { get; }

        public string Demonym { get; }

        /// <summary>
        /// Represented in SquareKilometers
        /// </summary>
        public double? Area { get; }

        public double? Gini { get; }
        public IEnumerable<TimeZoneInfo> TimeZones { get; }

        public IEnumerable<Country> Borders { get; }

        public string NativeName { get; }

        public string NumericCodeString { get; }
        public int NumericCode { get; }

        public IEnumerable<ICurrencyInfo> Currencies { get; }

        public IEnumerable<ILanguageInfo> Languages { get; }

        public IReadOnlyDictionary<string, string?> Translations { get; }

        public string FlagUriString { get; }

        public Uri FlagUri { get; }

        public string? CIOC { get; }
    }
}