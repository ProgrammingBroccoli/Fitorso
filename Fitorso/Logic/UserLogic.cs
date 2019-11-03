using System;
using System.Collections.Generic;
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
    }
}
