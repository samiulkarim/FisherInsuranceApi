using Microsoft.EntityFrameworkCore;
using FisherInsuranceApi.Models;
namespace FisherInsuranceApi.Data
{
 public class FisherContext : DbContext
 {

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
 string connection = "Data Source = C:/Users/User/3610/FisherInsuranceApi/Fisher_Insurance.sqlite";
 optionsBuilder.UseSqlite(connection);
 }
      public DbSet<Claim> Claims { get; set; }
      public DbSet<Quote> Quotes { get; set; }
 }
}