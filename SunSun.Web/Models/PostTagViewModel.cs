using System.ComponentModel.DataAnnotations;
using System;

namespace SunSun.Web.Models
{
    public class PostTagViewModel
    {
        public int PostID { set; get; }
        public string TagID { set; get; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
        public virtual PostViewModel Post { set; get; }

        public virtual TagViewModel Tag { set; get; }
    }
}