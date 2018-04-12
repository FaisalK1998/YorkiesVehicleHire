using System;
using System.ComponentModel.DataAnnotations;

namespace YorkiesVehicleHire.Models
{
    public class Booking
    {
        //Display attribute specifies what to display for the name of the field
        //DataType attribute specifies the type of data
        //Required attribute specifies that a field is required

        public int BookingID { get; set; }

        //BookingCost variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        [Display(Name = "Booking Cost")]
        [DataType(DataType.Currency)]
        [Required]
        public decimal BookingCost { get; set; }

        //BookingStartDate variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        [Display(Name = "Booking Start Date")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BookingStartDate { get; set; }

        //BookingEndDate variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        [Display(Name = "Booking End Date")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BookingEndDate { get; set; }

        //BookingStartMileage variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Booking Start Mileage"), Required]
        public int BookingStartMileage { get; set; }

        //BookingEndMileage variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Booking End Mileage"), Required]
        public int BookingEndMileage { get; set; }

        public Booking() { }
    }
}