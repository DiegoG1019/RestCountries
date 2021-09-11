namespace RestCountries
{
    public interface ICurrencyInfo
    {
        public string? Code { get; }

        public string Name { get; }

        public string? Symbol { get; }
    }
}
