using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class Toy
    {
        public int ID { get; set; }
        public int CatalogNumber { get; set; }
        [MaxLength(20)]
        public string Title { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:0.##}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }
        public int OrdersAmount { get; set; }
        public string Image { get; set; }

    }
}