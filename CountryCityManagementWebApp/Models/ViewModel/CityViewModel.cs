using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityManagementWebApp.Models.ViewModel
{
    public class CityViewModel
    {
        public int CitySL { set; get; }
        public int CityId { set; get; }
        public string CityName { set; get; }
        public string CityAbout { set; get; }
        public int CityNoofDwellers { set; get; }
        public string CityLocation { set; get; }
        public string CityWeather { set; get; }
        public int CountryId { set; get; }
        public string CountryName { set; get; }

    }
}