using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ModelLib.model;

namespace HotelDBREST.DBUtil
{
    public class ManageFacility
    {
        private const String GET_ALL = "SELECT * from DemoFacility";
        private const String GET_ONE = "SELECT * from DemoFacility WHERE Facility_No = @ID";
        private const String DELETE = "DELETE from DemoFacility WHERE Facility_No = @ID";
        private const String INSERT = "INSERT INTO DemoFacility values (@ID, @Name";
        private const String UPDATE = "UPDATE DemoFacility " +
                                      "SET Facility_No = @FacilityNo, Name = @Name " +
                                      "WHERE Facility_No = @ID";


        // GET: api/Hotels
        public IEnumerable<Facility> Get()
        {
            List<Facility> liste = new List<Facility>();

            SqlCommand cmd = new SqlCommand(GET_ALL, SQLConnectionSingleton.Instance.DbConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Facility facility = ReadFacility(reader);
                liste.Add(facility);
            }
            reader.Close();

            return liste;
        }

        // GET: api/Hotels/5
        public Facility Get(int id)
        {
            Facility facility = null;

            SqlCommand cmd = new SqlCommand(GET_ONE, SQLConnectionSingleton.Instance.DbConnection);
            cmd.Parameters.AddWithValue("@ID", id);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                facility = ReadFacility(reader);
            }
            reader.Close();

            return facility;
        }

        private Facility ReadFacility(SqlDataReader reader)
        {
            Facility facility = new Facility(reader.GetInt32(0), reader.GetString(1));

            return facility;
        }


        // POST: api/Hotels
        public bool Post(Facility facility)
        {
            SqlCommand cmd = new SqlCommand(INSERT, SQLConnectionSingleton.Instance.DbConnection);
            cmd.Parameters.AddWithValue("@ID", facility.Id);
            cmd.Parameters.AddWithValue("@Name", facility.Name);

            int rowsAffected;
            try
            {
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            return rowsAffected == 1;
        }

        // PUT: api/Hotels/5
        public bool Put(int id, Facility facility)
        {
            SqlCommand cmd = new SqlCommand(UPDATE, SQLConnectionSingleton.Instance.DbConnection);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@FacilityNo", facility.Id);
            cmd.Parameters.AddWithValue("@Name", facility.Name);

            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected == 1;
        }


        // DELETE: api/Hotels/5
        public bool Delete(int id)
        {
            SqlCommand cmd = new SqlCommand(DELETE, SQLConnectionSingleton.Instance.DbConnection);
            cmd.Parameters.AddWithValue("@ID", id);

            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected == 1;

        }
    }
}