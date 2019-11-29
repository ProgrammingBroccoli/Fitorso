using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using IDAL;
using Model;

namespace DAL
{
    public class UserContext : IUserContext
    {
        public List<User> users;
        public List<MembershipType> membershipTypes;
        public List<BodyMassValue> bodyMassValues;
        public List<BodymassType> BodymassTypes;
        public List<Exercise> exercises;
        public List<Musclegroup> musclegroups;
        public List<Exercise_User_Favorite> userFavorites;
        public List<Quote> quotes;
        public UserContext()
        {
            users = new List<User>
            {
                new User {Id = 1, Firstname = "Bob", Lastname = "Bouwer", Email = "Bob", Password = "Test", Height = 1.80, MembershipTypeId = 1},
                new User {Id = 2, Firstname = "Steve", Lastname = "Hobbs", Email = "s.Hobbs@gmail.com", Password = "Test", Height = 1.60, MembershipTypeId = 2},
                new User {Id = 3, Firstname = "Buck", Lastname = "Buckle", Email = "BuckBuckles@Buckle.com", Password = "Test", Height = 1.75, MembershipTypeId = 2}
            };
            membershipTypes = new List<MembershipType>
            {
                new MembershipType{Id = 1, Name = "Free"},
                new MembershipType{Id = 2, Name = "Premium"}
            };
            bodyMassValues = new List<BodyMassValue>
            {
                //USER 1
                new BodyMassValue{Id = 1, BodymassTypeId = 1, UserId = 1, Date = "2019-10-11", Value = 80.6},
                new BodyMassValue{Id = 2, BodymassTypeId = 1, UserId = 1, Date = "2019-10-12", Value = 80.7},
                new BodyMassValue{Id = 3, BodymassTypeId = 1, UserId = 1, Date = "2019-12-13", Value = 81},

                new BodyMassValue{Id = 4, BodymassTypeId = 2, UserId = 1, Date = "2019-10-11", Value = 16.2},
                new BodyMassValue{Id = 5, BodymassTypeId = 2, UserId = 1, Date = "2019-10-12", Value = 16.4},
                new BodyMassValue{Id = 6, BodymassTypeId = 2, UserId = 1, Date = "2019-10-13", Value = 13.4},

                new BodyMassValue{Id = 7, BodymassTypeId = 3, UserId = 1, Date = "2019-10-11", Value = 20.1},
                new BodyMassValue{Id = 8, BodymassTypeId = 3, UserId = 1, Date = "2019-10-12", Value = 20.5},
                new BodyMassValue{Id = 9, BodymassTypeId = 3, UserId = 1, Date = "2019-10-13", Value = 19},
                
                //USER 2
                new BodyMassValue{Id = 10, BodymassTypeId = 1, UserId = 2, Date = "2019-10-11", Value = 76.9},
                new BodyMassValue{Id = 11, BodymassTypeId = 1, UserId = 2, Date = "2019-10-12", Value = 77.9},
                new BodyMassValue{Id = 12, BodymassTypeId = 1, UserId = 2, Date = "2019-10-13", Value = 77.0},

                new BodyMassValue{Id = 14, BodymassTypeId = 2, UserId = 2, Date = "2019-10-11", Value = 9.9},
                new BodyMassValue{Id = 15, BodymassTypeId = 2, UserId = 2, Date = "2019-10-12", Value = 9.3},
                new BodyMassValue{Id = 16, BodymassTypeId = 2, UserId = 2, Date = "2019-10-13", Value = 10.4},

                new BodyMassValue{Id = 17, BodymassTypeId = 3, UserId = 2, Date = "2019-10-11", Value = 19.4},
                new BodyMassValue{Id = 18, BodymassTypeId = 3, UserId = 2, Date = "2019-10-12", Value = 19.1},
                new BodyMassValue{Id = 19, BodymassTypeId = 3, UserId = 2, Date = "2019-10-13", Value = 18.5},
                
                //USER 2
                new BodyMassValue{Id = 20, BodymassTypeId = 1, UserId = 3, Date = "2019-10-11", Value = 77.9},
                new BodyMassValue{Id = 21, BodymassTypeId = 1, UserId = 3, Date = "2019-10-12", Value = 78.9},
                new BodyMassValue{Id = 22, BodymassTypeId = 1, UserId = 3, Date = "2019-10-13", Value = 78.0},

                new BodyMassValue{Id = 23, BodymassTypeId = 2, UserId = 3, Date = "2019-10-11", Value = 11.9},
                new BodyMassValue{Id = 24, BodymassTypeId = 2, UserId = 3, Date = "2019-10-12", Value = 11.3},
                new BodyMassValue{Id = 25, BodymassTypeId = 2, UserId = 3, Date = "2019-10-13", Value = 12.4},

                new BodyMassValue{Id = 26, BodymassTypeId = 3, UserId = 3, Date = "2019-10-11", Value = 17.4},
                new BodyMassValue{Id = 27, BodymassTypeId = 3, UserId = 3, Date = "2019-10-12", Value = 17.1},
                new BodyMassValue{Id = 28, BodymassTypeId = 3, UserId = 3, Date = "2019-10-13", Value = 18.5},
            };
            BodymassTypes = new List<BodymassType>
            {
                new BodymassType{Id = 1, Name = "Weight"},
                new BodymassType{Id = 2, Name = "FatPercentage"},
                new BodymassType{Id = 3, Name = "BMI"}
            };
            exercises = new List<Exercise>
            {
                new Exercise{Id = 1, Name = "Benchpress", Description = "Barbell push on a bench", MusclegroupId = 1},
                new Exercise{Id = 2, Name = "Dumbell Press", Description = "Pressing 2 dumbells on a bench", MusclegroupId = 1},
                new Exercise{Id = 3, Name = "Cable Fly's'", Description = "Chest activation with cables", MusclegroupId = 1},

                new Exercise{Id = 4, Name = "Pulldown", Description = "Pulldowm movement for your wings", MusclegroupId = 2},
                new Exercise{Id = 5, Name = "Close grip row", Description = "Row movement for back depth", MusclegroupId = 2},
                new Exercise{Id = 6, Name = "Barbell row", Description = "Barbell movement for back activation", MusclegroupId = 2},

                new Exercise{Id = 7, Name = "Squat", Description = "Movement that focuses all leg parts ", MusclegroupId = 3},
                new Exercise{Id = 8, Name = "Lunges", Description = "Walking movement for mainly quads", MusclegroupId = 3},
                new Exercise{Id = 9, Name = "Stiff Leg deadlift", Description = "Deadlift withoud bendin legs, focuses hamstrings", MusclegroupId = 3},

                new Exercise{Id = 10, Name = "Barbell overhead press", Description = "Barbell press over head, focuses shoulders", MusclegroupId = 4},
                new Exercise{Id = 11, Name = "Shoulder fly's'", Description = "Fly movement for main head of shoulder", MusclegroupId = 4},

                new Exercise{Id = 12, Name = "Front fly", Description = "Lying front fly", MusclegroupId = 5},
                new Exercise{Id = 13, Name = "Barbell shrugs", Description = "Pull movement with a barbell", MusclegroupId = 5},

                new Exercise{Id = 14, Name = "Skull crushers", Description = "Called skull crusher because the barbell moves over your head", MusclegroupId = 6},
                new Exercise{Id = 15, Name = "Tricep extention", Description = "Extention movement with cable", MusclegroupId = 6},

                new Exercise{Id = 16, Name = "Bicep curl", Description = "Curling movement for biceps", MusclegroupId = 7},
                new Exercise{Id = 17, Name = "Hammer curl", Description = "Curling movement for focusing bicep", MusclegroupId = 7},

                new Exercise{Id = 18, Name = "Sit up", Description = "Ab exercising focussing the main part of your sixpack", MusclegroupId = 8},
                new Exercise{Id = 19, Name = "Russian twist", Description = "Twisting ab movement for side abs", MusclegroupId = 8},
                new Exercise{Id = 20, Name = "Leg raises", Description = "Ab exercise focusing the lower part of your sixpack", MusclegroupId = 8},

            };
            musclegroups = new List<Musclegroup>
            {
                new Musclegroup{Id = 1, Name = "Chest"},
                new Musclegroup{Id = 2, Name = "Back"},
                new Musclegroup{Id = 3, Name = "Legs"},
                new Musclegroup{Id = 4, Name = "Shoulders"},
                new Musclegroup{Id = 5, Name = "Traps"},
                new Musclegroup{Id = 6, Name = "Triceps"},
                new Musclegroup{Id = 7, Name = "Biceps"},
                new Musclegroup{Id = 8, Name = "Abs"}

            };
            userFavorites = new List<Exercise_User_Favorite>
            {
                new Exercise_User_Favorite{UserId = 1, ExerciseId = 1},
                new Exercise_User_Favorite{UserId = 1, ExerciseId = 4},
                new Exercise_User_Favorite{UserId = 1, ExerciseId = 7},

                new Exercise_User_Favorite{UserId = 2, ExerciseId = 1},
                new Exercise_User_Favorite{UserId = 2, ExerciseId = 4},
                new Exercise_User_Favorite{UserId = 2, ExerciseId = 7},

                new Exercise_User_Favorite{UserId = 3, ExerciseId = 1},
                new Exercise_User_Favorite{UserId = 3, ExerciseId = 4},
                new Exercise_User_Favorite{UserId = 3, ExerciseId = 7},
            };
            quotes = new List<Quote>
            {
                new Quote{Id = 1, Text = "Aspire to inspire before we expire"},
                new Quote{Id = 2, Text = "Fitness is like a relationship. You can’t cheat and expect it to work"},
                new Quote{Id = 3, Text = "Work hard in silence. Let success be your noise"},
                new Quote{Id = 4, Text = "Rome wasn’t built in a day, but they worked on it every single day"},
                new Quote{Id = 5, Text = "Strive for progress, not perfection"},
                new Quote{Id = 6, Text = "All progress takes place outside the comfort zone"},
                new Quote{Id = 7, Text = "Well done is better than well said"},
                new Quote{Id = 8, Text = "A champion is someone who gets up when they can’t"},
            };
        }

