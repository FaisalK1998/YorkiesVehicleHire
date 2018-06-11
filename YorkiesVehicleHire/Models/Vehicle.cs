// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 05-05-2018
//
// Last Modified By : Faisal
// Last Modified On : 05-23-2018
// ***********************************************************************
// <copyright file="Vehicle.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static YorkiesVehicleHire.Models.VehicleViewModels;

namespace YorkiesVehicleHire.Models
{
    /// <summary>
    /// Class Vehicle.
    /// </summary>
    public class Vehicle
    {
        //Display attribute specifies what to display for the name of the field
        //DataType attribute specifies the type of data
        //Required attribute specifies that a field is required

        /// <summary>
        /// Gets or sets the vehicle identifier.
        /// </summary>
        /// <value>The vehicle identifier.</value>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehicleID { get; set; }

        //public string BookingID { get; set; }

        //VehicleRegistrationNo variable with DisplayAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the vehicle registration no.
        /// </summary>
        /// <value>The vehicle registration no.</value>
        [Display(Name = "Vehicle Registration Number"), Required]
        public string VehicleRegistrationNo { get; set; }

        //Make variable with RequiredAttribute
        /// <summary>
        /// Gets or sets the make.
        /// </summary>
        /// <value>The make.</value>
        [Required]
        public string Make { get; set; }

        //Model variable with RequiredAttribute
        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>The model.</value>
        [Required]
        public string Model { get; set; }

        //Colour variable with RequiredAttribute
        /// <summary>
        /// Gets or sets the colour.
        /// </summary>
        /// <value>The colour.</value>
        [Required]
        public string Colour { get; set; }

        //DateOfRegistration variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the date of registration.
        /// </summary>
        /// <value>The date of registration.</value>
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Registration")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DateOfRegistration { get; set; }

        //DateOfPurchase variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the date of purchase.
        /// </summary>
        /// <value>The date of purchase.</value>
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Purchase")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DateOfPurchase { get; set; }

        //MOTDate variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the mot date.
        /// </summary>
        /// <value>The mot date.</value>
        [DataType(DataType.Date)]
        [Display(Name = "MOT Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime MOTDate { get; set; }

        //HirePrice variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the hire price.
        /// </summary>
        /// <value>The hire price.</value>
        [DataType(DataType.Currency)]
        [Display(Name = "Hire Price")]
        [Required]
        public double HirePrice { get; set; }

        //VehicleCategoryCode variable with DisplayAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the vehicle category code.
        /// </summary>
        /// <value>The vehicle category code.</value>
        [Display(Name = "Vehicle Category Code"), Required]
        public string VehicleCategoryCode { get; set; }

        //VehicleCategoryDescription variable with DisplayAttribute, RequiredAttribute
        /// <summary>
        /// Gets or sets the vehicle category description.
        /// </summary>
        /// <value>The vehicle category description.</value>
        [Display(Name = "Vehicle Category Description"), Required]
        public string VehicleCategoryDescription { get; set; }

        //BookingStartDate variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        //[Display(Name = "Booking Start Date")]
        //[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime BookingStartDate { get; set; }

        //BookingEndDate variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        //[Display(Name = "Booking End Date")]
        //[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime BookingEndDate { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class.
        /// </summary>
        public Vehicle()
        {
            VehicleRegistrationNo = "";
            Make = "";
            Model = "";
            Colour = "";
            DateOfRegistration = DateTime.Parse("1900-01-01T00:00:00.000");
            DateOfPurchase = DateTime.Parse("1900-01-01T00:00:00.000");
            MOTDate = DateTime.Parse("1900-01-01T00:00:00.000");
            HirePrice = 0;
            VehicleCategoryCode = "";
            VehicleCategoryDescription = "";
            //BookingStartDate = DateTime.Parse("1900-01-01T00:00:00.000");
            //BookingEndDate = DateTime.Parse("1900-01-01T00:00:00.000");

        }

        //Calculates the cost of a vehicle from the vehicle category selected
        /// <summary>
        /// Calculates the cost.
        /// </summary>
        /// <param name="vehicleVM">The vehicle vm.</param>
        /// <returns>Vehicle.</returns>
        public Vehicle CalculateCost(VehicleViewModel vehicleVM)
        {
            Vehicle vehicle = new Vehicle();

            if (vehicle.VehicleCategoryCode == "A")
            {
                vehicle.HirePrice = 30.00;
            }
            else if (vehicle.VehicleCategoryCode == "B")
            {
                vehicle.HirePrice = 50.00;
            }
            else if (vehicle.VehicleCategoryCode == "C")
            {
                vehicle.HirePrice = 70.00;
            }

            return vehicle;
        }
    }
}