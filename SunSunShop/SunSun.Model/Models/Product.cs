namespace SunSun.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string ShortDes { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? CateID { get; set; }

        public int? Price { get; set; }

        public int? Discount { get; set; }

        [StringLength(250)]
        public string Thumb { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public bool? BestSellers { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? Status { get; set; }

        [StringLength(250)]
        public string Tags { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(250)]
        public string Alias { get; set; }

        [StringLength(250)]
        public string MetaDes { get; set; }

        [StringLength(250)]
        public string Metakey { get; set; }

        public int? UnitslnStock { get; set; }

        public virtual AttributesPrice AttributesPrice { get; set; }

        public virtual Category Category { get; set; }
    }
}
