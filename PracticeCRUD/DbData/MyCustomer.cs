using PracticeCRUD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCRUD.DbData
{
    public class MyCustomer
    {

        [Key]
        public string CustomerID { get; set; }

        public string LinkToUserTableID { get; set; }


        public string TimeRegistered { get; set; } = DateTime.UtcNow.ToString();

        [MinLength(2)]
        [RegularExpression("[^a-zA-Z]")]
        [Required]
        public string Name { get; set; }

        
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        [EmailAddress]
        public string EmailAddress { get; set; }

        [MinLength(2)]
        [RegularExpression("[^a-zA-Z]")]
        [Required]
        public string City { get; set; }

        [MinLength(2)]
        [RegularExpression("[^a-zA-Z]")]
        [Required]
        public string State { get; set; }





    }
}
