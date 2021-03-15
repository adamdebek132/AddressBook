using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models
{
    public class Address
    {

        [Display(Name = "Twoja ulubiona ulica")]
        [Required]
        public string Street { get; set; }

        [Display(Name = "Twoj ulubiony kod")]
        [StringLength(60, MinimumLength = 3), Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string ZipCode { get; set; }

        [Display(Name = "Twoje ulubione miasto")]
        [Required]
        public string City { get; set; }

        [Display(Name = "Twoj ulubiony numer")]
        [Required]
        public int Number { get; set; }

    }
}