        public User GetUserByEmail(string email)
        {
            var User = users.SingleOrDefault(m => m.Email == email);
            return User;
        }

        public void RegisterUser(string email, string password)
        {
            users.Add(new User {Email = email, Password = password, MembershipTypeId = 1});
        }

        public double GetWeightById(int id)
        {
            var value = bodyMassValues.FindAll(v => v.UserId == id && v.BodymassTypeId == 1)
                .OrderBy(v => v.Date)
                .First();
            return value.Value;
        }

        public double GetFatById(int id)
        {
            
            var value = bodyMassValues.FindAll(v => v.UserId == id && v.BodymassTypeId == 2)
                .OrderBy(v => v.Date)
                .First();
            return value.Value;
        }

        public double GetBmiById(int id)
        {
            var value = bodyMassValues.FindAll(v => v.UserId == id && v.BodymassTypeId == 3)
                .OrderBy(v => v.Date)
                .First();
            return value.Value;
        }

        public void AddWeight(double weight, int id)
        {
            bodyMassValues.Add(
                new BodyMassValue
                {
                    Id = 100,
                    BodymassTypeId = 1,
                    UserId = id,
                    Date = Convert.ToString(DateTime.Now),
                    Value = weight

                });
        }

        public void addFatpercentage(double fatPercentage, int id)
        {
            bodyMassValues.Add(
                new BodyMassValue
                {
                    Id = 101,
                    BodymassTypeId = 2,
                    UserId = id,
                    Date = Convert.ToString(DateTime.Now),
                    Value = fatPercentage

                });
        }

