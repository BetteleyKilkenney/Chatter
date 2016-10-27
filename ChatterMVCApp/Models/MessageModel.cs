using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChatterMVCApp.Models
{
    public class MessageModel 
    {
        [Key]
        public int MessageID { get; set; }
        [MaxLength(150)]
        public String MessageText { get; set; }
        public DateTime MessageTimeStamp { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }



        //[ForeignKey("AspNetUsers")]
        ////public virtual ICollection<>
        //public string Id { get; set; }
    }
}