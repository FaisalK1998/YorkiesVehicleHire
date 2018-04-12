using System.ComponentModel.DataAnnotations;

namespace YorkiesVehicleHire.Models
{
    public class BookingClerk : Person  //Subclass of Person
    {
        //Display attribute specifies what to display for the name of the field
        //Required attribute specifies that a field is required

        public int BookingClerkID { get; set; }

        //UserID variable with DisplayAttribute and RequiredAttribute
        [Display(Name = "User ID"), Required]
        public int UserID { get; set; }

    }
}