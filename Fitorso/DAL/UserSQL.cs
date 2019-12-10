using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using IDAL;
using Model;

namespace DAL
{
    class UserSQL : IUserContext
    {
        private string connectionstring = @"Server = studmysql01.fhict.local; Uid=dbi401279;Database=dbi401279;Pwd=Achtrortum4;";

        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private string sql = "";

        public User GetUserByEmail(string email)
        {
           cnn = new SqlConnection(connectionstring);
           sql = "SELECT ";
           cnn.Open();
           return new User
           {
               
           };
        }

        public void RegisterUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public double GetWeightById(int id)
        {
            throw new NotImplementedException();
        }

        public double GetFatById(int id)
        {
            throw new NotImplementedException();
        }

        public double GetBmiById(int id)
        {
            throw new NotImplementedException();
        }

        public void AddWeight(double weight, int id)
        {
            throw new NotImplementedException();
        }

        public void addFatpercentage(double fatPercentage, int id)
        {
            throw new NotImplementedException();
        }

        public void AddBmi(double bmi, int id)
        {
            throw new NotImplementedException();
        }

        public double GetHeightById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Exercise> GetFavExercisesById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Musclegroup> GetMusclgroups()
        {
            throw new NotImplementedException();
        }

        public void RemoveFavorite(int exerciseId, int userId)
        {
            throw new NotImplementedException();
        }

        public void AddNewFavorite(int exerciseId, int userId)
        {
            throw new NotImplementedException();
        }

        public List<Exercise> GetExercises()
        {
            throw new NotImplementedException();
        }

        public List<BodyMassValue> GetAllWeightById(int id)
        {
            throw new NotImplementedException();
        }

        public List<BodyMassValue> GetAllFatById(int id)
        {
            throw new NotImplementedException();
        }

        public List<BodyMassValue> GetAllBmiById(int id)
        {
            throw new NotImplementedException();
        }

        public string GetQuoteById(int next)
        {
            throw new NotImplementedException();
        }

        public List<MembershipType> GetMembershipTypes()
        {
            throw new NotImplementedException();
        }
    }
}
