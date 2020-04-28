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

            Console.WriteLine($"{exerciseName} Added.");
        }

        public void OutputExerciseList()
        {
            Console.WriteLine(string.Join("\n", WorkoutDB.ExerciseList));
        }
    }
}
