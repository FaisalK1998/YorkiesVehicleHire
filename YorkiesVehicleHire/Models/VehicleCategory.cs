// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 05-02-2018
//
// Last Modified By : Faisal
// Last Modified On : 05-17-2018
// ***********************************************************************
// <copyright file="VehicleCategory.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YorkiesVehicleHire.Models
{
    /// <summary>
    /// Class VehicleCategory.
    /// </summary>
    public class VehicleCategory
    {
        //Display attribute specifies what to display for the name of the field
        //Required attribute specifies that a field is required

        /// <summary>
        /// Gets or sets the vehicle category identifier.
        /// </summary>
        /// <value>The vehicle category identifier.</value>
        public int VehicleCategoryID { get; set; }

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

        /// <summary>
        /// Gets or sets the vehicle.
        /// </summary>
        /// <value>The vehicle.</value>
        public virtual IEnumerable<VehicleViewModels> Vehicle { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleCategory"/> class.
        /// </summary>
        public VehicleCategory() { }
    }
}