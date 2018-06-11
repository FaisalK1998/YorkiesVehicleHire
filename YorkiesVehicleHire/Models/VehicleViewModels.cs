// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 05-02-2018
//
// Last Modified By : Faisal
// Last Modified On : 06-09-2018
// ***********************************************************************
// <copyright file="VehicleViewModels.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace YorkiesVehicleHire.Models
{
    /// <summary>
    /// Class VehicleViewModels.
    /// </summary>
    public class VehicleViewModels
    {
        //Display attribute specifies what to display for the name of the field
        //DataType attribute specifies the type of data
        //Required attribute specifies that a field is required

        /// <summary>
        /// Class VehicleViewModel.
        /// </summary>
        public class VehicleViewModel
        {
            /// <summary>
            /// Gets or sets the vehicle identifier.
            /// </summary>
            /// <value>The vehicle identifier.</value>
            public int VehicleID { get; set; }

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
            /// <summary>
            /// Gets or sets the booking start date.
            /// </summary>
            /// <value>The booking start date.</value>
            [Display(Name = "Booking Start Date")]
            [Required]
            [DataType(DataType.DateTime)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime BookingStartDate { get; set; }

            //BookingEndDate variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
            /// <summary>
            /// Gets or sets the booking end date.
            /// </summary>
            /// <value>The booking end date.</value>
            [Display(Name = "Booking End Date")]
            [Required]
            [DataType(DataType.DateTime)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime BookingEndDate { get; set; }


            //Converts a vehicle object into a vehicle view model
            /// <summary>
            /// Gets the view model.
            /// </summary>
            /// <value>The view model.</value>
            public static Expression<Func<Vehicle, VehicleViewModel>> ViewModel
            {
                get
                {
                    return v => new VehicleViewModel()
                    {
                        VehicleRegistrationNo = v.VehicleRegistrationNo,
                        Make = v.Make,
                        Model = v.Model,
                        Colour = v.Colour,
                        DateOfRegistration = v.DateOfRegistration,
                        DateOfPurchase = v.DateOfPurchase,
                        MOTDate = v.MOTDate,
                        HirePrice = v.HirePrice,
                        VehicleCategoryCode = v.VehicleCategoryCode,
                        VehicleCategoryDescription = v.VehicleCategoryDescription,
                        //BookingStartDate = v.BookingStartDate,
                        //BookingEndDate = v.BookingEndDate
                    };
                }
            }
        }

        /*
        //Foreign Keys
        public int VehicleCategoryID { get; set; }

        //Relationships
        public virtual VehicleCategory Category { get; set; }
        */

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleViewModels"/> class.
        /// </summary>
        public VehicleViewModels() { }
    }
}