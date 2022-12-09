namespace SunSun.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Location
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        [StringLength(100)]
        public string Slug { get; set; }

        [StringLength(250)]
        public string NameWithType { get; set; }

        [StringLength(250)]
        public string PathWithType { get; set; }

        public int? ParentCode { get; set; }

        public int? Levels { get; set; }
    }
}
