using Core;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace DataAccess.DTOs
{
    public class CarDetailDto:IDto
    {
        public int id { get; set; }
        public string brandname { get; set; }
        public string colorname { get; set; }
        public DateTime modelyear { get; set; }
        public int dailprice { get; set; }
        public String description { get; set; }
    }
}
