using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_project__curd_.Models
{
    public class hotel
    {
        public int id { get; set; }
        [Required(ErrorMessage ="required")]
        public string username { get; set; }
        [Required(ErrorMessage ="required")]
        public string Roomtype { get; set; }
        public string Amenities { get; set; }
        public SqlConnection connection()
        {
            var connectionstring = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionstring);
            return con;
        }
        public List<hotel> gethoteldetails()
        {
            var con = connection();
            con.Open();
            var datalist = new List<hotel>();
            SqlCommand cmd = new SqlCommand("sp_hotel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                datalist.Add(
                    new hotel
                    {
                        id = Convert.ToInt32(dr["id"]),
                        username = Convert.ToString(dr["username"]),
                        Roomtype = Convert.ToString(dr["Roomtype"]),
                        Amenities = Convert.ToString(dr["Amenities"]),
                    });
            }
            return datalist;
        }
        public void create(hotel obj)
        {
            var con = connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_hotelcreate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@username", obj.username);
            cmd.Parameters.AddWithValue("@Roomtype", obj.Roomtype);
            cmd.Parameters.AddWithValue("@Amenities", obj.Amenities);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updatehotel(hotel obj)
        {
            var con = connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_hotelupdate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@username", obj.username);
            cmd.Parameters.AddWithValue("@Roomtype", obj.Roomtype);
            cmd.Parameters.AddWithValue("@Amenities", obj.Amenities);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void deletehotel(int id)
        {
            var con = connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_hoteldelete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            con.Close();

        }
       public List<hotel>getamenities()
        {
            var list=new List<hotel>();
            var con = connection();
            SqlCommand cmd = new SqlCommand("sp_amenity", con);
            cmd.CommandType= CommandType.StoredProcedure;
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(
                    new hotel()
                    {
                        Amenities = Convert.ToString(dr["amenityvalues"])

                    });
            }
            return list;
        }
    }
}




