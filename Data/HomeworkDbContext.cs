using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HW1API.Entities;

namespace HW1API.Data;
    public class HomeworkDbContext : DbContext
    {
        public HomeworkDbContext (DbContextOptions<HomeworkDbContext> options)
            : base(options)
        {
        }

        public DbSet<Template> Templates { get; set; } = default!;

        public DbSet<Lesson> Lesson { get; set; } = default!;

        public DbSet<Review> Reviews { get; set; } = default!;

        public DbSet<Connection> Connections { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Template>().HasData(
            new Template {TempleteID = 1, Name = "First Template", TrueValue = 11.34f },
            new Template {TempleteID = 2, Name = "Template B", TrueValue = 27.63f },
            new Template {TempleteID = 3, Name = "Mega Template", TrueValue = 19.87f },
            new Template {TempleteID = 4, Name = "Newborn Template", TrueValue = 03.21f },
            new Template {TempleteID = 5, Name = "Template Regret", TrueValue = 88.88f }
        );

        modelBuilder.Entity<Lesson>().HasData(
            new Lesson {LessonId = 1, LessonSubject = "API Construction"},
            new Lesson {LessonId = 2, LessonSubject = "Security Developement"},
            new Lesson {LessonId = 3, LessonSubject = "Decision Tables" },
            new Lesson {LessonId = 4, LessonSubject = "Free Space"},
            new Lesson {LessonId = 5, LessonSubject = "Dont Steal My Nachos"}
        );
        
    }


}
