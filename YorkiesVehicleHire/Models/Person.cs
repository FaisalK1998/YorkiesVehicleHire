// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 05-02-2018
//
// Last Modified By : Faisal
// Last Modified On : 04-12-2018
// ***********************************************************************
// <copyright file="Person.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel.DataAnnotations;

namespace YorkiesVehicleHire.Models
{
    /// <summary>
    /// Class Person.
    /// </summary>
    public class Person
    {

        //Display attribute specifies what to display for the name of the field
        //DataType attribute specifies the type of data
        //Required attribute specifies that a field is required

        //Forename variable with DisplayAttribute and RequiredAttribute
        /// <summary>
        /// Gets or sets the forename.
        /// </summary>
        /// <value>The forename.</value>
        [Display(Name = "Forename"), Required]
        public string Forename { get; set; }

        //Surname variable with DisplayAttribute and RequiredAttribute
        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        /// <value>The surname.</value>
        [Display(Name = "Surname"), Required]
        public string Surname { get; set; }

        //Email variable with DisplayAttribute and RequiredAttribute
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        [Display(Name = "Email"), Required]
        public string Email { get; set; }

        //Password variable with DisplayAttribute and RequiredAttribute
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        [Display(Name = "Password"), Required]
        public string Password { get; set; }

        //ConfirmPassword variable with DisplayAttribute and RequiredAttribute
        /// <summary>
        /// Gets or sets the confirm password.
        /// </summary>
        /// <value>The confirm password.</value>
        [Display(Name = "Confirm Password"), Required]
        public string ConfirmPassword { get; set; }

        //PhoneNumber variable with DisplayAttribute and RequiredAttribute
        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>The phone number.</value>
        [Display(Name = "Phone Number"), Required]
        public int PhoneNumber { get; set; }

        //HomePhoneNumber variable with DisplayAttribute
        /// <summary>
        /// Gets or sets the home phone number.
        /// </summary>
        /// <value>The home phone number.</value>
        [Display(Name = "Home Phone Number")]
        public int HomePhoneNumber { get; set; }

        //HouseNumber variable with DisplayAttribute
        /// <summary>
        /// Gets or sets the house number.
        /// </summary>
        /// <value>The house number.</value>
        [Display(Name = "House Number")]
        public int HouseNumber { get; set; }

        //Street variable with DisplayAttribute
        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        /// <value>The street.</value>
        [Display(Name = "Street")]
        public string Street { get; set; }

        //Town variable with DisplayAttribute
        /// <summary>
        /// Gets or sets the town.
        /// </summary>
        /// <value>The town.</value>
        [Display(Name = "Town")]
        public string Town { get; set; }

        //Postcode variable with DisplayAttribute
        /// <summary>
        /// Gets or sets the postcode.
        /// </summary>
        /// <value>The postcode.</value>
        [Display(Name = "Postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person() { }

    }

}