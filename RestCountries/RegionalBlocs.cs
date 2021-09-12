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
        /// <summary>
        /// European Union
        /// </summary>
        [EnumMember(Value = "European Union")]
        EU,

        /// <summary>
        /// European Free Trade Association
        /// </summary>
        [EnumMember(Value = "European Free Trade Association")]
        EFTA,

        /// <summary>
        /// Caribbean Community
        /// </summary>
        [EnumMember(Value = "Caribbean Community")]
        CARICOM,

        /// <summary>
        /// Pacific Alliance
        /// </summary>
        [EnumMember(Value = "Pacific Alliance")]
        PA,

        /// <summary>
        /// African Union
        /// </summary>
        [EnumMember(Value = "African Union")]
        AU,

        /// <summary>
        /// Union of South American Nations
        /// </summary>
        [EnumMember(Value = "Union of South American Nations")]
        USAN,

        /// <summary>
        /// Eurasian Economic Union
        /// </summary>
        [EnumMember(Value = "Eurasian Economic Union")]
        EEU,

        /// <summary>
        /// Arab League
        /// </summary>
        [EnumMember(Value = "Arab League")]
        AL,

        /// <summary>
        /// Association of Southeast Asian Nations
        /// </summary>
        [EnumMember(Value = "Association of Southeast Asian Nations")]
        ASEAN,

        /// <summary>
        /// Central American Integration System
        /// </summary>
        [EnumMember(Value = "Central American Integration System")]
        CAIS,

        /// <summary>
        /// Central European Free Trade Agreement
        /// </summary>
        [EnumMember(Value = "Central European Free Trade Agreement")]
        CEFTA,

        /// <summary>
        /// North American Free Trade Agreement
        /// </summary>
        [EnumMember(Value = "North American Free Trade Agreement")]
        NAFTA,

        /// <summary>
        /// South Asian Association for Regional Cooperation
        /// </summary>
        [EnumMember(Value = "South Asian Association for Regional Cooperation")]
        SAARC
    }
}
