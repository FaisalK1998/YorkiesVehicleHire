using System.ComponentModel.DataAnnotations;

namespace YorkiesVehicleHire.Models
{
    public class Member : Person    //Subclass of Person
    {
        //Display attribute specifies what to display for the name of the field
        //Required attribute specifies that a field is required

        public int MemberID { get; set; }

        //DrivingLicenseNo variable with DisplayAttribute and RequiredAttribute
        [Display(Name = "Driving License Number"), Required]
        public string DrivingLicenseNo { get; set; }

        public Member() { }
    }
}