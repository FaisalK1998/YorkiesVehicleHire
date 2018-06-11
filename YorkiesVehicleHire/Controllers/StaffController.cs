// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 05-13-2018
//
// Last Modified By : Faisal
// Last Modified On : 05-13-2018
// ***********************************************************************
// <copyright file="StaffController.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using System.Web.Mvc;
using YorkiesVehicleHire.Extensions;
using YorkiesVehicleHire.Models;

namespace YorkiesVehicleHire.Controllers
{
    /// <summary>
    /// Class StaffController.
    /// </summary>
    /// <seealso cref="YorkiesVehicleHire.Controllers.AccountController" />
    public class StaffController : AccountController
    {
        // GET: Staff
        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult Create()
        {
            return View("CreateUser");
        }

        /// <summary>
        /// Creates the user from the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>ActionResult</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        //creates a new user from the model passed in
        public async Task<ActionResult> Create(RegisterViewModel model)
        {
            //used to verify if the user was create and added to the database or not
            var created = false;
            ApplicationDbContext db = new ApplicationDbContext();

            //uses the model to set the details of the appication user object to store in database
            var user = new ApplicationUser
            {
                Email = model.Email,
                Name = model.Name,
                UserName = model.Email,
                DrivingLicenceNo = model.DrivingLicenceNo,
                MobilePhoneNo = model.MobilePhoneNo,
            };

            //check if the role passed in exists in the database
            foreach (var r in db.Roles)
            {
                if (r.Name == model.Role)
                {
                    //creates the user if the role exists in the database
                    var result = await UserManager.CreateAsync(user, model.Password);

                    if (result.Succeeded)
                    {
                        //if the user was successfully created and added to the database, adds the user to the role passed in
                        //and sets created to true to confirm everything ran successfully
                        await UserManager.AddToRoleAsync(user.Id, model.Role);
                        created = true;
                    }
                }
            }

            //creates a notification to display based on if the user was created successfully or not
            if (created)
            {
                this.AddNotification(model.Role + " User Has been created", NotificationType.INFO);
            }
            else
            {
                this.AddNotification("User Creation Failed", NotificationType.ERROR);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}