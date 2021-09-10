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

        public RestCountriesClient(string server = "https://restcountries.eu")
        {
            Http = new HttpClient() { BaseAddress = new Uri(server) };
        }

        public async Task<IEnumerable<ICountryInfo>?> GetAllCountriesAsync(CancellationToken ct = default)
            => await Http.GetFromJsonAsync<CountryInfo[]>("/rest/v2/all", ct);

        public async Task<ICountryInfo?> GetCountryAsync(Country country, CancellationToken ct = default) 
            => await Http.GetFromJsonAsync<CountryInfo>($"/rest/v2/alpha/{country}", ct);

        public async Task<IEnumerable<ICountryInfo>?> GetCountriesAsync(CancellationToken ct, Country country, params Country[] countries)
            => await Http.GetFromJsonAsync<CountryInfo[]>($"/rest/v2/alpha?codes={string.Join(';', countries.Append(country))}", ct);

        public Task<IEnumerable<ICountryInfo>?> GetCountriesAsync(Country country, params Country[] countries)
            => GetCountriesAsync(default, country, countries);

        public async Task<IEnumerable<ICountryInfo>?> SearchByCurrencyAsync(CancellationToken ct = default)
            => throw new NotImplementedException();

        public async Task<ICountryInfo?> SearchByCapitalCityAsync(string capital, CancellationToken ct = default)
            => await Http.GetFromJsonAsync<CountryInfo>($"/rest/v2/capital/{capital}");

        public async Task<ICountryInfo?> SearchByCallingCodeAsync(string callingCode, CancellationToken ct = default)
        {
            if (callingCode.Length != 3)
                throw new ArgumentException("Calling codes must be three digits in length", nameof(callingCode));
            foreach(char c in callingCode)
                if(!char.IsDigit(c))
                    throw new ArgumentException("Calling codes may only have digits in them", nameof(callingCode));
            return await Http.GetFromJsonAsync<CountryInfo>($"/rest/v2/callingcode/{callingCode}");
        }

        public Task<ICountryInfo?> SearchByCallingCodeAsync(int callingCode, CancellationToken ct = default)
            => SearchByCallingCodeAsync(callingCode.ToString().PadLeft(3), ct);

        public async Task<IEnumerable<ICountryInfo>?> SearchByRegionalBloc(RegionalBloc regionalBloc, CancellationToken ct = default)
            => await Http.GetFromJsonAsync<List<CountryInfo>>($"/rest/v2/regionalblock/{regionalBloc}", ct);
    }
}
