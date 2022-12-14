//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WAD_T2104E_LeQuangAnh.EDM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Product
    {
        [Display(Name = "Product Id : ")]
        public int Productid { get; set; }
        [Display(Name = "Product name : ")]
        [Required(ErrorMessage = "product name can not required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "name product is length like 3 ->30")]
        public string Name { get; set; }
        [Display(Name = "Price : ")]
        [Required(ErrorMessage = "can not required price")]
        public Nullable<double> Price { get; set; }
        [Display(Name = "Quantity : ")]
        [Required(ErrorMessage = "can not required quantity")]
        [Range(1, 100, ErrorMessage = "quantity can be 1 to 100")]
        public Nullable<int> Quantity { get; set; }
        [Display(Name = "Releasedate : ")]
        [DataType(DataType.Date, ErrorMessage = "only date type")]
        public Nullable<System.DateTime> RelesaseDate { get; set; }
        public Nullable<int> Categoryid { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
