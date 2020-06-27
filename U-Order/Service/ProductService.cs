using Data.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class ProductService
    {
        private DataContext _context;

        public ProductService(DataContext context)
        {
           _context = context;
        }

        public ProductDO Insert(ProductDO product)
        {
            _context.Set<ProductDO>().Add(product);
            _context.SaveChanges();
            return product;
        }

        public IEnumerable<ProductDO> GetAll(string order)
        {
            if (order == "asc")
            {
                return _context.Set<ProductDO>().OrderBy(t=>t.Price);
            }

            return _context.Set<ProductDO>().OrderByDescending(t => t.Price);
        }

        public void Delete(long id)
        {
            var product = _context.Set<ProductDO>().FirstOrDefault(t => t.Id == id);
            if (product == null)
                throw new Exception("没有找到指定ID的产品记录");
            _context.Set<ProductDO>().Remove(product);
            _context.SaveChanges();

        }
        public ProductDO GetById(long id)
        {
            var product = _context.Set<ProductDO>().FirstOrDefault(t => t.Id == id);
            if (product==null)
            {
                throw new Exception("没有找到指定ID的产品记录");
            }
            return product;

        }

        public ProductDO Update(ProductDO product)
        {
            var productExists = _context.Set<ProductDO>().Any(t => t.Id == product.Id);
            if (!productExists)
            {
                throw new Exception("没有找到指定ID的产品记录");
            }

            _context.Set<ProductDO>().Update(product);
            _context.SaveChanges();
            return product;
        }
        public IEnumerable<ProductDO> GetByKeyword(string keyword)
        {
            var result = _context.Set<ProductDO>().Where(t => t.ProductName.Contains(keyword));
            return result;
        }
        public IEnumerable<ProductDO> GetByCategory(string category)
        {
            var result = _context.Set<ProductDO>().Where(t =>t.ProductType==category);

            return result;
        }
    }

}