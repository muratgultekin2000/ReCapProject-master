using Core;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace DataAccess.DTOs
{
    public class RentalDetailDto:IDto
    {
        public int id { get; set; }
        public string brandname { get; set; }
        public DateTime modelyear { get; set; }
        public DateTime rentdate { get; set; }
        public DateTime returndate { get; set; }
        public int dailprice { get; set; }
        public string firsname { get; set; }
        public string lastname { get; set; }

    }
}
