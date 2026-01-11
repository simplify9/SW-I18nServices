using System;
using System.Collections.Generic;

namespace SW.I18nService
{
    public class CountriesService
    {

        private readonly IDictionary<string, Country> cntryd;

        public CountriesService()
        {
            var assembly = typeof(I18nServiceService).Assembly;
            var cntryds = assembly.GetManifestResourceStream("SW.I18nServices.Service.Data.country.bin");
            assembly.GetManifestResourceNames();
            cntryd = new Dictionary<string, Country>(cntryds.AsDictionary<Country>(), StringComparer.OrdinalIgnoreCase);
            
        }

        public IEnumerable<Country> List()
        {
            return cntryd.Values; 
        }

        public Country Get(string countryCode)
        {
            cntryd.TryGetValue(countryCode, out var c);
            return c;
        }

        public bool TryGet(string countryCode, out Country country)
        {
            if (cntryd.TryGetValue(countryCode, out country)) return true;
            return false;
        }

    }
}
