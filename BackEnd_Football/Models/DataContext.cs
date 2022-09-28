
using Microsoft.EntityFrameworkCore;

namespace BackEnd_Football.Models
{
    public class DataContext : DbContext
    {
        public static Random random = new Random();

        public static string randomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

      


        //public static string configSql = "Host=office.stvg.vn:50022;Database=db_stvg_luxjapancare;Username=stvg;Password=stvg";
        public static string configSql = "Host=localhost:5432;Database=db_backendFootball;Username=postgres;Password=postgres";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(configSql);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
        }
    }
}

