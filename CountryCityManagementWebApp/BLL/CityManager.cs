using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityManagementWebApp.DAL;
using CountryCityManagementWebApp.Models;
using CountryCityManagementWebApp.Models.ViewModel;

namespace CountryCityManagementWebApp.BLL
{
    public class CityManager
    {
        CityGateway cityGateway=new CityGateway();
        public int InsertCity(City city)
        {
            if (city.CityName=="")
            {
                throw new Exception("Please insert a City Name");
            }
            if (IsCityExist(city.CityName))
            {
                throw new Exception("City Name Already exist");
            }

            return cityGateway.InsertCity(city);
            

        }

        public List<City> GetAllCities()
        {
            return cityGateway.GetAllCities();
        }

        public City GetCityByName(string name)
        {
            return cityGateway.GetCityByName(name);
        }
        public bool IsCityExist(string name)
        {
            bool isCityExist = false;
            City city = GetCityByName(name);
            if (city != null)
            {
                isCityExist = true;
            }
            return isCityExist;
        }

        public List<CityViewModel> GetAllCitiesInfo()
        {
            return cityGateway.GetAllCitiesInfo();
        }

        public List<CitiesByNameViewModel> GetCitiesByName(string name)
        {
            return cityGateway.GetCitiesByName(name);
        }

        public List<CitiesByNameViewModel> GetCitiesByCountryName(string name)
        {
            return cityGateway.GetCitiesByCountryName(name);
        }
    }
}