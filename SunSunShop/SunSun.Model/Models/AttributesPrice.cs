namespace SunSun.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AttributesPrice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AttributesPrice()
        {
            Products = new HashSet<Product>();
        }

        public int ID { get; set; }

        public int? AttributeID { get; set; }

        public int? ProductID { get; set; }

        public decimal? Price { get; set; }

        public bool? Status { get; set; }

        public virtual Attribute Attribute { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
