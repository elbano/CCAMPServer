﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CCAMPServerModel.Models
{
    public class Campaign
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public Guid Guid { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }

        //[ForeignKey("UserId")]
        public User SponsorUser { get; set; }

        public List<Advertisement> AdvertisementList { get; set; }

        public List<Deal> DealList { get; set; }
    }
}
