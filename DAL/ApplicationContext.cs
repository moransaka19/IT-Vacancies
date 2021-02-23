using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(new[] {
                new Company()
                {
                    Id = 1,
                    Location = "Test Location",
                    Name = "Test Name",
                }
            });

            modelBuilder.Entity<Recruiter>().HasData(new[] {
                new Recruiter()
                {
                    Id = 1,
                    Name = "Recrutier Name 1",
                    PhoneNumber = "+380990000000",
                    CompanyId = 1
                }
            }); 

            modelBuilder.Entity<Vacancy>().HasData(new[] { 
                new Vacancy()
                {
                    Id = 1,
                    Name = "Vacancy Name",
                    Price = 100000,
                    Description = "Test Description 1",
                    CompanyId = 1
                }
            });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Recruiter> Recruiters { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
    }
}
