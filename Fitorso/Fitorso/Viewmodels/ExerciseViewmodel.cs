using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;

namespace Fitorso.Viewmodels
{
    public class ExerciseViewmodel
    {
        public User User { get; set; }
        public List<Exercise> FavoriteExercises { get; set; }
        public List<Musclegroup> Musclegroups { get; set; }
        public List<Exercise> Exercises { get; internal set; }
    }
}
