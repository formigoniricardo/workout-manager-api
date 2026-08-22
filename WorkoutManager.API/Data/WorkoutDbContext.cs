using Microsoft.EntityFrameworkCore;
using WorkoutManager.API.Models;

namespace WorkoutManager.API.Data
{
    public class WorkoutDbContext : DbContext
    {
        public WorkoutDbContext(DbContextOptions<WorkoutDbContext> options) : base(options)
        {
        }

        public DbSet<Workout> Workouts { get; set; }
    }
}