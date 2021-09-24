using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace RestCountries
{
    [Serializable, JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SubRegion
    {
        /// <summary>
        /// Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Southern Asia
        /// </summary>
        [EnumMember(Value = "Southern Asia")]
        SouthernAsia,

        /// <summary>
        /// Northern Europe
        /// </summary>
        [EnumMember(Value = "Northern Europe")]
        NorthernEurope,

        /// <summary>
        /// Southern Europe
        /// </summary>
        [EnumMember(Value = "Southern Europe")]
        SouthernEurope,

        /// <summary>
        /// Northern Africa
        /// </summary>
        [EnumMember(Value = "Northern Africa")]
        NorthernAfrica,

        /// <summary>
        /// Polynesia
        /// </summary>
        [EnumMember(Value = "Polynesia")]
        Polynesia,

        /// <summary>
        /// Middle Africa
        /// </summary>
        [EnumMember(Value = "Middle Africa")]
        MiddleAfrica,

        /// <summary>
        /// Caribbean
        /// </summary>
        [EnumMember(Value = "Caribbean")]
        Caribbean,

        /// <summary>
        /// South America
        /// </summary>
        [EnumMember(Value = "South America")]
        SouthAmerica,

        /// <summary>
        /// Western Asia
        /// </summary>
        [EnumMember(Value = "Western Asia")]
        WesternAsia,

        /// <summary>
        /// Australia and New Zealand
        /// </summary>
        [EnumMember(Value = "Australia and New Zealand")]
        AustraliaAndNewZealand,

        /// <summary>
        /// Western Europe
        /// </summary>
        [EnumMember(Value = "Western Europe")]
        WesternEurope,

        /// <summary>
        /// Eastern Europe
        /// </summary>
        [EnumMember(Value = "Eastern Europe")]
        EasternEurope,

        /// <summary>
        /// Central America
        /// </summary>
        [EnumMember(Value = "Central America")]
        CentralAmerica,

        /// <summary>
        /// Western Africa
        /// </summary>
        [EnumMember(Value = "Western Africa")]
        WesternAfrica,

        /// <summary>
        /// Northern America
        /// </summary>
        [EnumMember(Value = "Northern America")]
        NorthernAmerica,

        /// <summary>
        /// Southern Africa
        /// </summary>
        [EnumMember(Value = "Southern Africa")]
        SouthernAfrica,

        /// <summary>
        /// Eastern Africa
        /// </summary>
        [EnumMember(Value = "Eastern Africa")]
        EasternAfrica,

        /// <summary>
        /// South-Eastern Asia
        /// </summary>
        [EnumMember(Value = "South-Eastern Asia")]
        SouthEasternAsia,

        /// <summary>
        /// Eastern Asia
        /// </summary>
        [EnumMember(Value = "Eastern Asia")]
        EasternAsia,

        /// <summary>
        /// Melanesia
        /// </summary>
        [EnumMember(Value = "Melanesia")]
        Melanesia,

        /// <summary>
        /// Micronesia
        /// </summary>
        [EnumMember(Value = "Micronesia")]
        Micronesia,

        /// <summary>
        /// Central Asia
        /// </summary>
        [EnumMember(Value = "Central Asia")]
        CentralAsia
    }
}
