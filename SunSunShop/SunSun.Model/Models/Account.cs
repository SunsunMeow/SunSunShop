namespace SunSun.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account
    {
        public Account() 
        {
            Customers= new HashSet<Customer>();
        }
        public int ID { get; set; }

        [StringLength(12)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(10)]
        public string Salt { get; set; }

        public bool? Status { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        public DateTime? LastLogin { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? RoleID { get; set; }
        //public int? CustomerID { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
