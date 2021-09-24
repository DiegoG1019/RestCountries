using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace RestCountries
{
    public class RestCountriesClient
    {
        protected HttpClient Http { get; private set; }
        protected readonly string ApiRoute;

        public RestCountriesClient(HttpClientHandler? handler = null, string server = "https://restcountries.eu", string apiRoute = "/rest/v2/")
        {
            Http = handler != null ? new HttpClient(handler) : new HttpClient();
            Http.BaseAddress = new Uri(server);
            ApiRoute = apiRoute.EndsWith('/') ? apiRoute : apiRoute + "/";
        }


        public async Task<IEnumerable<ICountryInfo>?> GetAllCountriesAsync(CancellationToken ct = default)
            => await Http.GetFromJsonAsync<CountryInfo[]>($"{ApiRoute}all", ct);

        public async Task<ICountryInfo?> GetCountryAsync(Country country, CancellationToken ct = default) 
            => await Http.GetFromJsonAsync<CountryInfo>($"{ApiRoute}alpha/{country.GetCode()}", ct);

        public async Task<IEnumerable<ICountryInfo>?> GetCountriesAsync(CancellationToken ct, Country country, params Country[] countries)
            => await Http.GetFromJsonAsync<CountryInfo[]>($"{ApiRoute}alpha?codes={string.Join(';', countries.Append(country).Select(x => x.GetCode()))}", ct);

        public Task<IEnumerable<ICountryInfo>?> GetCountriesAsync(Country country, params Country[] countries)
            => GetCountriesAsync(default, country, countries);

        public async Task<IEnumerable<ICountryInfo>?> SearchByCurrencyAsync(CancellationToken ct = default)
            => throw new NotImplementedException();

        public async Task<IEnumerable<ICountryInfo>?> SearchByCapitalCityAsync(string capital, CancellationToken ct = default)
            => await Http.GetFromJsonAsync<CountryInfo[]>($"{ApiRoute}capital/{capital}");

        public async Task<IEnumerable<ICountryInfo>?> SearchByCallingCodeAsync(string callingCode, CancellationToken ct = default)
        {
            if (callingCode.Length != 3)
                throw new ArgumentException("Calling codes must be three digits in length", nameof(callingCode));
            foreach(char c in callingCode)
                if(!char.IsDigit(c))
                    throw new ArgumentException("Calling codes may only have digits in them", nameof(callingCode));
            return await Http.GetFromJsonAsync<CountryInfo[]>($"{ApiRoute}callingcode/{callingCode}");
        }

        public Task<IEnumerable<ICountryInfo>?> SearchByCallingCodeAsync(int callingCode, CancellationToken ct = default)
            => SearchByCallingCodeAsync(callingCode.ToString().PadLeft(3, '0'), ct);

        public async Task<IEnumerable<ICountryInfo>?> SearchByRegionalBloc(RegionalBloc regionalBloc, CancellationToken ct = default) 
            => await Http.GetFromJsonAsync<CountryInfo[]>($"{ApiRoute}regionalbloc/{regionalBloc}", ct);
    }
}
