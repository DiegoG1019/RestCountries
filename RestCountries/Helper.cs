using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Reflection;
using System.Threading.Tasks;

namespace RestCountries
{
    public static class Helper
    {
        private readonly static Dictionary<SubRegion, string> subRegionToNames = new Dictionary<SubRegion, string>();
        private readonly static Dictionary<string, SubRegion> namesToSubRegion = new Dictionary<string, SubRegion>();

        private readonly static Dictionary<RegionalBloc, string> regionalBlocToNames = new Dictionary<RegionalBloc, string>();
        private readonly static Dictionary<string, RegionalBloc> namesToRegionalBloc = new Dictionary<string, RegionalBloc>();

        private readonly static Dictionary<Country, string> countryToNames = new Dictionary<Country, string>();
        private readonly static Dictionary<string, Country> namesToCountry = new Dictionary<string, Country>();

        static Helper()
        {
            {
                var enumType = typeof(SubRegion);
                var memberInfos = enumType.GetMembers(BindingFlags.Public | BindingFlags.Static | BindingFlags.GetProperty);
                foreach (var member in memberInfos)
                {
                    string val = ((EnumMemberAttribute)member.GetCustomAttributes(typeof(EnumMemberAttribute), false).First(x => x is EnumMemberAttribute)).Value;
                    var name = Enum.Parse<SubRegion>(member.Name);
                    subRegionToNames.Add(name, val);
                    namesToSubRegion.Add(val, name);
                }
            }
            {
                var enumType = typeof(RegionalBloc);
                var memberInfos = enumType.GetMembers(BindingFlags.Public | BindingFlags.Static | BindingFlags.GetProperty);
                foreach (var member in memberInfos)
                {
                    string val = ((EnumMemberAttribute)member.GetCustomAttributes(typeof(EnumMemberAttribute), false).First(x => x is EnumMemberAttribute)).Value;
                    var name = Enum.Parse<RegionalBloc>(member.Name);
                    regionalBlocToNames.Add(name, val);
                    namesToRegionalBloc.Add(val, name);
                }
            }
            {
                var enumType = typeof(Country);
                var memberInfos = enumType.GetMembers(BindingFlags.Public | BindingFlags.Static | BindingFlags.GetProperty);
                foreach (var member in memberInfos)
                {
                    string val = ((EnumMemberAttribute)member.GetCustomAttributes(typeof(EnumMemberAttribute), false).First(x => x is EnumMemberAttribute)).Value;
                    var name = Enum.Parse<Country>(member.Name);
                    countryToNames.Add(name, val);
                    namesToCountry.Add(val, name);
                }
            }
        }

        public static string GetName(this SubRegion subRegion)
            => subRegionToNames[subRegion];

        public static SubRegion GetSubRegion(this string subRegion)
            => namesToSubRegion.TryGetValue(subRegion, out var val)
                ? val
                : Enum.TryParse<SubRegion>(subRegion, out var vale) ? vale
                : throw new ArgumentException($"The name {subRegion} doesn't match any known Sub Regions", nameof(subRegion));

        public static bool TryGetSubRegion(this string subRegion, out SubRegion result)
            => namesToSubRegion.TryGetValue(subRegion, out result) || Enum.TryParse(subRegion, out result);
        
        //--

        public static string GetName(this RegionalBloc regionalBloc)
            => regionalBlocToNames[regionalBloc];

        public static RegionalBloc GetRegionalBloc(this string regionalBloc)
            => namesToRegionalBloc.TryGetValue(regionalBloc, out var val)
                ? val
                : Enum.TryParse<RegionalBloc>(regionalBloc, out var vale) ? vale
                : throw new ArgumentException($"The name {regionalBloc} doesn't match any known Regional Blocs", nameof(regionalBloc));

        public static bool TryGetRegionalBloc(this string regionalBloc, out RegionalBloc result)
            => namesToRegionalBloc.TryGetValue(regionalBloc, out result) || Enum.TryParse(regionalBloc, out result);

        //--

        public static string GetCode(this Country country)
            => countryToNames[country];

        public static Country GetCountry(this string country)
            => namesToCountry.TryGetValue(country, out var val) ? val 
                : Enum.TryParse<Country>(country, out var vale)  ? vale
                : throw new ArgumentException($"The name {country} doesn't match any known Countries", nameof(country));

        public static bool TryGetCountry(this string country, out Country result)
            => namesToCountry.TryGetValue(country, out result) || Enum.TryParse(country, out result);

        //--

        public static string GetName(this Region region)
            => region.ToString();

        public static Region GetRegion(this string region)
            => Enum.TryParse<Region>(region, out var vale) ? vale
                : throw new ArgumentException($"The name {region} doesn't match any known Countries", nameof(region));

        public static bool TryGetRegion(this string region, out Region result)
            => Enum.TryParse(region, out result);
    }
}
