using System;
using System.ComponentModel.DataAnnotations;

namespace YorkiesVehicleHire.Models
{
    public class Invoice
    {
        //Display attribute specifies what to display for the name of the field
        //DataType attribute specifies the type of data
        //Required attribute specifies that a field is required

        public int InvoiceNo { get; set; }

        //DateOfInvoice variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Invoice")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DateOfInvoice { get; set; }

        //InvoiceCost variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        [DataType(DataType.Currency)]
        [Display(Name = "Invoice Cost")]
        [Required]
        public decimal InvoiceCost { get; set; }

        //CustomerNo variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Customer Number")]
        [Required]
        public int CustomerNo { get; set; }

        //CustomerName variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Customer Name"), Required]
        public string CustomerName { get; set; }

        //CustomerAddress variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Customer Address"), Required]
        public string CustomerAddress { get; set; }

        //CustomerPhoneNumber variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Customer Phone Number"), Required]
        public int CustomerPhoneNumber { get; set; }

        //VehicleCategory variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Vehicle Category"), Required]
        public string VehicleCategory { get; set; }

        //CategoryCost variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        [DataType(DataType.Currency)]
        [Display(Name = "Category Cost")]
        [Required]
        public decimal CategoryCost { get; set; }

        //BookingStartDate variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        [DataType(DataType.Date)]
        [Display(Name = "Booking Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime BookingStartDate { get; set; }

        //BookingEndDate variable with DisplayAttribute, DataTypeAttribute, RequiredAttribute
        [DataType(DataType.Date)]
        [Display(Name = "Booking End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime BookingEndDate { get; set; }

        public Invoice() { }
    }
}