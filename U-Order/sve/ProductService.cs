﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace sve
{
    class ProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public ProductDO Insert(ProductDO product)
        {
            _context.Set<ProductDO>().Add(product);
            _context.SaveChanges();
            return
                product;
        }
    }
}
