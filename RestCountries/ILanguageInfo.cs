namespace RestCountries
{
    public interface ILanguageInfo
    {
        public string ISO639_1 { get; }

        public string ISO639_2 { get; }

        public string Name { get; }

        public string NativeName { get; }
    }
}
