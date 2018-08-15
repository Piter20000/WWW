using System;
using System.ComponentModel.DataAnnotations;

namespace WWW.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public bool IsSubscribedToNewsletter { get; set; }
        
        public MembershipType MembershipType { get; set; }

        [Display(Name = "MembershipType")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth, like 01.12.2018")]

        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}