﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NBDcase.Models
{
    public class Bid
    {
        public Bid()
        {
            Staffs = new HashSet<Staff>();
            Inventories = new HashSet<Inventory>();
        }

        public int ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BidDate { get; set; }

        [Required(ErrorMessage = "EstBeginDate is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EstBeginDate { get; set; }

        [Required(ErrorMessage = "EstComplDate is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EstComplDate { get; set; }

        [Required(ErrorMessage = "BidAmount is required.")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(19,2)")]
        [Range(0, 99999999999999999.99, ErrorMessage = "Invalid Bid Amount")]
        public decimal BidAmount { get; set; }


        [Required(ErrorMessage = "BidHours is required.")]
        [Range(0, 999, ErrorMessage = "Invalid Bid Hours!")]
        public int BidHours { get; set; }


        [Required(ErrorMessage = "ApprovalNBD is required.")]
        [Display(Name = "Approval")]
        public bool ApprovalbyNBD { get; set; }

        [Required(ErrorMessage = "ApprovalClient is required.")]
        [Display(Name = "Approval")]
        public bool ApprovalbyClient { get; set; }


        [Required(ErrorMessage = "You must select a ProjectID.")]
        [Display(Name = "Project")]
        public int ProjectID { get; set; }
        public Project Project { get; set; }

        [Required(ErrorMessage = "You must select a DesignerID.")]
        [Display(Name = "Designer")]
        public int DesignerID { get; set; }
        public Designer Designer { get; set; }

        [Required(ErrorMessage = "You must select a SalesID.")]
        [Display(Name = "Sales")]
        public int SalesID { get; set; }
        public Sales Sales { get; set; }


        [Display(Name = "Staffs")]
        public ICollection<Staff> Staffs { get; set; }

        [Display(Name = "Inventories")]
        public ICollection<Inventory> Inventories { get; set; }
    }
}
