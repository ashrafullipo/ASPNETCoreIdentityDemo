using Microsoft.AspNetCore.Identity;

namespace ASPNETCoreIdentityDemo.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsActive { get; set; } = true;
        //Audit columns
         public DateTime? CreateOn { get; set; }
        public DateTime? ModifiedonOn { get; set; }

        // Navigation properties one-to-many relationship with Address
        public virtual List<Address> Addresses { get; set; } = new List<Address>();
    }
}
