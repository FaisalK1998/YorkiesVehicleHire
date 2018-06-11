// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 05-02-2018
//
// Last Modified By : Faisal
// Last Modified On : 04-13-2018
// ***********************************************************************
// <copyright file="BookingClerk.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel.DataAnnotations;

namespace YorkiesVehicleHire.Models
{
    /// <summary>
    /// Class BookingClerk.
    /// </summary>
    /// <seealso cref="YorkiesVehicleHire.Models.Person" />
    public class BookingClerk : Person  //Subclass of Person
    {
        //Display attribute specifies what to display for the name of the field
        //Required attribute specifies that a field is required

        /// <summary>
        /// Gets or sets the booking clerk identifier.
        /// </summary>
        /// <value>The booking clerk identifier.</value>
        public int BookingClerkID { get; set; }

        //UserID variable with DisplayAttribute and RequiredAttribute
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        [Display(Name = "User ID"), Required]
        public int UserID { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BookingClerk"/> class.
        /// </summary>
        public BookingClerk() { }
    }
}