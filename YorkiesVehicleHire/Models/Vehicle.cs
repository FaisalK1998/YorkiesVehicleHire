using System;
using System.ComponentModel.DataAnnotations;

namespace YorkiesVehicleHire.Models
{
    public class Vehicle
    {
        //Display attribute specifies what to display for the name of the field
        //DataType attribute specifies the type of data
        //Required attribute specifies that a field is required

        //VehicleRegistrationNo variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Vehicle Registration Number"), Required]
        public string VehicleRegistrationNo { get; set; }

        //Make variable with RequiredAttribute
        [Required]
        public string Make { get; set; }

        //Model variable with RequiredAttribute
        [Required]
        public string Model { get; set; }

        //Colour variable with RequiredAttribute
        [Required]
        public string Colour { get; set; }

        //DateOfRegistration variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Registration")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DateOfRegistration { get; set; }

        //DateOfPurchase variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Purchase")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DateOfPurchase { get; set; }

        //MOTDate variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        [DataType(DataType.Date)]
        [Display(Name = "MOT Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime MOTDate { get; set; }

        //HirePrice variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        [DataType(DataType.Currency)]
        [Display(Name = "Hire Price")]
        [Required]
        public decimal HirePrice { get; set; }

        public Vehicle() { }
    }
}