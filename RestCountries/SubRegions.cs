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
        [EnumMember(Value = "Southern Asia")]
        SouthernAsia,

        [EnumMember(Value = "Northern Europe")]
        NorthernEurope,

        [EnumMember(Value = "Southern Europe")]
        SouthernEurope,

        [EnumMember(Value = "Northern Africa")]
        NorthernAfrica,

        [EnumMember(Value = "Polynesia")]
        Polynesia,

        [EnumMember(Value = "Middle Africa")]
        MiddleAfrica,

        [EnumMember(Value = "Caribbean")]
        Caribbean,

        [EnumMember(Value = "South America")]
        SouthAmerica,

        [EnumMember(Value = "Western Asia")]
        WesternAsia,

        [EnumMember(Value = "Australia and New Zealand")]
        AustraliaAndNewZealand,

        [EnumMember(Value = "Western Europe")]
        WesternEurope,

        [EnumMember(Value = "Eastern Europe")]
        EasternEurope,

        [EnumMember(Value = "Central America")]
        CentralAmerica,

        [EnumMember(Value = "Western Africa")]
        WesternAfrica,

        [EnumMember(Value = "Northern America")]
        NorthernAmerica,

        [EnumMember(Value = "Southern Africa")]
        SouthernAfrica,

        [EnumMember(Value = "Eastern Africa")]
        EasternAfrica,

        [EnumMember(Value = "South-Eastern Asia")]
        SouthEasternAsia,

        [EnumMember(Value = "Eastern Asia")]
        EasternAsia,

        [EnumMember(Value = "Melanesia")]
        Melanesia,

        [EnumMember(Value = "Micronesia")]
        Micronesia,

        [EnumMember(Value = "Central Asia")]
        CentralAsia
    }
}
