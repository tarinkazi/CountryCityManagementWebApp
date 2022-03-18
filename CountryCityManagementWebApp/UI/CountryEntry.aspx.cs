using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;
using CKFinder;
using CountryCityManagementWebApp.BLL;
using CountryCityManagementWebApp.Models;

namespace CountryCityManagementWebApp
{
    public partial class CountryEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FileBrowser fileBrowser=new FileBrowser();
            fileBrowser.BasePath = "/ckfinder";
            fileBrowser.SetupCKEditor(aboutCKEditorControl);


            ShowCountries();

        }

        CountryManager countryManager=new CountryManager();

        protected void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string about = aboutCKEditorControl.Text;
                Country country = new Country(name, about);

                int rowAffected = countryManager.insertCountry(country);
                if (rowAffected > 0)
                {
                    Response.Write("Saved Succesfully");
                    ShowCountries();
                }
                else
                {
                    Response.Write("Insert Failed");
                }
           
            }
            catch (Exception exception)
            {
                
                Response.Write(exception.Message);
            }

        }
        private void ShowCountries()
        {
            List<Country> countryList = countryManager.GetAllCountries();

            CountryEntryGridView.DataSource = countryList;
            CountryEntryGridView.DataBind();
        }

       

      
    }
}