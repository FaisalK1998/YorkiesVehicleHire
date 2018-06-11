// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 05-02-2018
//
// Last Modified By : Faisal
// Last Modified On : 06-05-2018
// ***********************************************************************
// <copyright file="BookingsViewModels.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using static YorkiesVehicleHire.Models.VehicleViewModels;

namespace YorkiesVehicleHire.Models
{
    /// <summary>
    /// Class BookingsViewModels.
    /// </summary>
    public class BookingsViewModels
    {
        //Display attribute specifies what to display for the name of the field
        //DataType attribute specifies the type of data
        //Required attribute specifies that a field is required

        //Holds data required for making a booking
        /// <summary>
        /// Class MakeBookingViewModel.
        /// </summary>
        public class MakeBookingViewModel
        {
            /// <summary>
            /// Gets or sets the selected vehicle.
            /// </summary>
            /// <value>The selected vehicle.</value>
            [Required]
            [Display(Name = "Vehicle")]
            //public string SelectedVehicle { get; set; }

            /// <summary>
            /// Gets or sets the vehicles.
            /// </summary>
            /// <value>The vehicles.</value>
            public IEnumerable<VehicleViewModel> Vehicles { get; set; }

            /// <summary>
            /// Gets or sets the selected vehicle category.
            /// </summary>
            /// <value>The selected vehicle category.</value>
            [Required]
            [Display(Name = "Vehicle Category")]
            //public string SelectedVehicleCategory { get; set; }

            /// <summary>
            /// Gets or sets the vehicle categories.
            /// </summary>
            /// <value>The vehicle categories.</value>
            public IEnumerable<VehicleCategory> VehicleCategories { get; set; }

            /// <summary>
            /// Gets or sets the member identifier.
            /// </summary>
            /// <value>The member identifier.</value>
            [Required]
            public string MemberID { get; set; }

            /// <summary>
            /// Gets or sets the booking start date.
            /// </summary>
            /// <value>The booking start date.</value>
            [Required]
            [Display(Name = "Booking Start Date")]
            public DateTime? BookingStartDate { get; set; }

            /// <summary>
            /// Gets or sets the booking end date.
            /// </summary>
            /// <value>The booking end date.</value>
            [Required]
            [Display(Name = "Booking End Date")]
            public DateTime? BookingEndDate { get; set; }

        }

        //holds data required for displaying bookings to users
        /// <summary>
        /// Class BookingListViewModel.
        /// </summary>
        public class BookingListViewModel
        {
            /// <summary>
            /// Gets or sets the booking identifier.
            /// </summary>
            /// <value>The booking identifier.</value>
            public string BookingID{ get; set; }

            /// <summary>
            /// Gets or sets the hire cost.
            /// </summary>
            /// <value>The hire cost.</value>
            public double HireCost { get; set; }

            /// <summary>
            /// Gets or sets the vehicles.
            /// </summary>
            /// <value>The vehicles.</value>
            public IEnumerable<VehicleViewModel> Vehicles { get; set; }

            /// <summary>
            /// Gets or sets the booking start date.
            /// </summary>
            /// <value>The booking start date.</value>
            [Required]
            [DataType(DataType.DateTime)]
            public DateTime BookingStartDate { get; set; }

            /// <summary>
            /// Gets or sets the booking end date.
            /// </summary>
            /// <value>The booking end date.</value>
            [Required]
            [DataType(DataType.DateTime)]
            public DateTime BookingEndDate { get; set; }

            /// <summary>
            /// Gets or sets the status.
            /// </summary>
            /// <value>The status.</value>
            public string Status { get; set; }

            /// <summary>
            /// Gets or sets the member identifier.
            /// </summary>
            /// <value>The member identifier.</value>
            [Required]
            public string MemberID { get; set; }

            /// <summary>
            /// Gets or sets the name of the member.
            /// </summary>
            /// <value>The name of the member.</value>
            [DataType(DataType.Text)]
            public string MemberName { get; set; }

            //Converts a booking into a booking list view model
            /// <summary>
            /// Gets the view model.
            /// </summary>
            /// <value>The view model.</value>
            public static Expression<Func<Booking, BookingListViewModel>> ViewModel
            {
                get
                {
                    return b => new BookingListViewModel()
                    {
                        BookingID = b.BookingID,
                        HireCost = b.HireCost,
                        Vehicles = b.Vehicles.AsQueryable().Select(VehicleViewModel.ViewModel),
                        BookingStartDate = b.BookingStartDate,
                        BookingEndDate = b.BookingEndDate,
                        Status = b.Status,
                        MemberID = b.MemberID,
                    };
                }
            }


        }
        
        /*
        //Foreign Key
        public int VehicleID { get; set; }
        public int VehicleCategoryID { get; set; }

        //Relationship
        public virtual Vehicle Vehicle { get; set; }

        //Checks if start date of booking is not the current date
        public bool CheckDate()
        {
            if (this.BookingStartDate > DateTime.Now.Date)
            {
                return true;
            }
            return false;
        }
        */
    }
}