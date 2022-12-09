namespace SunSun.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shipper
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(12)]
        public string Phone { get; set; }

        [StringLength(250)]
        public string Company { get; set; }

        public DateTime? ShipDate { get; set; }
    }
}
