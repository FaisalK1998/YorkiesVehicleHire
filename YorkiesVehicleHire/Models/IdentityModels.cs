// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 05-02-2018
//
// Last Modified By : Faisal
// Last Modified On : 06-10-2018
// ***********************************************************************
// <copyright file="IdentityModels.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace YorkiesVehicleHire.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    /// <summary>
    /// Class ApplicationUser.
    /// </summary>
    /// <seealso cref="Microsoft.AspNet.Identity.EntityFramework.IdentityUser" />
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// generate user identity as an asynchronous operation.
        /// </summary>
        /// <param name="manager">The manager.</param>
        /// <returns>Task&lt;ClaimsIdentity&gt;.</returns>
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        //Adds information required to user class and also to the database table
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the mobile phone no.
        /// </summary>
        /// <value>The mobile phone no.</value>
        [Required]
        [Display(Name = "Mobile Phone Number")]
        public string MobilePhoneNo { get; set; }

        /// <summary>
        /// Gets or sets the driving licence no.
        /// </summary>
        /// <value>The driving licence no.</value>
        [Required]
        [Display(Name = "Driving License Number")]
        public string DrivingLicenceNo { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value>The email.</value>
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }


        //Removes the current user from the Database
        /// <summary>
        /// Removes the user details.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
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

    /// <summary>
    /// Class ApplicationDbContext.
    /// </summary>
    /// <seealso cref="Microsoft.AspNet.Identity.EntityFramework.IdentityDbContext{Models.ApplicationUser}" />
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDbContext"/> class.
        /// </summary>
        public ApplicationDbContext()
            : base("DefaultConnection")
    {
    }

        //Creates the tables in the database for the Booking, Vehicles and Payment Classes
        /// <summary>
        /// Gets or sets the bookings.
        /// </summary>
        /// <value>The bookings.</value>
        public DbSet<Booking> Bookings { get; set; }
        /// <summary>
        /// Gets or sets the vehicles.
        /// </summary>
        /// <value>The vehicles.</value>
        public DbSet<Vehicle> Vehicles { get; set; }
        /// <summary>
        /// Gets or sets the vehicle categories.
        /// </summary>
        /// <value>The vehicle categories.</value>
        public DbSet<VehicleCategory> VehicleCategories { get; set; }
        /// <summary>
        /// Gets or sets the customer payment details.
        /// </summary>
        /// <value>The customer payment details.</value>
        public DbSet<CustomerPaymentDetails> CustomerPaymentDetails { get; set; }
        /// <summary>
        /// Gets or sets the payment view models.
        /// </summary>
        /// <value>The payment view models.</value>
        public DbSet<PaymentViewModel> PaymentViewModels { get; set; }


        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>ApplicationDbContext.</returns>
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        
    }
}