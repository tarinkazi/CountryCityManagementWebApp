using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityManagementWebApp.BLL;
using CountryCityManagementWebApp.Models.ViewModel;

namespace CountryCityManagementWebApp.UI
{
    public partial class ViewCountries : System.Web.UI.Page
    {CountryManager countryManager=new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowCountries();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                string name = nameTextBox.Text;
                
                       ShowCountriesByName(name);
                

            }
        }
        private void ShowCountries()
        {
            List<CountryViews> countryList = countryManager.GetAllCountrieswithNoofCitiesNoOfDweller();
            showGridView.DataSource = countryList;
                showGridView.DataBind();
           

        }
        private void ShowCountriesByName(string name)
        {
            List<CountryViews> countryList = countryManager.GetCountrieswithNoofCitiesNoOfDweller(name);
            showGridView.DataSource = countryList;
            showGridView.DataBind();


        }
    }
}