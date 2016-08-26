using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using University.BLL;
using University.Models;
using University.UI;

namespace University.DAL
{
    public class InformationGatway
    {
        string connectionstring = WebConfigurationManager.ConnectionStrings["informationconnect"].ConnectionString;
       

        public int save(Information Information1)
        {
            SqlConnection connections = new SqlConnection(connectionstring);
            string query = "insert into details(FirstName,LastName,FatherName,MotherName,DateOfBirth,MobileNo,Village,Thana,District,Country) values('"+Information1.Firstname
                +"','"+Information1.Lastname+"','"+Information1.Fathername+"','"+Information1.Mothername
                +"','"+Information1.Dateofbirth+"','"+Information1.Mobileno+"','"+Information1.Village
                +"','"+Information1.Thana+"','"+Information1.District+"','"+Information1.Country+"')";
            SqlCommand command = new SqlCommand(query, connections);
            connections.Open();
            int rowAffected = command.ExecuteNonQuery();
            connections.Close();
            return rowAffected;
        }
        public List<Information> GetAllData()
    {
        SqlConnection connections = new SqlConnection(connectionstring);

        string query = "select * from details";
        SqlCommand command=new SqlCommand(query, connections);
        connections.Open();
        SqlDataReader reader = command.ExecuteReader();
            List<Information> alist=new List<Information>();
           Information alist1 = null;
            while(reader.Read())
            {
                alist1 = new Information();
                alist1.Firstname = reader["FirstName"].ToString();
                alist1.Lastname = reader["LastName"].ToString();
                alist1.Fathername = reader["FatherName"].ToString();
                alist1.Mothername = reader["MotherName"].ToString();
                alist1.Dateofbirth = Convert.ToDateTime(reader["DateOfBirth"]);
                alist1.Mobileno = Convert.ToInt32(reader["MobileNo"]);
                alist1.Village = reader["Village"].ToString();
                alist1.Thana = reader["Thana"].ToString();
                alist1.District = reader["District"].ToString();
                alist1.Country = reader["Country"].ToString();

                alist.Add(alist1);

                
            }
            reader.Close();
            connections.Close();
            return alist;




    }
    }
}