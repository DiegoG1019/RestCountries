using System;
using System.Threading.Tasks;

namespace RestCountries.Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            static void p(object s) => Console.WriteLine(s);
            var client = new RestCountriesClient();

            var a = await client.GetAllCountriesAsync();
            var b = await client.GetCountriesAsync(Country.USA, Country.AFG);
            var c = await client.GetCountryAsync(Country.VEN);
            var d = await client.SearchByCallingCodeAsync(358);
            var e = await client.SearchByCapitalCityAsync("Caracas");
            var f = await client.SearchByRegionalBloc(RegionalBloc.EEU);

            await Task.Delay(1000);

            ;
            var x = c.SubRegion;
        }
    }
}
