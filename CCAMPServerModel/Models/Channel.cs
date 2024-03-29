﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CCAMPServerModel.Models
{
    public class Channel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public Guid Guid { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        //[ForeignKey("UserId")]
        public User ContentCreatorUser { get; set; }

        public List<Content> ContentList { get; set; }

        public List<Deal> DealList { get; set; }

        public String YoutubeId { get; set; }

        /// <summary>
        /// We don't care about normalizing keywords into a table thus will add more complexity and time to the query
        /// </summary>
        [Required]
        public String KeyWords { get; set; }
    }
}
