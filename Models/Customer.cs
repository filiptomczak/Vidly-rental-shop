using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name{ get; set; }
        public string LastName { get; set; }
        public bool IsSubscribed { get; set; }
        public MembershipTypes MembershipType { get; set; }

        [Display (Name="Membership Type")]
        public byte MembershipTypeId { get; set; }
        [Display (Name="Date of birth")]
        [MembershipAgeValidation]
        public DateTime? Birthdate { get; set; }
    }
}