using PlaneTreeNetwork.Hotel.DataAccess.Concrete.EntityFramework.Mappings;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.EntityFramework
{
    public class HotelContext : DbContext
    {
        public HotelContext()
        {
            Database.SetInitializer<HotelContext>(null);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Otel> Otels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        //


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new UserMap());
            //
        }
    }
}
