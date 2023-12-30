using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.DbSeeds
{
    public static class DbSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier{ Id=1, CompanyName = "Mason company", FirstName = "Alex", Surname = "Mason", PhoneNumber = "050-111-11-11"},
                new Supplier{ Id=2, CompanyName = "Hudson warehouse", FirstName = "Jason", Surname = "Hudson", PhoneNumber = "050-222-22-22"},
                new Supplier{ Id=3, CompanyName = "Woods storage", FirstName = "Frank", Surname = "Woods", PhoneNumber = "050-333-33-33"},
                new Supplier{ Id=4, CompanyName = "Bowman delivery", FirstName = "Joseph", Surname = "Bowman", PhoneNumber = "050-444-44-44"}
            );
        }
    }
}