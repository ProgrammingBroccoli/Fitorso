using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;
using IDAL;
using Model;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class UserSQL : IUserContext
    {
        private string connectionstring =
            "Server=studmysql01.fhict.local;Uid=dbi401279;Database=dbi401279;Pwd=Achtrortum4;";

        public MySqlConnection connection;
        public MySqlCommand command;
        string sql = null;

        public UserSQL()
        {
            connection = new MySqlConnection(connectionstring);
        }
        public User GetUserByEmail(string email)
        {
            User user = new User();

            sql = "SELECT * FROM user WHERE email = '" + email + "'";

            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                user.Id = reader.GetInt32(0);
                user.Firstname = reader.GetString(1);
                user.MembershipTypeId = reader.GetInt32(6);
                user.Password = reader.GetString(7);
                user.Email = reader.GetString(3);
                user.Height = reader.GetFloat(5);
            }
            connection.Close();
            return user;
        }

        public void RegisterUser(string firstname, string lastname, string email, string password, double length)
        {
            sql =
                "INSERT INTO user (firstname, lastname, email, length, membershiptypeid, password) VALUES('" + firstname + "', '" + lastname + "', '" +
                email + "'," + length + ", 1, '" + password + "');";
            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public double GetWeightById(int id)
        {
            sql = "Call GetWeightById(" + id + ");";

            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            double result = 0;
            while (reader.Read())
            {
                result = reader.GetDouble(0);
            }
            connection.Close();
            return result;
        }

        public double GetFatById(int id)
        {
            sql = "Call GetFatById(" + id + ");";

            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            double result = 0;
            while (reader.Read())
            {
                result = reader.GetDouble(0);
            }
            connection.Close();
            return result;
        }

        public double GetBmiById(int id)
        {
            sql = "Call GetBmiById(" + id + ");";

            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            double result = 0;
            while (reader.Read())
            {
                result = reader.GetDouble(0);
            }
            connection.Close();
            return result;
        }

        public void AddWeight(double weight, int id)
        {
            sql = "CALL AddWeight(" + weight + ", " + id + ")";
            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void addFatpercentage(double fatPercentage, int id)
        {
            sql = "CALL AddFatPercentage(" + fatPercentage + ", " + id + ")";
            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void AddBmi(double bmi, int id)
        {
            sql = "CALL AddBmi(" + bmi + ", " + id + ")";
            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public double GetHeightById(int id)
        {
            sql = "Call GetHeightById(" + id + ");";

            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            double result = 0;
            while (reader.Read())
            {
                result = reader.GetDouble(0);
            }
            connection.Close();
            return result;
        }

        public List<int> GetExercisesIds(int id)
        {
            //GET IDS
            sql = "Call GetExerciseIds(" + id + ");";

            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            List<int> list = new List<int>();
            while (reader.Read())
            {
                list.Add(reader.GetInt32(0));
            }
            connection.Close();
            return list;
        }

        public Exercise GetFavExerciseById(int id)
        {
            sql = "Call GetExerciseById(" + id + ");";
            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            Exercise exercise = new Exercise();
            while (reader.Read())
            {
                exercise.Id = reader.GetInt32(0);
                exercise.Name = reader.GetString(1);
                exercise.Description = reader.GetString(2);
                exercise.MusclegroupId = reader.GetInt32(3);
            }
            connection.Close();
            return exercise;
        }

        public List<Musclegroup> GetMusclgroups()
        {
            sql = "Call GetMusclegroups();";

            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            List<Musclegroup> musclegroups = new List<Musclegroup>();
            while (reader.Read())
            {
                Musclegroup musclegroup = new Musclegroup
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                };
                musclegroups.Add(musclegroup);

            }
            connection.Close();
            return musclegroups;
        }

        public void RemoveFavorite(int exerciseId, int userId)
        {
            sql = "CALL RemoveFavExercise(" + exerciseId + ", " + userId + ")";
            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void AddNewFavorite(int exerciseId, int userId)
        {
            sql = "CALL AddFavorite(" + exerciseId + ", " + userId + ")";
            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<Exercise> GetExercises()
        {
            sql = "Call GetAllExercises();";

            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            List<Exercise> exercises = new List<Exercise>();
            while (reader.Read())
            {
                Exercise exercise = new Exercise
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                    MusclegroupId = reader.GetInt32(3)
                };
                exercises.Add(exercise);
            }
            connection.Close();
            return exercises;
        }

        public List<BodyMassValue> GetAllWeightById(int id)
        {
            sql = "Call GetAllWeightById(" + id + ");";

            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            List<BodyMassValue> result = new List<BodyMassValue>();
            while (reader.Read())
            {
                BodyMassValue value = new BodyMassValue
                {
                    Id = reader.GetInt32(0),
                    Value = reader.GetFloat(1),
                    Date = reader.GetString(2),
                    UserId = reader.GetInt32(3),
                    BodymassTypeId = reader.GetInt32(4)
                };
                result.Add(value);
            }
            connection.Close();
            return result;
        }

        public List<BodyMassValue> GetAllFatById(int id)
        {
            sql = "Call GetAllFatById(" + id + ");";

            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            List<BodyMassValue> result = new List<BodyMassValue>();
            while (reader.Read())
            {
                BodyMassValue value = new BodyMassValue
                {
                    Id = reader.GetInt32(0),
                    Value = reader.GetFloat(1),
                    Date = reader.GetString(2),
                    UserId = reader.GetInt32(3),
                    BodymassTypeId = reader.GetInt32(4)
                };
                result.Add(value);
            }
            connection.Close();
            return result;
        }

        public List<BodyMassValue> GetAllBmiById(int id)
        {
            sql = "Call GetAllBmiById(" + id + ");";

            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            List<BodyMassValue> result = new List<BodyMassValue>();
            while (reader.Read())
            {
                BodyMassValue value = new BodyMassValue
                {
                    Id = reader.GetInt32(0),
                    Value = reader.GetFloat(1),
                    Date = reader.GetString(2),
                    UserId = reader.GetInt32(3),
                    BodymassTypeId = reader.GetInt32(4)
                };
                result.Add(value);
            }
            connection.Close();
            return result;
        }

        public string GetQuoteById(int next)
        {
            sql = "Call GetQuoteById(" + next + ");";

            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            string result = "";
            while (reader.Read())
            {
                result = reader.GetString(0);
            }
            connection.Close();
            return result;
        }

        public List<MembershipType> GetMembershipTypes()
        {
            sql = "Call GetMembershiptypes();";

            connection.Open();
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            List<MembershipType> types = new List<MembershipType>();
            while (reader.Read())
            {
                MembershipType type = new MembershipType
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                };
                types.Add(type);
            }
            connection.Close();
            return types;
        }
    }
}
