using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string LastName { get; set; }

        public bool IsSubscribed { get; set; }

        public byte MembershipTypeId { get; set; }
        public MembershipTypeDTO MembershipType { get; set; }
        
        //[MembershipAgeValidation]
        public DateTime? Birthdate { get; set; }
    }
}