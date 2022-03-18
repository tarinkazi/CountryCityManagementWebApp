using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityManagementWebApp.BLL;
using CountryCityManagementWebApp.Models;
using CountryCityManagementWebApp.Models.ViewModel;

namespace CountryCityManagementWebApp.UI
{
    public partial class CiewCities : System.Web.UI.Page
    {CityManager cityManager=new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCoutryDropdown();
            }
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            lblSeletedRating = rbtLstRating.SelectedValue;
          //  if (cityNameRadioButton.Checked == true)
            if (lblSeletedRating=="e")
           
            {
                if (cityNameTextBox.Text != "")
                {
                    string name = cityNameTextBox.Text;
                    List<CitiesByNameViewModel> ListofCitiesInfo = cityManager.GetCitiesByName(name);
                    showGridView.DataSource = ListofCitiesInfo;
                    showGridView.DataBind();
                }
                else
                {
                    Response.Write("Please Enter a Text");
                }


            }
           // else if (countryNameRadioButton.Checked == true)
            else if (lblSeletedRating=="v")
            
            {
                string name = countryDropDownList.SelectedItem.Text;
                List<CitiesByNameViewModel> listOfCitiesInfo = cityManager.GetCitiesByCountryName(name);
                showGridView.DataSource = listOfCitiesInfo;
                showGridView.DataBind();
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

        string lblSeletedRating;
        protected void rbtLstRatingButton_Click(object sender, EventArgs e)
        {
            //if (rbtLstRating.SelectedItem != null)
            //{
            //    // lblSeletedRating = rbtLstRating.SelectedItem.Text;
            //    lblSeletedRating = rbtLstRating.SelectedValue;
            //    // return lblSeletedRating;
            //}
        }

        protected void countryDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}