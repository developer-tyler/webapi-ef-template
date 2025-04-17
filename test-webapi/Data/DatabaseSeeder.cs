using Microsoft.EntityFrameworkCore;
using test_webapi.Data.Entities;

namespace test_webapi.Data
{
    public static class DatabaseSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            // Seed Summaries
            modelBuilder.Entity<Summary>().HasData(
                new Summary { Id = 1, Description = "Freezing" },
                new Summary { Id = 2, Description = "Bracing" },
                new Summary { Id = 3, Description = "Chilly" },
                new Summary { Id = 4, Description = "Cool" },
                new Summary { Id = 5, Description = "Mild" },
                new Summary { Id = 6, Description = "Warm" },
                new Summary { Id = 7, Description = "Balmy" },
                new Summary { Id = 8, Description = "Hot" },
                new Summary { Id = 9, Description = "Sweltering" },
                new Summary { Id = 10, Description = "Scorching" }
            );

            // Seed Plant Categories
            modelBuilder.Entity<PlantCategoryEntity>().HasData(
                new PlantCategoryEntity { CategoryID = 1, CategoryDescription = "Heavy Plant" },
                new PlantCategoryEntity { CategoryID = 2, CategoryDescription = "Small Plant" },
                new PlantCategoryEntity { CategoryID = 3, CategoryDescription = "Access Equipment" },
                new PlantCategoryEntity { CategoryID = 4, CategoryDescription = "Power Tools" },
                new PlantCategoryEntity { CategoryID = 5, CategoryDescription = "Safety Equipment" }
            );

            // Seed Status
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusID = 1, StatusDescription = "Available" },
                new Status { StatusID = 2, StatusDescription = "In Use" },
                new Status { StatusID = 3, StatusDescription = "Under Maintenance" },
                new Status { StatusID = 4, StatusDescription = "Out of Service" },
                new Status { StatusID = 5, StatusDescription = "Reserved" }
            );

            // Seed Inspectors
            modelBuilder.Entity<InspectorEntity>().HasData(
                new InspectorEntity { InspectorID = 1, InspectorsName = "Allen Lee" },
                new InspectorEntity { InspectorID = 2, InspectorsName = "Aidan Lee" }
            );

            // Seed Customers (keeping existing logic)
            var customers = new List<CustomerEntity>();
            var notes = new List<NoteEntity>();

            for (int i = 1; i <= 100; i++)
            {
                char letter = (char)((i % 26) + 65);
                customers.Add(new CustomerEntity
                {
                    CustID = i,
                    CompanyName = $"Company {letter}",
                    ContactTitle = "Mr.",
                    ContactFirstNames = "John",
                    ContactSurname = "Doe",
                    Line1 = "123 Main St",
                    Line2 = "",
                    Line3 = "",
                    Line4 = "",
                    Postcode = "12345",
                    Telephone = "123-456-7890",
                    Fax = "123-456-7891",
                    Email = "john.doe@companya.com"
                });

                notes.Add(new NoteEntity
                {
                    NoteID = i,
                    CustID = i,
                    Date = new DateTime(2023, 1, 1),
                    Notes = $"Dummy note 1 for customer {i}"
                });
                notes.Add(new NoteEntity
                {
                    NoteID = i + 100,
                    CustID = i,
                    Date = new DateTime(2023, 1, 2),
                    Notes = $"Dummy note 2 for customer {i}"
                });
            }

            // Add sample plants
            modelBuilder.Entity<AllPlantEntity>().HasData(
                new AllPlantEntity { PlantNameID = 1, PlantDescription = "Excavator 2T", PlantCategory = 1, NormalPrice = "150.00" },
                new AllPlantEntity { PlantNameID = 2, PlantDescription = "Scissor Lift", PlantCategory = 3, NormalPrice = "95.00" },
                new AllPlantEntity { PlantNameID = 3, PlantDescription = "Concrete Mixer", PlantCategory = 2, NormalPrice = "45.00" },
                new AllPlantEntity { PlantNameID = 4, PlantDescription = "Power Drill", PlantCategory = 4, NormalPrice = "25.00" },
                new AllPlantEntity { PlantNameID = 5, PlantDescription = "Safety Harness", PlantCategory = 5, NormalPrice = "15.00" }
            );

            // Add sample plant holdings
            modelBuilder.Entity<PlantHolding>().HasData(
                new PlantHolding { HoldingID = 1, CustID = 1, PlantNameID = 1, SerialNumber = "EXC001", StatusID = 2, SWL = "2000kg" },
                new PlantHolding { HoldingID = 2, CustID = 2, PlantNameID = 2, SerialNumber = "LIFT001", StatusID = 1, SWL = "300kg" },
                new PlantHolding { HoldingID = 3, CustID = 3, PlantNameID = 3, SerialNumber = "MIX001", StatusID = 3, SWL = "100kg" },
                new PlantHolding { HoldingID = 4, CustID = 4, PlantNameID = 4, SerialNumber = "DRILL001", StatusID = 1, SWL = "N/A" },
                new PlantHolding { HoldingID = 5, CustID = 5, PlantNameID = 5, SerialNumber = "SAFE001", StatusID = 2, SWL = "150kg" }
            );

            modelBuilder.Entity<CustomerEntity>().HasData(customers);
            modelBuilder.Entity<NoteEntity>().HasData(notes);
        }
    }
}
