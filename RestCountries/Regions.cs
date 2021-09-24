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
        /// <summary>
        /// Unknown Region
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Europe
        /// </summary>
        [EnumMember(Value = "Europe")] //Name as it appears in the JSON file
        Europe, //C# Friendly name

        /// <summary>
        /// Asia
        /// </summary>
        [EnumMember(Value = "Asia")]
        Asia,

        /// <summary>
        /// Africa
        /// </summary>
        [EnumMember(Value = "Africa")]
        Africa,

        /// <summary>
        /// Oceania
        /// </summary>
        [EnumMember(Value = "Oceania")]
        Oceania,

        /// <summary>
        /// Americas
        /// </summary>
        [EnumMember(Value = "Americas")]
        Americas,

        /// <summary>
        /// Polar
        /// </summary>
        [EnumMember(Value = "Polar")]
        Polar
    }
}
