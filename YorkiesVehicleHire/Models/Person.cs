using System.ComponentModel.DataAnnotations;

namespace YorkiesVehicleHire.Models
{
    public class Person
    {

        //Display attribute specifies what to display for the name of the field
        //DataType attribute specifies the type of data


        //Forename variable with DisplayAttribute and RequiredAttribute
        [Display(Name = "Forename"), Required]
        public string Forename { get; set; }

        //Surname variable with DisplayAttribute and RequiredAttribute
        [Display(Name = "Surname"), Required]
        public string Surname { get; set; }

        //Email variable with DisplayAttribute and RequiredAttribute
        [Display(Name = "Email"), Required]
        public string Email { get; set; }

        //Password variable with DisplayAttribute and RequiredAttribute
        [Display(Name = "Password"), Required]
        public string Password { get; set; }

        //ConfirmPassword variable with DisplayAttribute and RequiredAttribute
        [Display(Name = "Confirm Password"), Required]
        public string ConfirmPassword { get; set; }

        //PhoneNumber variable with DisplayAttribute and RequiredAttribute
        [Display(Name = "Phone Number"), Required]
        public int PhoneNumber { get; set; }

        //HomePhoneNumber variable with DisplayAttribute
        [Display(Name = "Home Phone Number")]
        public int HomePhoneNumber { get; set; }

        //HouseNumber variable with DisplayAttribute
        [Display(Name = "House Number")]
        public int HouseNumber { get; set; }

        //Street variable with DisplayAttribute
        [Display(Name = "Street")]
        public string Street { get; set; }

        //Town variable with DisplayAttribute
        [Display(Name = "Town")]
        public string Town { get; set; }

        //Postcode variable with DisplayAttribute
        [Display(Name = "Postcode")]
        public string Postcode { get; set; }

        public Person() { }

    }

}