// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 05-02-2018
//
// Last Modified By : Faisal
// Last Modified On : 04-13-2018
// ***********************************************************************
// <copyright file="Invoice.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel.DataAnnotations;

namespace YorkiesVehicleHire.Models
{
    /// <summary>
    /// Class Invoice.
    /// </summary>
    public class Invoice
    {
        //Display attribute specifies what to display for the name of the field
        //DataType attribute specifies the type of data
        //Required attribute specifies that a field is required

        /// <summary>
        /// Gets or sets the invoice no.
        /// </summary>
        /// <value>The invoice no.</value>
        public int InvoiceNo { get; set; }

        //DateOfInvoice variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the date of invoice.
        /// </summary>
        /// <value>The date of invoice.</value>
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Invoice")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DateOfInvoice { get; set; }

        //InvoiceCost variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the invoice cost.
        /// </summary>
        /// <value>The invoice cost.</value>
        [DataType(DataType.Currency)]
        [Display(Name = "Invoice Cost")]
        [Required]
        public decimal InvoiceCost { get; set; }

        //CustomerNo variable with DisplayAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the customer no.
        /// </summary>
        /// <value>The customer no.</value>
        [Display(Name = "Customer Number")]
        [Required]
        public int CustomerNo { get; set; }

        //CustomerName variable with DisplayAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        /// <value>The name of the customer.</value>
        [Display(Name = "Customer Name"), Required]
        public string CustomerName { get; set; }

        //CustomerAddress variable with DisplayAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the customer address.
        /// </summary>
        /// <value>The customer address.</value>
        [Display(Name = "Customer Address"), Required]
        public string CustomerAddress { get; set; }

        //CustomerPhoneNumber variable with DisplayAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the customer phone number.
        /// </summary>
        /// <value>The customer phone number.</value>
        [Display(Name = "Customer Phone Number"), Required]
        public int CustomerPhoneNumber { get; set; }

        //VehicleCategory variable with DisplayAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the vehicle category.
        /// </summary>
        /// <value>The vehicle category.</value>
        [Display(Name = "Vehicle Category"), Required]
        public string VehicleCategory { get; set; }

        //CategoryCost variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the category cost.
        /// </summary>
        /// <value>The category cost.</value>
        [DataType(DataType.Currency)]
        [Display(Name = "Category Cost")]
        [Required]
        public decimal CategoryCost { get; set; }

        //BookingStartDate variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the booking start date.
        /// </summary>
        /// <value>The booking start date.</value>
        [DataType(DataType.Date)]
        [Display(Name = "Booking Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime BookingStartDate { get; set; }

        //BookingEndDate variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the booking end date.
        /// </summary>
        /// <value>The booking end date.</value>
        [DataType(DataType.Date)]
        [Display(Name = "Booking End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime BookingEndDate { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice"/> class.
        /// </summary>
        public Invoice() { }
    }
}