using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.Serialization;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EFCoreModels.Northwind
{
    [KnownType(typeof(SubCategory))]
    [KnownType(typeof(SubSubCategory))]
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

    public partial class SubCategory : Category
    {

        public SubCategory() { }

        [Required]
        public int? TypeInfo { get; set;}
    }

    public partial class SubSubCategory : Category
    {

        public SubSubCategory() { }

        public int? Count { get; set; }
    }
}
