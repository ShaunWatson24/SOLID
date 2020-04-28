namespace SRP
{
    public static class ExerciseValidator
    {
        public static bool IsValid(string exerciseName)
        {
            if (string.IsNullOrEmpty(exerciseName))
            {
                return false;
            }

            return !WorkoutDB.ExerciseList.Contains(exerciseName);
        }
    }
}
