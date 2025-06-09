#region Usings
using System.ComponentModel.DataAnnotations;
using Template.Constants;
#endregion

namespace Template.Dtos
{
    public class UserDto
    {
        #region Properties
        [Required]
        [MaxLength(Validations.FIRST_NAME_MAX_LENGTH)]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(Validations.MIDDLE_NAME_MAX_LENGTH)]
        public string MiddleName { get; set; } = string.Empty;

        [Required]
        [MaxLength(Validations.LAST_NAME_MAX_LENGTH)]
        public string LastName { get; set; } = string.Empty;

        //[Required(ErrorMessage = ErrorMsgs.EMPTY_PHONE)]
        [MinLength(Validations.PHONE_NUMBER_MIN_LENGTH)]
        [MaxLength(Validations.PHONE_NUMBER_MAX_LENGTH)]
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        #endregion
    }
}
