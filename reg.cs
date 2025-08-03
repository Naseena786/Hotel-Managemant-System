using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace MVC_project__curd_.Models
{
    public class reg
    {
       
        public int id { get; set; }
        [Required(ErrorMessage ="can't be empty")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "can't be empty")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "can't be empty")]
        public string username { get; set; }
      

        public string gender { get; set; }
        public string password { get; set; }

        public string Confirmpassword { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "can't be empty")]
        public string phone { get; set; }
        public string Address { get; set; }
        [Range(0,100,ErrorMessage ="range should be 0-100")]

        public string Age { get; set; }
        public string Langknown { get; set; }
        public string Country { get; set; }


        public SqlConnection connection()
        {
            var connectionstring = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionstring);
            return con;
        }
        public List<reg> getdetails()
        {
            var con = connection();
            con.Open();
            var datalist = new List<reg>();
            SqlCommand cmd = new SqlCommand("sp_getinfo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();


            foreach (DataRow dr in dt.Rows)
            {
                datalist.Add(
                    new reg
                    {
                        id = Convert.ToInt32(dr["id"]),
                        Firstname = Convert.ToString(dr["Firstname"]),
                        Lastname = Convert.ToString(dr["Lastname"]),
                        username = Convert.ToString(dr["username"]),
                        gender = Convert.ToString(dr["gender"]),
                        password = Convert.ToString(dr["password"]),
                        Confirmpassword = Convert.ToString(dr["Confirmpassword"]),
                        Email = Convert.ToString(dr["Email"]),
                        phone = Convert.ToString(dr["phone"]),
                        Address = Convert.ToString(dr["Address"]),
                        Age = Convert.ToString(dr["Age"]),
                        Langknown = Convert.ToString(dr["Langknown"]),
                        Country = Convert.ToString(dr["Country"]),

                    });


            }
            return datalist;
        }
        public void createnew(reg obj)
        {
            var con = connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_add", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@Firstname",obj.Firstname);
            cmd.Parameters.AddWithValue("@Lastname",obj.Lastname);
            cmd.Parameters.AddWithValue("@username",obj.username);
            cmd.Parameters.AddWithValue("@gender", obj.gender);
            cmd.Parameters.AddWithValue("@password", obj.password);
            cmd.Parameters.AddWithValue("@Confirmpassword", obj.Confirmpassword);
            cmd.Parameters.AddWithValue("@Email", obj.Email);
            cmd.Parameters.AddWithValue("@phone", obj.phone);
            cmd.Parameters.AddWithValue("@Address", obj.Address);
            cmd.Parameters.AddWithValue("@Age", obj.Age);
            cmd.Parameters.AddWithValue("@Langknown", obj.Langknown);
            cmd.Parameters.AddWithValue("@Country", obj.Country);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void update(reg obj)
        {
            var con = connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",obj.id);
            cmd.Parameters.AddWithValue("@Firstname",obj.Firstname);
            cmd.Parameters.AddWithValue("@Lastname",obj.Lastname);
            cmd.Parameters.AddWithValue("@username",obj.username);
            cmd.Parameters.AddWithValue("@gender",obj.gender);
            cmd.Parameters.AddWithValue("@password",obj.password);
            cmd.Parameters.AddWithValue("@Confirmpassword",obj.Confirmpassword);
            cmd.Parameters.AddWithValue("@Email",obj.Email);
            cmd.Parameters.AddWithValue("@phone",obj.phone);
            cmd.Parameters.AddWithValue("@Address",obj.Address);
            cmd.Parameters.AddWithValue("@Age",obj. Age);
            cmd.Parameters.AddWithValue("@Langknown",obj.Langknown);
            cmd.Parameters.AddWithValue("@Country",obj.Country);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void delete(int id)
        {
            var con = connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<reg> getLang()
        {
            var Langlist = new List<reg>();
            var con = connection();
            SqlCommand cmd = new SqlCommand("sp_Lang", con);
            cmd.CommandType = CommandType.StoredProcedure;
         
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Langlist.Add(
                    new reg()
                    {
                        Langknown = Convert.ToString(dr["langs"])
                    });
            }

            return Langlist;


        }
        public List<reg> getcountry()
        {
            var coulist = new List<reg>();
            var con = connection();
            SqlCommand cmd = new SqlCommand("sp_Country", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                coulist.Add(
                    new reg()
                    {
                      Country = Convert.ToString(dr["countries"])
                    });
            }

            return coulist;

        }




    }
}