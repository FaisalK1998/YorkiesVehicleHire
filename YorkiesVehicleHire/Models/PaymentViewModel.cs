// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 05-10-2018
//
// Last Modified By : Faisal
// Last Modified On : 05-10-2018
// ***********************************************************************
// <copyright file="PaymentViewModel.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel.DataAnnotations;

namespace YorkiesVehicleHire.Models
{
    //Holds data required to create a customers payment details object
    /// <summary>
    /// Class PaymentViewModel.
    /// </summary>
    public class PaymentViewModel
    {
        /// <summary>
        /// Gets or sets the card number.
        /// </summary>
        /// <value>The card number.</value>
        [Key]
        [Required]
        [MinLength(16)]
        [MaxLength(16)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Card Number must be numeric")]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the name on card.
        /// </summary>
        /// <value>The name on card.</value>
        [Required]
        [MaxLength(80, ErrorMessage = "Name cannot be longer that 80 characters")]
        [MinLength(6, ErrorMessage = "Name must be longer that 6 characters")]
        [Display(Name = "Name On Card")]
        public string NameOnCard { get; set; }

        /// <summary>
        /// Gets or sets the booking identifier.
        /// </summary>
        /// <value>The booking identifier.</value>
        [Required]
        [MinLength(36, ErrorMessage = "Id cannot be shorter that 36 characters")]
        [MaxLength(36, ErrorMessage = "Id cannot be Longer that 36 characters")]
        public string BookingId { get; set; }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>The cost.</value>
        public string Cost { get; set; }

    }
}