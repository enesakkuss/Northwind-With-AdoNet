﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNorthwind
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public Nullable<int> SupplierId { get; set; }  
        public int? CategoryID { get; set; }  
        public string? QuantityPerUnit { get; set; }  
        public decimal? UnitPrice { get; set; }  
        public short? UnitsInStock { get; set; }  
        public short? UnitsOnOrder { get; set; }  
        public short? ReorderLevel { get; set; }  
        public bool Discontinued { get; set; }  
    }
}
