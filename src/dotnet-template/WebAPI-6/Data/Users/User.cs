using System.ComponentModel.DataAnnotations;

namespace Template.Data.Users
{
    public class User
    {
        #region Columns
        [Key]
        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        #endregion
    }
}
