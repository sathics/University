using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.UI;
using University.Models;
using University.DAL;

namespace University.BLL
{
    public class InformationManager
    {
        InformationGatway agatway = new InformationGatway();
        public string save(Information information2)
        {
            int rowaffected = agatway.save(information2);
            if(rowaffected>0)
            {
                return "Save Successfully";
            }
            else
            {
                return " Data are not Save";
            }
        }
        public List<Information> GetAllData()
        {
            return agatway.GetAllData();
        }

    }
}