using System;

namespace SRP
{
    public class WorkoutRepository
    {
        public void AddExercise(string exerciseName)
        {
            var isValid = ExerciseValidator.IsValid(exerciseName);

            if (!isValid) return;

            WorkoutDB.ExerciseList.Add(exerciseName);
        }
    }
}
