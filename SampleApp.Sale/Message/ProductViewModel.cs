﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Sale.Message
{
    public class ProductViewModel
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
    }
}
