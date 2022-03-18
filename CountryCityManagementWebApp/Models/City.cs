using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityManagementWebApp.Models
{
    public class City
    {
        public int CitySL { set; get; }
        public int CityId { set; get; }
        public string CityName{ set; get; }
        public string CityAbout { set; get; }
        public int CityNoofDwellers { set; get; }
        public string CityLocation { set; get; }
        public string CityWeather { set; get; }
        public int CountryId{ set; get; }

        public City(string cityName, string cityAbout, int cityNoofDwellers, string cityLocation, string cityWeather,
            int countryId)
        {
            CityName = cityName;
            CityAbout = cityAbout;
            CityNoofDwellers = cityNoofDwellers;
            CityLocation = cityLocation;
            CityWeather = cityWeather;
            CountryId = countryId;
        }
        public City(int cityId,string cityName, string cityAbout, int cityNoofDwellers, string cityLocation, string cityWeather,
            int countryId):this(cityName,cityAbout,cityNoofDwellers,cityLocation,cityWeather,countryId)
        {
            CityId = cityId;
        }
        public City(int citySL,int cityId, string cityName, string cityAbout, int cityNoofDwellers, string cityLocation, string cityWeather,
            int countryId)
            : this(cityId,cityName, cityAbout, cityNoofDwellers, cityLocation, cityWeather, countryId)
        {
            CitySL = citySL;
        }
    }
}