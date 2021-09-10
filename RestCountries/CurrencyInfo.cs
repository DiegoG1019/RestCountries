using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RestCountries
{
    internal class CurrencyInfo : ICurrencyInfo
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
    }
}
