using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryCityManagementWebApp.Models;
using CountryCityManagementWebApp.Models.ViewModel;

namespace CountryCityManagementWebApp.DAL
{
    public class CityGateway:Gateway
    {
        public int InsertCity(City city)
        {
            string query =
                "INSERT INTO Cities(Name,About,NoofDweller,Location,Weather,CountryId) VALUES('" + city.CityName + "', '" + city.CityAbout+ "','" +
                city.CityNoofDwellers + "','" + city.CityLocation + "','" + city.CityWeather + "','"+city.CountryId+"')";

            Command.CommandText = query;
            Connection.Open();

            int rowAffected = Command.ExecuteNonQuery();

            Connection.Close();
            return rowAffected;
        }
       
        public List<City> GetAllCities()
        {
            int i = 1;
            List<City> cityList=new List<City>();
            string query = "select * from Cities";
            Command.CommandText = query;
            Connection.Open();
             SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string name = reader["Name"].ToString();
                string about = reader["About"].ToString();
                int noofDweller = Convert.ToInt32(reader["NoofDweller"].ToString());
                string location = reader["Location"].ToString();
                 string weather = reader["Weather"].ToString();
                int countryId = Convert.ToInt32(reader["CountryId"]);
                int sl = i;

                City city = new City(sl,id, name, about, noofDweller, location, weather,countryId);

                cityList.Add(city);
                i++;
            }
            reader.Close();
            Connection.Close();
            return cityList;
        }

        public City GetCityByName(string name)
        {
            string query = "SELECT * FROM Cities WHERE Name='" + name + "'";
            Command.CommandText = query;
            Connection.Open();
            City city = null;
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int id = Convert.ToInt32(reader["Id"]);
                string Cityname = reader["Name"].ToString();
                string about = reader["About"].ToString();
                int noofDweller = Convert.ToInt32(reader["NoofDweller"].ToString());
                string location = reader["Location"].ToString();
                string weather = reader["Weather"].ToString();
                int countryId = Convert.ToInt32(reader["CountryId"]);



                reader.Close();
                city = new City(id, name, about, noofDweller, location, weather, countryId);

            }
            Connection.Close();
            return city;
        }

        public List<CityViewModel> GetAllCitiesInfo()
        {
            int i = 1;
            string query = "select * from VW_GetAllCitiesInfo";
            Command.CommandText = query;
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            List<CityViewModel> ListofCities=new List<CityViewModel>();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string name = reader["Name"].ToString();
                string about = reader["About"].ToString();
                int noofDweller = Convert.ToInt32(reader["NoofDweller"].ToString());
                string location = reader["Location"].ToString();
                string weather = reader["Weather"].ToString();
                int countryId = Convert.ToInt32(reader["CountryId"]);
                string CountryName = reader["CountryName"].ToString();

                int sl = i;

                CityViewModel city = new CityViewModel();
                city.CitySL = sl;
                city.CityId = id;
                city.CityAbout = about;
                city.CityName = name;
                city.CityNoofDwellers = noofDweller;
                city.CityLocation = location;
                city.CityWeather = weather;
                city.CountryId = countryId;
                city.CountryName = CountryName;
                ListofCities.Add(city);
              
                i++;
            }
            reader.Close();
            Connection.Close();
            return ListofCities;
        }

        public List<CitiesByNameViewModel> GetCitiesByName(string name)
        {
            int i = 1;
            string query = "SELECT C.*,Co.Name as CountryName,Co.About as CountryAbout from Cities C left outer join Countries Co ON C.CountryId=Co.Id WHERE C.Name LIKE '%"+name+"%'";
           // string query = "SELECT C.*,Co.* from Cities C left outer join Countries Co ON C.CountryId=Co.Id WHERE C.Name LIKE '%"+name+"%'";
            Command.CommandText = query;
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            List<CitiesByNameViewModel> ListofCities = new List<CitiesByNameViewModel>();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string cityName = reader["Name"].ToString();
                string about = reader["About"].ToString();
                int noofDweller = Convert.ToInt32(reader["NoofDweller"].ToString());
                string location = reader["Location"].ToString();
                string weather = reader["Weather"].ToString();
                int countryId = Convert.ToInt32(reader["CountryId"]);
                string countryName = reader["CountryName"].ToString();
                string countryAbout = reader["CountryAbout"].ToString();

                int sl = i;

                CitiesByNameViewModel city = new CitiesByNameViewModel();
                city.CitySL = sl;
                city.CityId = id;
                city.CityAbout = about;
                city.CityName = cityName;
                city.CityNoofDwellers = noofDweller;
                city.CityLocation = location;
                city.CityWeather = weather;
                city.CountryId = countryId;
                city.CountryName = countryName;
                city.CountryAbout = countryAbout;
                ListofCities.Add(city);

                i++;
            }
            reader.Close();
            Connection.Close();
            return ListofCities;
        }
        public List<CitiesByNameViewModel> GetCitiesByCountryName(string name)
        {
            int i = 1;
            string query = "SELECT C.*,Co.Name as CountryName,Co.About as CountryAbout from Cities C left outer join Countries Co ON C.CountryId=Co.Id WHERE Co.Name LIKE '%" + name + "%'";
            // string query = "SELECT C.*,Co.* from Cities C left outer join Countries Co ON C.CountryId=Co.Id WHERE C.Name LIKE '%"+name+"%'";
            Command.CommandText = query;
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            List<CitiesByNameViewModel> ListofCities = new List<CitiesByNameViewModel>();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string cityName = reader["Name"].ToString();
                string about = reader["About"].ToString();
                int noofDweller = Convert.ToInt32(reader["NoofDweller"].ToString());
                string location = reader["Location"].ToString();
                string weather = reader["Weather"].ToString();
                int countryId = Convert.ToInt32(reader["CountryId"]);
                string countryName = reader["CountryName"].ToString();
                string countryAbout = reader["CountryAbout"].ToString();

                int sl = i;

                CitiesByNameViewModel city = new CitiesByNameViewModel();
                city.CitySL = sl;
                city.CityId = id;
                city.CityAbout = about;
                city.CityName = cityName;
                city.CityNoofDwellers = noofDweller;
                city.CityLocation = location;
                city.CityWeather = weather;
                city.CountryId = countryId;
                city.CountryName = countryName;
                city.CountryAbout = countryAbout;
                ListofCities.Add(city);

                i++;
            }
            reader.Close();
            Connection.Close();
            return ListofCities;
        }
    }
}