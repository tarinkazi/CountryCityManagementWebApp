using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryCityManagementWebApp.DAL;
using CountryCityManagementWebApp.Models;
using CountryCityManagementWebApp.Models.ViewModel;

namespace CountryCityManagementWebApp.BLL
{
    public class CountryManager
    {
        CountryGateway countryGateway=new CountryGateway();

        public List<Country> GetAllCountries()
        {
            return countryGateway.GetAllCountries();
        }


        public int insertCountry(Country country)
        {
            if (IsCountryExist(country.CountryName))
            {
                throw new Exception("Country already exist");
            }
            if (country.CountryName=="")
            {
                throw new Exception("Please insert a Country Name"); 
            }
            return countryGateway.insertCountry(country);

            
        }

        public Country GetCountryByName(string name)
        {
            return countryGateway.GetCountryByName(name);
        }

        public bool IsCountryExist(string name)
        {
            bool isCountryExist = false;
            Country country = GetCountryByName(name);
            if (country != null)
            {
                isCountryExist = true;
            }
            return isCountryExist;
        }

        public List<CountryViews> GetAllCountrieswithNoofCitiesNoOfDweller()
        {
            return countryGateway.GetAllCountrieswithNoofCitiesNoOfDweller();
        }

        public List<CountryViews> GetCountrieswithNoofCitiesNoOfDweller(string name)
        {
            return countryGateway.GetCountrieswithNoofCitiesNoOfDweller(name);
        }
        

    }
}