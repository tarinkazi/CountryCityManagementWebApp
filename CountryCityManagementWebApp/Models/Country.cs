using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityManagementWebApp.Models
{
    public class Country
    {
        public int Id { set; get; }
        public string CountryName { set; get; }
        public string CountryAbout { set; get; }
        public int SL { set; get; }

        public Country(String countryName, string countryAbout)
        {
            
            CountryName = countryName;
            CountryAbout = countryAbout;
            
        }

        public Country(int id, String countryName, string countryAbout) : this( countryName, countryAbout)
        {
            Id = id;
           
        }
        public Country(int id, String countryName, string countryAbout,int sl)
            : this(id,countryName, countryAbout)
        {
            SL = sl;

        }

     

    }
}