namespace SunSun.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
            //Accounts = new HashSet<Account>();
        }

        public int ID { get; set; }

        [StringLength(250)]
        public string FullName { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(250)]
        public string Avatar { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(12)]
        public string Phone { get; set; }

        public int? District { get; set; }

        public int? LocationID { get; set; }

        public int? Ward { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(10)]
        public string Salt { get; set; }

        public DateTime? LastLogin { get; set; }

        public bool? Status { get; set; }
        public int AccountID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Account Account { get; set; }
        //public virtual ICollection<Account> Accounts { get;}
    }
}
