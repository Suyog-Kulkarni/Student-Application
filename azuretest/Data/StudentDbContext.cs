using azuretest.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace azuretest.Data;
public class StudentDbContext : IdentityDbContext<IdentityUser>
{
    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
    {

    }

    public DbSet<Student> Students { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Student>().HasData(
                       new Student
                       {
                           ID = 1,
                           Name = "John Doe",
                           Email = "abc@gmail.com",
                           Phone = "1234567890",
                           Address = "123 Main St",
                           City = "New York",


                       },
                       new Student
                       {
                           ID = 2,
                           Name = "Sammy",
                           Email = "abc@gmail.com",
                           Phone = "1234567890",
                           Address = "123 Main St",
                           City = "New York",

                       },
                       new Student
                       {
                           ID = 3,
                           Name = "Sammy Doe",
                           Email = "abc@gmail.com",
                           Phone = "1234567890",
                           Address = "123 Main St",
                           City = "New York",
                       }
        );
    }
}

