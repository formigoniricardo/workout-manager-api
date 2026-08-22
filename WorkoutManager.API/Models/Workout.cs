namespace WorkoutManager.API.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string MuscleGroup { get; set; } = string.Empty;
        public int TotalSets { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}