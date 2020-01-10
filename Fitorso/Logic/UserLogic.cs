using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using DAL;
using IDAL;
using Model;

namespace Logic
{
    public class UserLogic
    {
        private IUserContext _Context;
        private IUserContext _sqlContext;

        public UserLogic()
        {
           // _Context = new UserContext();
            _sqlContext = new UserSQL();
        }

        public void RegisterUser(string firstname, string lastname, string email, string password, double height)
        {
            _sqlContext.RegisterUser(firstname, lastname, email, password, height);
        }

        public User GetUserByEmail(string email)
        {
            var User = _sqlContext.GetUserByEmail(email);
            return User;
        }

        public User ValidateUser(string email, string password)
        {
            var user = _sqlContext.GetUserByEmail(email);
            if (user.Password == password)
            {
                return user;
            }

            return null;
            
        }

        public double GetWeightById(int Id)
        {
            return _sqlContext.GetWeightById(Id);
            
        }

        public double GetFatById(int Id)
        {
            return _sqlContext.GetFatById(Id);
            
        }

        public double GetBmiById(int Id)
        {
            return _sqlContext.GetBmiById(Id);
        }

        public void AddWeight(double weight, int id)
        {
            _sqlContext.AddWeight(weight, id);
        }

        public void AddFatpercentage(double fatPercentage, int id)
        {
            _sqlContext.addFatpercentage(fatPercentage, id);
        }
        
        //NOT FUNCTIONAL

        public double CalcBmi(double weight, double height, int id)
        {
            var bmi = weight / (height*height);
            _sqlContext.AddBmi(bmi, id);
            return bmi;
        }

        public double GetHeightById(int id)
        {
            return _sqlContext.GetHeightById(id);
        }

        public List<Exercise> GetFavExercisesById(int id)
         {
            var ids = _sqlContext.GetExercisesIds(id);
            List<Exercise> favExercises = new List<Exercise>();
            foreach (var i in ids)
            {
                favExercises.Add(_sqlContext.GetFavExerciseById(i));
            }
            return favExercises;

        }

        public List<Musclegroup> GetMusclegroups()
        {
            return _sqlContext.GetMusclgroups();
        }

        public void RemoveFavorite(int exerciseId, int UserId)
        {
            _sqlContext.RemoveFavorite(exerciseId, UserId);
        }

        public void AddFavorite(int userId, int exerciseId)
        {
            _sqlContext.AddNewFavorite(exerciseId, userId);
        }

        public List<Exercise> GetExercises()
        {
            return _sqlContext.GetExercises();
        }

        public List<Exercise> GenerateTraining(User user)
        {
            List<Exercise> scheme= new List<Exercise>();
            List<Exercise> allExercises = new List<Exercise>();
            allExercises = _sqlContext.GetExercises();

            var ids = _sqlContext.GetExercisesIds(user.Id);
            List<Exercise> favExercises = new List<Exercise>();
            foreach (var i in ids)
            {
                favExercises.Add(_sqlContext.GetFavExerciseById(i));
            }

            

            List<Exercise> chestExercises = favExercises.Where(e => e.MusclegroupId == 1).ToList();
            int chestCount = chestExercises.Count;
            List<Exercise> backExercises = favExercises.Where(e => e.MusclegroupId == 2).ToList();
            int backCount = backExercises.Count;
            List<Exercise> legExercises = favExercises.Where(e => e.MusclegroupId == 3).ToList();
            int legCount = legExercises.Count;

            if (chestCount < 4)
            {
                int count = 0;

                foreach (var item in chestExercises)
                {
                    scheme.Add(item);
                    count++;
                }
            }
            if (backCount < 4)
            {
                int count = 0;

                foreach (var item in backExercises)
                {
                    scheme.Add(item);
                    count++;
                }
            }
            if (legCount < 4)
            {
                int count = 0;

                foreach (var item in legExercises)
                {
                    scheme.Add(item);
                    count++;
                }
            }

            scheme.Add(allExercises.Find(e => e.MusclegroupId == 4));
            scheme.Add(allExercises.Find(e => e.MusclegroupId == 5));
            scheme.Add(allExercises.Find(e => e.MusclegroupId == 6));
            scheme.Add(allExercises.Find(e => e.MusclegroupId == 7));
            scheme.Add(allExercises.Find(e => e.MusclegroupId == 8));
            return scheme;
        }

        public List<BodyMassValue> GetAllWeightById(int id)
        {
            return _sqlContext.GetAllWeightById(id);
        }

        public List<BodyMassValue> GetAllFatById(int id)
        {
            return _sqlContext.GetAllFatById(id);

        }

        public List<BodyMassValue> GetAllBmiById(int id)
        {
            return _sqlContext.GetAllBmiById(id);
        }

        public string GetQuote()
        {
            Random random = new Random();
            return _sqlContext.GetQuoteById(random.Next(1, 8));
        }

        public List<MembershipType> GetMembershipTypes()
        {
           return  _sqlContext.GetMembershipTypes();
        }
    }
}
