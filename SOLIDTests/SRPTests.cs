using System.Linq;
using NUnit.Framework;
using SRP;

namespace SOLID.Tests
{
    public class SRPTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Can_add_exercise_to_repository()
        {
            // Arrange
            var repo = new WorkoutRepository();

            // Act
            repo.AddExercise("Hammer Curls");

            // Assert
            Assert.Contains("Hammer Curls", WorkoutDB.ExerciseList);
        }

        [Test]
        public void Can_not_add_duplicate_exercise()
        {
            // Arrange
            var repo = new WorkoutRepository();

            // Act
            repo.AddExercise("Press Ups");
            var count = WorkoutDB.ExerciseList.Count(e => e == "Press Ups");

            // Assert
            Assert.AreEqual(1, count);
        }

        [Test]
        public void Can_not_add_empty_exercise()
        {
            // Arrange
            var repo = new WorkoutRepository();

            // Act
            repo.AddExercise("");

            // Assert
            CollectionAssert.DoesNotContain(WorkoutDB.ExerciseList, "");
        }
    }
}