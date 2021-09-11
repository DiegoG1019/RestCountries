using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Reflection;

namespace RestCountries
{
    public static class Helper
    {
        private readonly static Dictionary<SubRegion, string> subRegionToNames = new Dictionary<SubRegion, string>();
        private readonly static Dictionary<string, SubRegion> namesToSubRegion = new Dictionary<string, SubRegion>();

        private readonly static Dictionary<RegionalBloc, string> regionalBlocToNames = new Dictionary<RegionalBloc, string>();
        private readonly static Dictionary<string, RegionalBloc> namesToRegionalBloc = new Dictionary<string, RegionalBloc>();

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
                    string val = ((EnumMemberAttribute)member.GetCustomAttributes(typeof(EnumMemberAttribute), false).First(x => x.GetType() == typeof(EnumMemberAttribute))).Value;
                    var name = Enum.Parse<RegionalBloc>(member.Name);
                    regionalBlocToNames.Add(name, val);
                    namesToRegionalBloc.Add(val, name);
                }
            }
        }

        public static string GetName(this SubRegion subRegion)
            => subRegionToNames[subRegion];

        public static SubRegion GetSubRegion(this string subRegion)
            => namesToSubRegion.TryGetValue(subRegion, out var val)
                ? val
                : throw new ArgumentException($"The name {subRegion} doesn't match any known Sub Regions", nameof(subRegion));

        public static bool TryGetSubRegion(this string subRegion, out SubRegion result)
            => namesToSubRegion.TryGetValue(subRegion, out result);
        
        //--

        public static string GetName(this RegionalBloc regionalBloc)
            => regionalBlocToNames[regionalBloc];

        public static RegionalBloc GetRegionalBloc(this string regionalBloc)
            => namesToRegionalBloc.TryGetValue(regionalBloc, out var val)
                ? val
                : throw new ArgumentException($"The name {regionalBloc} doesn't match any known Regional Blocs", nameof(regionalBloc));

        public static bool TryGetRegionalBloc(this string regionalBloc, out RegionalBloc result)
            => namesToRegionalBloc.TryGetValue(regionalBloc, out result);
    }
}
