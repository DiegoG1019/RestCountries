using System;
using System.Linq;
using System.Threading.Tasks;

namespace RestCountries.Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            static void p(object s) => Console.WriteLine(s);
            var client = new RestCountriesClient(server: "https://restcountries.com/", apiRoute: "/v2");

            var a = await client.GetAllCountriesAsync();
            var b = await client.GetCountriesAsync(Country.UnitedStates, Country.Afghanistan);
            var c = await client.GetCountryAsync(Country.Venezuela);
            var d = await client.SearchByCallingCodeAsync(358);
            var e = await client.SearchByCapitalCityAsync("Caracas");
            var f = await client.SearchByRegionalBloc(RegionalBloc.EEU);

            await Task.Delay(1000);

            var x = c.SubRegion;
            var y = c.Region;
            var z = c.CountryCode;
            var w = c.RegionalBlocs.FirstOrDefault();

            var ex = x.GetName();
            var zih = z.GetCode();
            var double_u = w.Acronym.GetName();
            ;
        }
    }
}
