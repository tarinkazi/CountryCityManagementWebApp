using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using CountryCityManagementWebApp.Models;
using CountryCityManagementWebApp.Models.ViewModel;

namespace CountryCityManagementWebApp.DAL
{

    
    public class CountryGateway:Gateway
    {
        

        public List<Country> GetAllCountries()
        {
            int i = 1;
            List<Country> countryList = new List<Country>();



            string query = "select * from Countries order by Name asc";

         Command.CommandText = query;
            Connection.Open();

            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["ID"]);
                string name = reader["Name"].ToString();
                string about = reader["About"].ToString();
                int sl = i;
               

                Country country = new Country(id, name,about,sl);

                countryList.Add(country);
                i++;
            }
            reader.Close();
            Connection.Close();
            return countryList;
        }
        public int insertCountry(Country country)
        {
            
          
          
            string query =
                "INSERT INTO Countries(Name,About) VALUES('" + country.CountryName + "', '" + country.CountryAbout + "')";


           
          
            Command.CommandText = query;

            Connection.Open();

            int rowAffected = Command.ExecuteNonQuery();

            Connection.Close();
            return rowAffected;
        }

        public Country GetCountryByName(string name)
        {
            
            string query = "SELECT * FROM Countries WHERE Name='" + name + "'";
          
            Command.CommandText = query;
            Connection.Open();
            Country country = null;
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int id = Convert.ToInt32(reader["ID"]);
                string Cname = reader["Name"].ToString();
                string about = reader["About"].ToString();
                
              
               
                reader.Close();
                country = new Country(id,Cname, about);

            }
            Connection.Close();
            return country;
        }

        public List<CountryViews> GetAllCountrieswithNoofCitiesNoOfDweller()
        {
            int i = 1;
            List<CountryViews> countryList = new List<CountryViews>();



            string query = "select co.Name,co.About,count(c.Name) as NoOfCities,sum(c.NoofDweller) as NoOfCityDwellers from  Countries co inner join Cities c on co.Id=c.CountryId group by co.Name,co.About order by co.Name asc";

            Command.CommandText = query;
            Connection.Open();

            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                string countryName = reader["Name"].ToString();
                string about = reader["About"].ToString();
                int noofDweller = Convert.ToInt32(reader["NoOfCityDwellers"].ToString());
              int NoOfCities = Convert.ToInt32(reader["NoOfCities"]);
              
                int sl = i;


                CountryViews country = new CountryViews();
                country.CountryName = countryName;
                country.CountryAbout = about;
                country.TotalNoOgDwellers = noofDweller;
                country.NoOfCities = NoOfCities;
                country.SL = sl;


                countryList.Add(country);
                i++;
            }
            reader.Close();
            Connection.Close();
            return countryList;
        }


        public List<CountryViews> GetCountrieswithNoofCitiesNoOfDweller(string name)
        {
            int i = 1;
            List<CountryViews> countryList = new List<CountryViews>();


            string query = "select cn.Name,cn.About,count(c.Name) as NoOfCities,sum(c.NoofDweller) as NoOfCityDwellers from  Countries cn inner join Cities c on cn.Id=c.CountryId WHERE cn.Name like'%"+ name +"%'group by cn.Name,cn.About ";
         

            Command.CommandText = query;
            Connection.Open();

            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                string countryName = reader["Name"].ToString();
                string about = reader["About"].ToString();
                int noofDweller = Convert.ToInt32(reader["NoOfCityDwellers"].ToString());
                int NoOfCities = Convert.ToInt32(reader["NoOfCities"]);

                int sl = i;


                CountryViews country = new CountryViews();
                country.CountryName = countryName;
                country.CountryAbout = about;
                country.TotalNoOgDwellers = noofDweller;
                country.NoOfCities = NoOfCities;
                country.SL = sl;


                countryList.Add(country);
                i++;
            }
            reader.Close();
            Connection.Close();
            return countryList;
        }


          
        
    }
}