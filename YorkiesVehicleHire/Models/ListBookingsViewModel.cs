// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 05-04-2018
//
// Last Modified By : Faisal
// Last Modified On : 05-11-2018
// ***********************************************************************
// <copyright file="ListBookingsViewModel.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static YorkiesVehicleHire.Models.BookingsViewModels;

namespace YorkiesVehicleHire.Models
{
    /// <summary>
    /// Class ListBookingsViewModel.
    /// </summary>
    public class ListBookingsViewModel
    {
        //Holds the list of bookings to display to the user
        /// <summary>
        /// Gets or sets the bookings.
        /// </summary>
        /// <value>The bookings.</value>
        public IEnumerable<BookingListViewModel> Bookings { get; set; }
    }
}