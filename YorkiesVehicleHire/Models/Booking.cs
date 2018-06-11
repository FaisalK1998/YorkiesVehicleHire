// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 05-05-2018
//
// Last Modified By : Faisal
// Last Modified On : 05-16-2018
// ***********************************************************************
// <copyright file="Booking.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YorkiesVehicleHire.Models
{
    /// <summary>
    /// Class Booking.
    /// </summary>
    public class Booking
    {
        /// <summary>
        /// Gets or sets the booking identifier.
        /// </summary>
        /// <value>The booking identifier.</value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string BookingID { get; set; }

        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>
        /// <value>The member identifier.</value>
        public string MemberID { get; set; }

        //BookingCost variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the hire cost.
        /// </summary>
        /// <value>The hire cost.</value>
        [Display(Name = "Booking Cost")]
        [DataType(DataType.Currency)]
        [Required]
        public double HireCost { get; set; }

        //BookingStartDate variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the booking start date.
        /// </summary>
        /// <value>The booking start date.</value>
        [Display(Name = "Booking Start Date")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BookingStartDate { get; set; }

        //BookingEndDate variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the booking end date.
        /// </summary>
        /// <value>The booking end date.</value>
        [Display(Name = "Booking End Date")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BookingEndDate { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the vehicles.
        /// </summary>
        /// <value>The vehicles.</value>
        public List<Vehicle> Vehicles { get; set; }

        /// <summary>
        /// Gets or sets the vehicle category.
        /// </summary>
        /// <value>The vehicle category.</value>
        public List<VehicleCategory> VehicleCategory { get; set; }

        //Default constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Booking"/> class.
        /// </summary>
        public Booking()
        {
            MemberID = "";
            HireCost = 0;
            BookingStartDate = BookingStartDate.Date;
            BookingEndDate = BookingEndDate.Date;
            Status = "";
            Vehicles = new List<Vehicle>();
            VehicleCategory = new List<VehicleCategory>();
        }

        //Adds a vehicle to the booking 
        /// <summary>
        /// Adds the vehicle.
        /// </summary>
        /// <param name="v">The v.</param>
        public void AddVehicle(Vehicle v)
        {
            Vehicles.Add(v);
        }

        /////////////////////////////
        /*
        //BookingStartMileage variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Booking Start Mileage"), Required]
        public int BookingStartMileage { get; set; }

        //BookingEndMileage variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Booking End Mileage"), Required]
        public int BookingEndMileage { get; set; }
        

        //Vehicles variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Vehicle")]
        [Required]
        public SelectList Vehicles;

        //VehicleCategory variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Vehicle Category")]
        [Required]
        public SelectList VehicleCategory;


        //VehicleCategoryCode variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Vehicle Category Code"), Required]
        public string VehicleCategoryCode { get; set; }

        //VehicleCategoryDescription variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Vehicle Category Description"), Required]
        public string VehicleCategoryDescription { get; set; }

        //Foreign Key
        public int VehicleID { get; set; }
        public int VehicleCategoryID { get; set; }

        //Relationship
        public virtual Vehicle Vehicle { get; set; }
        */
    }
}
 