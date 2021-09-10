using System.Collections.Generic;

namespace RestCountries
{
    public interface IRegionalBlocInfo
    {
        public RegionalBloc Acronym { get; }

        public string Name { get; }

        public IEnumerable<string> OtherAcronyms { get; }

        public IEnumerable<string> OtherNames { get; }
    }
}
