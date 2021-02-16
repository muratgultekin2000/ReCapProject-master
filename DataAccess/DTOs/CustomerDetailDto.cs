using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DTOs
{
    public class CustomerDetailDto:IDto
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string companyname { get; set; }
        public string email { get; set; }

    }
}
