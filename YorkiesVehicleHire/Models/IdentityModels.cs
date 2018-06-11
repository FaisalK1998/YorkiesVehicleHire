using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace YorkiesVehicleHire.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        //Adds information required to user class and also to the database table
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Mobile Phone Number")]
        public string MobilePhoneNo { get; set; }

        [Required]
        [Display(Name = "Driving License Number")]
        public string DrivingLicenceNo { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }


        //Removes the current user from the Database
        public bool RemoveUserDetails()
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    ApplicationUser userDetails = db.Users.Find(this.Id);
                    db.Entry(userDetails).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
    {
    }

        //Creates the tables in the database for the Booking, Vehicles and Payment Classes
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleCategory> VehicleCategories { get; set; }
        public DbSet<CustomerPaymentDetails> CustomerPaymentDetails { get; set; }
        public DbSet<PaymentViewModel> PaymentViewModels { get; set; }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        
    }
}