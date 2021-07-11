using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Models
{
    public class Order
    {
        [Key]
        [BindNever]
        public int OrderId { get; set; }
        //this is the proberty the one who making the order
        [Required(ErrorMessage ="Pleace enter your first name")]
        [Display(Name ="First Name")]
        [StringLength(25)]
        //information about the user
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Pleace enter your last name")]
        [Display(Name = "LastName")]
        [StringLength(55)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Pleace enter your Address")]
        [Display(Name = "Street Address")]
        [StringLength(100)]
        public string Address { get; set; }


        [Required(ErrorMessage = "Pleace enter your City")]
        
        public string City { get; set; }
        [Required(ErrorMessage = "Pleace enter your State")]
        [StringLength(30,MinimumLength =2)]
        public string State { get; set; }

        [Required(ErrorMessage = "Pleace enter your Zip")]
        [StringLength(20, MinimumLength = 2)]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Pleace enter your Phone")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        //all the fruit has been orded
        public List<OrderDetail> OrderDetails { get; set; }
        // Total order and Time when order is ordeded
        [BindNever]
        public double OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlaced { get; set; }
    }
}
