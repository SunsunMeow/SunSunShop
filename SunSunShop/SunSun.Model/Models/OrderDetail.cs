namespace SunSun.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetail
    {
        public int ID { get; set; }

        public int? OrderID { get; set; }

        public int? ProductID { get; set; }

        public int? OrderNumber { get; set; }

        public int? Quantity { get; set; }

        public double? Discount { get; set; }

        [StringLength(250)]
        public string Total { get; set; }

        public DateTime? ShipDate { get; set; }
        public bool? Status { get; set; }

        public virtual Order Order { get; set; }
    }
}
