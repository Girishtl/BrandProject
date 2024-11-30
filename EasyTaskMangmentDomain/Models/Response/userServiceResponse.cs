﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentDomain.Models.Response
{
    public  class userServiceResponse
    {
        public int Id { get; set; } // Auto-incrementing primary key

      
        public string ServiceName { get; set; } // Name of the service

        public decimal ServiceCost { get; set; } // Cost of the service

        public string ServiceDescription { get; set; }


        public bool IsActive { get; set; }
    }
}