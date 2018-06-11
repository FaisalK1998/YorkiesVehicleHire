// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 05-02-2018
//
// Last Modified By : Faisal
// Last Modified On : 04-12-2018
// ***********************************************************************
// <copyright file="Member.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel.DataAnnotations;

namespace YorkiesVehicleHire.Models
{
    /// <summary>
    /// Class Member.
    /// </summary>
    /// <seealso cref="YorkiesVehicleHire.Models.Person" />
    public class Member : Person    //Subclass of Person
    {
        //Display attribute specifies what to display for the name of the field
        //Required attribute specifies that a field is required

        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>
        /// <value>The member identifier.</value>
        public int MemberID { get; set; }

        //DrivingLicenseNo variable with DisplayAttribute and RequiredAttribute
        /// <summary>
        /// Gets or sets the driving license no.
        /// </summary>
        /// <value>The driving license no.</value>
        [Display(Name = "Driving License Number"), Required]
        public string DrivingLicenseNo { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class.
        /// </summary>
        public Member() { }
    }
}