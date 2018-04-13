using System.ComponentModel.DataAnnotations;

namespace YorkiesVehicleHire.Models
{
    public class VehicleCategory
    {
        //Display attribute specifies what to display for the name of the field
        //Required attribute specifies that a field is required

        //VehicleCategoryCode variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Vehicle Category Code"), Required]
        public string VehicleCategoryCode { get; set; }

        //VehicleCategoryDescription variable with DisplayAttribute, RequiredAttribute
        [Display(Name = "Vehicle Category Description"), Required]
        public string VehicleCategoryDescription { get; set; }

        public VehicleCategory() { }
    }
}