using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace RestCountries
{
    [Serializable, JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RegionalBloc
    {
        [EnumMember(Value = "EU")]
        EU,

        [EnumMember(Value = "EFTA")]
        EFTA,

        [EnumMember(Value = "CARICOM")]
        CARICOM,

        [EnumMember(Value = "PA")]
        PA,

        [EnumMember(Value = "AU")]
        AU,

        [EnumMember(Value = "USAN")]
        USAN,

        [EnumMember(Value = "EEU")]
        EEU,

        [EnumMember(Value = "AL")]
        AL,

        [EnumMember(Value = "ASEAN")]
        ASEAN,

        [EnumMember(Value = "CAIS")]
        CAIS,

        [EnumMember(Value = "CEFTA")]
        CEFTA,

        [EnumMember(Value = "NAFTA")]
        NAFTA,

        [EnumMember(Value = "SAARC")]
        SAARC
    }
}
