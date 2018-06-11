// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 06-03-2018
//
// Last Modified By : Faisal
// Last Modified On : 06-06-2018
// ***********************************************************************
// <copyright file="BookingController.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;
using YorkiesVehicleHire.Extensions;
using YorkiesVehicleHire.Models;
using static YorkiesVehicleHire.Models.BookingsViewModels;

namespace YorkiesVehicleHire.Controllers
{
    /// <summary>
    /// Class BookingController.
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class BookingController : Controller
    {
        /// <summary>
        /// The database
        /// </summary>
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MakeBooking
        /// <summary>
        /// Returns the MakeBooking page
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult MakeBooking()
        {
            //var vehicleCat = db.VehicleCategories.ToList();
            //var v = new { VehicleCategory = vehicleCat.ToList() };
            //return View(v);
            ViewBag.VehicleCategory = new SelectList(db.VehicleCategories, "VehicleCategoryID", "VehicleCategoryCode");
            return View("~/Views/Booking/MakeBooking.cshtml");
        }

        /// <summary>
        /// Makes the booking if a member is signed in
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>ActionResult.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MakeBooking(MakeBookingViewModel model)
        {
            var userId = User.Identity.GetUserId();
            var customerUser = db.Users.Find(userId);

            DateTime? bookingStart = model.BookingStartDate;
            DateTime? bookingEnd = model.BookingEndDate;
            ViewBag.VehicleCategories = new SelectList(db.VehicleCategories, "VehicleCategoryID", "VehicleCategoryCode");

            if (model != null && ModelState.IsValid)
            {
                ViewBag.Message = "Make Booking";

                var newBooking = new MakeBookingViewModel()
                {
                    BookingStartDate = bookingStart,
                    BookingEndDate = bookingEnd,
                    Vehicles = model.Vehicles,
                    VehicleCategories = model.VehicleCategories,
                    MemberID = model.MemberID,
                };


            }

            return View("~/Views/Booking/MakeBooking.cshtml", model);
        }

        //Returns bookings associated with the user if a student is logged in
        /// <summary>
        /// Lists the bookings.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult ListBookings()
        {
            var userId = User.Identity.GetUserId();

            //retrieves all bookings Assigned to the student currently logged in from the database and orders them from most recently booked
            var bookings = db.Bookings.OrderByDescending(b => b.BookingStartDate).Where(b => b.MemberID == userId).Select(BookingListViewModel.ViewModel);

            //returns view with the populated model
            return View(new ListBookingsViewModel() { Bookings = bookings });
        }

        //Lists the bookings made by the member
        /// <summary>
        /// Lists the bookings.
        /// </summary>
        /// <param name="memberId">The member identifier.</param>
        /// <returns>ActionResult.</returns>
        [HttpPost]
        public ActionResult ListBookings(string memberId)
        {
            //retrieves all bookings from the database that are assinged to the member
            var bookings = db.Bookings.OrderByDescending(b => b.BookingStartDate).Where(b => b.MemberID == memberId).Select(BookingListViewModel.ViewModel);
            
            //returns view with the populated model
            if (bookings.Count() == 0)
            {
                if (db.Users.Find(memberId) == null)
                {
                    this.AddNotification("A member with that id does not exist, ensure you have entered the id correctly", NotificationType.ERROR);
                    return View();
                }
                else
                {
                    this.AddNotification("No bookings found", NotificationType.ERROR);
                    return View();
                }
            }
            return View(new ListBookingsViewModel() { Bookings = bookings });
        }
    }
}