using Microsoft.EntityFrameworkCore;
using FisherInsuranceApi.Models;
namespace FisherInsuranceApi.Data
{
 public class FisherContext : DbContext
 {
     public DbSet<Claim> Claims { get; set; }
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
 string connection = "Data Source = C:/Users/User/3610/FisherInsuranceApi/Fisher_Insurance.sqlite";
 optionsBuilder.UseSqlite(connection);
 }
 }
}