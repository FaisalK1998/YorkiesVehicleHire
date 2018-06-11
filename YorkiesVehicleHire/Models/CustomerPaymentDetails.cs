// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 05-10-2018
//
// Last Modified By : Faisal
// Last Modified On : 05-10-2018
// ***********************************************************************
// <copyright file="CustomerPaymentDetails.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YorkiesVehicleHire.Models
{
    /// <summary>
    /// Class CustomerPaymentDetails.
    /// </summary>
    public class CustomerPaymentDetails
    {
        /// <summary>
        /// Gets or sets the card number.
        /// </summary>
        /// <value>The card number.</value>
        [Key]
        public string CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the name on card.
        /// </summary>
        /// <value>The name on card.</value>
        public string NameOnCard { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        public string UserId { get; set; }

        //default constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPaymentDetails"/> class.
        /// </summary>
        public CustomerPaymentDetails()
        {
            CardNumber = "0";
            NameOnCard = "First Last";
            UserId = "default";
        }
    }
}