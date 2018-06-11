using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System;
using YorkiesVehicleHire.Models;

[assembly: OwinStartupAttribute(typeof(YorkiesVehicleHire.Startup))]
namespace YorkiesVehicleHire
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //Seed();
        }

        private void Seed()
        {
            ApplicationDbContext _context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_context));


            //Creates the default Admin role and adds a default Admin user to the role    
            if (!roleManager.RoleExists("Admin"))
            {

                //Ceate Admin role
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //Creating an Admin super user who will maintain the website                  
                var user = new ApplicationUser();
                user.UserName = "admin@admin.com";
                user.Email = "admin@admin.com";
                user.Name = "Default Admin";
                user.DrivingLicenceNo = "12345678910";
                user.PhoneNumber = "123";
                user.MobilePhoneNo = "123";

                string userPWD = "Admin12£";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default Admin to Role    
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }

            //Creating Manager role
            if (!roleManager.RoleExists("Manager"))
            {

                // creates the role for Manager   
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Manager";
                roleManager.Create(role);

                // creates the default Manager                  
                var user = new ApplicationUser();
                user.UserName = "Manager@manager.com";
                user.Email = "Manager@manager.com";
                user.Name = "Default Manager";
                user.DrivingLicenceNo = "12345678910";
                user.PhoneNumber = "11";
                user.MobilePhoneNo = "22";

                string userPWD = "Manager12£";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default Manager to Role   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Manager");
                }
            }

            //Creating the Bookings Clerk role   
            if (!roleManager.RoleExists("BookingsClerk"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "BookingsClerk";
                roleManager.Create(role);

                //Here we create a BookingsClerk                   
                var user = new ApplicationUser();
                user.UserName = "BookingClerk@BC.com";
                user.Email = "BookingClerk@BC.com";
                user.Name = "Default BC";
                user.DrivingLicenceNo = "12345678910";
                user.PhoneNumber = "12";
                user.MobilePhoneNo = "22";

                string userPWD = "BookingsC12£";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default Booking Clerk to Role Booking Clerk   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "BookingsClerk");

                }
            }

            // creating the Invoices Clerk role
            if (!roleManager.RoleExists("InvoicesClerk"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "InvoicesClerk";
                roleManager.Create(role);

                // creating a default Invoice Clerk         

                var user = new ApplicationUser();
                user.UserName = "InvoicesClerk@IC.com";
                user.Email = "InvoicesClerk@IC.com";
                user.Name = "Default InvoicesClerk";
                user.DrivingLicenceNo = "12345678910";
                user.PhoneNumber = "13";
                user.MobilePhoneNo = "23";

                string userPWD = "InvoiceC12£";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default Invoice Clerk to Role   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "InvoicesClerk");

                }
            }

            // creating the Member role
            if (!roleManager.RoleExists("Member"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Member";
                roleManager.Create(role);

                // creating a default Member                

                var user = new ApplicationUser();
                user.UserName = "Member@member.com";
                user.Email = "Member@member.com";
                user.Name = "Default Member";
                user.DrivingLicenceNo = "12345678910";
                user.PhoneNumber = "14";
                user.MobilePhoneNo = "24";

                string userPWD = "Member12£";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default Member to Role    
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Member");

                }
            }
        }
    }
}
