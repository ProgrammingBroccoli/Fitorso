using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;

namespace Logic
{
    public class UserLogic
    {
        public UserContext _Context;

        public UserLogic()
        {
            _Context = new UserContext();
        }

        public void RegisterUser(string email, string password)
        {
            _Context.RegisterUser(email, password);
        }

        public User GetUserByEmail(string email)
        {
            var User = _Context.GetUserByEmail(email);
            return User;
        }

        public User ValidateUser(string email, string password)
        {
            var user = _Context.GetUserByEmail(email);
            if (user.Password == password)
            {
                return user;
            }

            return null;
            
        }

        public double GetWeightById(int Id)
        {
            return _Context.GetWeightById(Id);
            
        }

        public double GetFatById(int Id)
        {
            return _Context.GetFatById(Id);
            
        }

        public double GetBmiById(int Id)
        {
            return _Context.GetBmiById(Id);
        }

        public void AddWeight(double weight, int id)
        {
            _Context.AddWeight(weight, id);
        }

        public void AddFatpercentage(double fatPercentage, int id)
        {
            _Context.addFatpercentage(fatPercentage, id);
        }
        
        //NOT FUNCTIONAL

        public double CalcBmi(double weight, double height, int id)
        {
            var bmi = weight / (height*height);
            _Context.AddBmi(bmi, id);
            return bmi;
        }

        public double GetHeightById(int id)
        {
            return _Context.GetHeightById(id);
        }

        public List<Exercise> GetFavExercisesById(int id)
        {
            var favExercises = _Context.GetFavExercisesById(id);
            return favExercises;

        }

        public List<Musclegroup> GetMusclegroups()
        {
            return _Context.GetMusclgroups();
        }

        public void RemoveFavorite(int exerciseId, int UserId)
        {
            _Context.RemoveFavorite(exerciseId, UserId);
        }

        public void AddFavorite(int userId, int exerciseId)
        {
            _Context.AddNewFavorite(exerciseId, userId);
        }

        public List<Exercise> GetExercises()
        {
            return _Context.GetExercises();
        }

        public List<Exercise> GenerateTraining(User user)
        {
            List<Exercise> scheme= new List<Exercise>();
            List<Exercise> allExercises = new List<Exercise>();
            allExercises = _Context.GetExercises();

            var favExerises = _Context.GetFavExercisesById(user.Id);

            List<Exercise> chestExercises = favExerises.Where(e => e.MusclegroupId == 1).ToList();
            int chestCount = chestExercises.Count;
            List<Exercise> backExercises = favExerises.Where(e => e.MusclegroupId == 2).ToList();
            int backCount = backExercises.Count;
            List<Exercise> legExercises = favExerises.Where(e => e.MusclegroupId == 3).ToList();
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
            return _Context.GetAllWeightById(id);
        }

        public List<BodyMassValue> GetAllFatById(int id)
        {
            return _Context.GetAllFatById(id);

        }

        public List<BodyMassValue> GetAllBmiById(int id)
        {
            return _Context.GetAllBmiById(id);
        }

        public string GetQuote()
        {
            Random random = new Random();
            return _Context.GetQuoteById(random.Next(1, 8));
        }

        public List<MembershipType> GetMembershipTypes()
        {
           return  _Context.GetMembershipTypes();
        }
    }
}
