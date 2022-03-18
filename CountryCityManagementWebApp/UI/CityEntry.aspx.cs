using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CKFinder;
using CountryCityManagementWebApp.BLL;
using CountryCityManagementWebApp.Models;
using CountryCityManagementWebApp.Models.ViewModel;

namespace CountryCityManagementWebApp.UI
{
    public partial class CityEntry : System.Web.UI.Page
    {
        CityManager cityManager=new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            FileBrowser fileBrowser = new FileBrowser();
            fileBrowser.BasePath = "/ckfinder";
            fileBrowser.SetupCKEditor(aboutCityCKEditorControl);
            LoadCoutryDropdown();
            ShowCountries();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string about = aboutCityCKEditorControl.Text;
                int noofDweller = Convert.ToInt32(dwellersTextBox.Text);
                string weather = weatherTextBox.Text;
                string location = locationTextBox.Text;
                int countryId = Convert.ToInt32(countryDropDownList.SelectedValue);
                City city = new City(name, about, noofDweller, location, weather, countryId);
                int rowAffeted = cityManager.InsertCity(city);
                if (rowAffeted > 0)
                {
                    Response.Write("Insert Successfully");
                    ShowCountries();
                }
                else
                {
                    Response.Write("Insertion Failed");

                }
            }
            catch (Exception exception)
            {
                
                Response.Write(exception.Message);
            }

        }

        private void LoadCoutryDropdown()
        {
            CountryManager countryManager = new CountryManager();
            List<Country> countries = countryManager.GetAllCountries();
          countryDropDownList.DataSource = countries;
            countryDropDownList.DataTextField = "CountryName";
            countryDropDownList.DataValueField = "Id";
            countryDropDownList.DataBind();

           }
        private void ShowCountries()
        {
            List<CityViewModel> cityList = cityManager.GetAllCitiesInfo();

            showCityGridView.DataSource = cityList;
            showCityGridView.DataBind();

        }

       
    }
}