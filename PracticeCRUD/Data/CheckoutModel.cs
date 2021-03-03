using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCard_Stripe.Data
{
    public class CheckOutModel
    {

        [Required]
        [CreditCard(ErrorMessage = "Credit Card is invalid")]
        public string CreditCard { get; set; }

        [Required]
        [StringLength(2, ErrorMessage = "Please enter a valid expiry month.")]
        [MinLength(1, ErrorMessage = "Please enter a valid expiry month.")]
        public string ExpiryMonth { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{4,4}$", ErrorMessage = "Only Numbers are allowed.")]
        [StringLength(4, ErrorMessage = "Please enter a valid expiry year.")]
        public string ExpiryYear { get; set; }

        [Required]
        [StringLength(3, ErrorMessage = "Please enter a valid CVC.")]
        public string CVC { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Please enter a valid Address.")]
        [RegularExpression(@"^[A-Za-z0-9]+(?:\s[A-Za-z0-9'_-]+)+$")]
        public string AddressLine1 { get; set; }


        [StringLength(100, ErrorMessage = "Please enter a valid Address.")]
        [RegularExpression(@"^[A-Za-z0-9]+(?:\s[A-Za-z0-9'_-]+)+$")]
        public string AddressLine2 { get; set; }



        [Required]
        [StringLength(100, ErrorMessage = "Please enter a valid City Name.")]
        [RegularExpression(@"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$")]
        public string City { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "Please enter a valid City Name.")]
        [RegularExpression(@"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$")]
        public string State { get; set; }


        [Required]
        [StringLength(5, ErrorMessage = "Please enter a valid Zipcode.")]
        [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$")]
        public string Zipcode { get; set; }


        [Required]
        [MinLength(1, ErrorMessage = "Please enter a valid name.")]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter a valid Phone Number.")]
        public string PhoneNumber { get; set; }




    }
}
