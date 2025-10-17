using Microsoft.AspNetCore.Identity;

namespace ASPNETCoreIdentityDemo.Models
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        // Extended properties
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

        // Audit columns 
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;
    }
}
