using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETCoreIdentityDemo.Models
{
    public class Address 
    {
        public Guid Id { get; set; }
        //FK to ApplicationUser
        [Required]
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser? User { get; set; } = null;

        public string? Street { get; set; } = null;
        public string? City { get; set; } = null;
        public string? State { get; set; } = null;
        public string? PostalCode { get; set; } = null;
        public string? Country { get; set; } = null;
        public bool IsActive { get; set; }

        //Audit columns
        public DateTime? CreateOn { get; set; }
        public DateTime? ModifiedonOn { get; set; }
    }
}
