using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLAyer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NOMRM5V\\SQLEXPRESS;initial catalog=RealHouzingApiDb;integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutHeader> AboutHeaders { get; set; }
        public DbSet<AboutQuestion> AboutQuestions { get; set; }
        public DbSet<AboutQuestionHeader> AboutQuestionHeaders { get; set; }
        public DbSet<AboutService1> AboutService1s { get; set; }
        public DbSet<AboutServiceStatistic> AboutServiceStatistics { get; set; }
        public DbSet<AboutStatistic> AboutStatistics { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactChannel> ContactChannels { get; set; }
        public DbSet<ContactMap> ContactMaps { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<Property2> Properties2 { get; set; }
        public DbSet<Property3> Properties3 { get; set; }
        public DbSet<Property4> Properties4 { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Service1> Service1s { get; set; }
        public DbSet<Service2> Service2s { get; set; }
        public DbSet<ServicePlan> ServicePlans { get; set; }
        public DbSet<ServiceProperty> ServiceProperties { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<HouzingRegister> HouzingRegisters { get; set; }
    }
}
