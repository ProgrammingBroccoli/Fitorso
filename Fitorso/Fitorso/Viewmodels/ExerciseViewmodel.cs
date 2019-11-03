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
        public List<Exercise> FavoritExercises { get; set; }
    }
}
