using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace RestCountries
{
    [Serializable, JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Region
    {
        [EnumMember(Value = "Europe")] //Name as it appears in the JSON file
        Europe, //C# Friendly name

        [EnumMember(Value = "Asia")]
        Asia,

        [EnumMember(Value = "Africa")]
        Africa,

        [EnumMember(Value = "Oceania")]
        Oceania,

        [EnumMember(Value = "Americas")]
        Americas,
    }
}
