using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace IDAL
{
    public interface IUserContext
    {
        User GetUserByEmail(string email);
        void RegisterUser(string username, string password);
        double GetWeightById(int id);
        double GetFatById(int id);
        double GetBmiById(int id);
        void AddWeight(double weight, int id);
        void addFatpercentage(double fatPercentage, int id);
        void AddBmi(double bmi, int id);
        double GetHeightById(int id);
        List<Exercise> GetFavExercisesById(int id);
        List<Musclegroup> GetMusclgroups();
        void RemoveFavorite(int exerciseId, int userId);
        void AddNewFavorite(int exerciseId, int userId);
        List<Exercise> GetExercises();
        List<BodyMassValue> GetAllWeightById(int id);
        List<BodyMassValue> GetAllFatById(int id);
        List<BodyMassValue> GetAllBmiById(int id);
        string GetQuoteById(int next);
        List<MembershipType> GetMembershipTypes();
    }
}
