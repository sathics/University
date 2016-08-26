using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using University.BLL;
using University.DAL;
using University.Models;

namespace University.UI
{
    
    public partial class PersonalData : System.Web.UI.Page
    {
        InformationManager amanager = new InformationManager();
        Information information3 = new Information();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            information3.Firstname = firstNameTextBox.Text;
            information3.Lastname = lastNameTextBox.Text;
            information3.Fathername = fatherNameTextBox.Text;
            information3.Mothername = motherNameTextBox.Text;
            information3.Dateofbirth = Convert.ToDateTime(datepicker.Text.ToString()) ;
            information3.Mobileno=int.Parse(mobileNumberTextBox.Text.ToString());
            information3.Village=villageNameTextBox.Text;
            information3.Thana=thanaNameTextBox.Text;
            information3.District=districtNameTextBox.Text;
            information3.Country=countryNameDropDownList.ToString();


            messageLabel.Text = amanager.save(information3);
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
             
        
            List<Information> aList = amanager.GetAllData();
            personalInformationGridView.DataSource = aList;
            personalInformationGridView.DataBind();
        
            
        }
    }
}