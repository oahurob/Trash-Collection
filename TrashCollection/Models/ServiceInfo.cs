using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollection.Models
{
    public class ServiceInfo
    {
        [Key]
        public int Id { get; set; }
        public double Balance { get; set; }
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Pick Up Day")]
        public string PickUpDay { get; set; }
        [Display(Name = "One Time Pick Up")]
        public DateTime OneTimePickUp { get; set; }
        public bool IsSuspended { get; set; }
        public bool IsPickedUp { get; set; }

    }
}