        public double GetHeightById(int id)
        {
            var value = users.SingleOrDefault(u => u.Id == id);
            return value.Height;
        }

        public void AddBmi(double bmi, int id)
        {
            bodyMassValues.Add(
                new BodyMassValue
                {
                    Id = 102,
                    BodymassTypeId = 3,
                    UserId = id,
                    Date = Convert.ToString(DateTime.Now),
                    Value = bmi

                });
        }

        public List<Exercise> GetFavExercisesById(int id)
        {
            var list = userFavorites.FindAll(u => u.UserId == id).ToList();
            List<Exercise> _exercises = new List<Exercise>();
            foreach (var var in list)
            {
                _exercises.Add(exercises.SingleOrDefault(e => e.Id == var.ExerciseId));
            }

            return _exercises;
        }

        public List<Musclegroup> GetMusclgroups()
        {
            return musclegroups;
        }

        public void RemoveFavorite(int exerciseId, int UserId)
        {
            var exercise = userFavorites.SingleOrDefault(e => e.UserId == UserId && e.ExerciseId == exerciseId);
            userFavorites.Remove(exercise);
        }

        public void AddNewFavorite(int exerciseId, int UserId)
        {
            userFavorites.Add( new Exercise_User_Favorite {ExerciseId = exerciseId, UserId = UserId} );
        }

        public List<Exercise> GetExercises()
        {
            return exercises;
        }

        public List<BodyMassValue> GetAllWeightById(int id)
        {
            var values = bodyMassValues.Where(i => i.UserId == id && i.BodymassTypeId == 1).ToList();
            return values;
        }

        public List<BodyMassValue> GetAllFatById(int id)
        {
            var values = bodyMassValues.Where(i => i.UserId == id && i.BodymassTypeId == 2).ToList();
            return values;
        }

        public List<BodyMassValue> GetAllBmiById(int id)
        {
            var values = bodyMassValues.Where(i => i.UserId == id && i.BodymassTypeId == 3).ToList();
            return values;
        }

        public string GetQuoteById(int id)
        {
            var quote = quotes.SingleOrDefault(i => i.Id == id).Text;
            return quote;
        }

        public List<MembershipType> GetMembershipTypes()
        {
            return membershipTypes;
            
        }
    }

}
