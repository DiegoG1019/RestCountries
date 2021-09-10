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
        [EnumMember(Value = "Northern Europe")]
        NorthEurope,

        [EnumMember(Value = "Southern Europe")]
        SouthEurope,

        [EnumMember(Value = "Southern Asia")]
        SouthAsia,

        [EnumMember(Value = "Northern Africa")]
        NorthAfrica,

        [EnumMember(Value = "Middle Africa")]
        MiddleAfrica,

        [EnumMember(Value = "Polynesia")]
        Polynesia,

        [EnumMember(Value = "Caribbean")]
        Caribbean
    }
}
