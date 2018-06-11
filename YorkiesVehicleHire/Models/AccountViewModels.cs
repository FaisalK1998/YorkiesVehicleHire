using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YorkiesVehicleHire.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    //Holds data entered from the login view
    /// <summary>
    /// Class LoginViewModel.
    /// </summary>
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    //Holds data from the register view
    /// <summary>
    /// Class RegisterViewModel.
    /// </summary>
    public class RegisterViewModel
    {
        //Validates the users name is at least 1 character long and no longer than 50
        [Required]
        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        [MaxLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        [MinLength(1, ErrorMessage = "Name must be longer than 1 character")]
        public string Name { get; set; }

        //Validates the email field contains an email address
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //Validates that the password is at least 6 characters long
        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        //Validates the phone number only contains numerical characters
        [Required]
        [Display(Name = "Mobile Phone Number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Mobile Number must be numeric")]
        public string MobilePhoneNo { get; set; }
       
        //Validates that the driving licence number is 16 characters long
        [Required]
        [MaxLength(16, ErrorMessage = "Driving licence number cannot be more than 16 characters long")]
        [MinLength(16, ErrorMessage = "Driving licence number cannot be less than 16 characters long")]
        [Display(Name = "Driving Licence Number")]
        public string DrivingLicenceNo { get; set; }

        //Holds the user's role when registering
        [Required]
        [Display(Name = "Role")]
        public string Role { get; set; }

        public RegisterViewModel()
        {
            Name = "";
            Email = "";
            Password = "";
            ConfirmPassword = "";
            MobilePhoneNo = "";
            DrivingLicenceNo = "";
            Role = "Member";
        }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class EmailViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Confirmed")]
        public bool EmailConfirmed { get; set; }
    }

    public class ChangeEmailViewModel
    {
        [Required]
        [Display(Name = "New email")]
        [DataType(DataType.EmailAddress)]
        public string NewEmail { get; set; }

        [Required]
        [Display(Name = "Confirm email")]
        [Compare("NewEmail", ErrorMessage = "The new email and confirmation email do not match.")]
        [DataType(DataType.EmailAddress)]
        public string ConfirmEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string CurrentPassword { get; set; }
    }

    public class DeleteAccountViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Delete account")]
        public bool Checked { get; set; }
    }

}
