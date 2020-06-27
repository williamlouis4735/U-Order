using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;


namespace TinyShop.Controllers
{
    public class ProductController : Controller
    {
        private ProductService _productService;
       
        private  IHostingEnvironment _hostingEnvironment;
       
        public ProductController(DataContext context)
        {
            _productService = new ProductService(context);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProductVO product)
        {
            var productDO = new ProductDO
            {
                ProductNumber = product.ProductNumber,
                ProductName = product.ProductName,
                Price = Convert.ToDouble(product.Price),
                ProductType = product.ProductType,
                ImgUrl = product.ImgUrl
            };

            try
            {
                var insertedProduct = _productService.Insert(productDO);

                return Json(new
                {
                    code = "success",
                    data = insertedProduct
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll(string order)
        {
            try
            {
                var result = _productService.GetAll(order);
                return Json(new
                {
                    code = "success",
                    data = result
                });

            }
            catch (Exception ex)
            {
                return Json(new
                {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult Delete(long id)
        {
            try
            {
                _productService.Delete(id);
                return Json(new
                {
                    code = "success",
                });

            }
            catch (Exception ex)
            {
                return Json(new
                {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult GetProductById(long id)
        {
            try
            {
                var product = _productService.GetById(id);
                return Json(new
                {
                    code = "success",
                    data = product
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult Edit(long id)
        {
            ViewBag.Id = id;
            return View();
        }
        public IActionResult Table()
        {
            return View();
        }
        public IActionResult Update([FromBody] ProductVO product)
        {
            try
            {
                var productDO = new ProductDO
                {
                    Id = product.Id,
                    ProductNumber = product.ProductNumber,
                    ProductName = product.ProductName,
                    ProductType = product.ProductType,
                    Price = Convert.ToDouble(product.Price)
                };
                _productService.Update(productDO);
                return Json(new
                {
                    code = "success",
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    code = "fail",
                    message = ex.Message
                });
            }




        }

        public IActionResult GetProductsByKeyword(string keyword)
        {
            try
            {
                var result = _productService.GetByKeyword(keyword);

                return Json(new
                {
                    code = "success",
                    data = result
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult GetAllProductsByCategory(string category)
        {
            try
            {
                var result= _productService.GetByCategory(category);

                return Json(new
                {
                    code = "success",
                    data = result
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    code = "fail",
                    message = ex.Message
                });
            }
        }
        public IActionResult UploadImage(IFormFile file)
        {

            var uploadDir = "upload";

            var fileExtension = Path.GetExtension(file.FileName);

            var targetFileName = $"{Guid.NewGuid()}{fileExtension}";

            var targetDir = Path.Combine("wwwroot", uploadDir);
            var targetFilePath = Path.Combine(targetDir, targetFileName);

            try
            {
                if (!Directory.Exists(targetDir))
                {
                    Directory.CreateDirectory(targetDir);
                }

                using (var fs = new FileStream(targetFilePath, FileMode.Create))
                {
                    file.CopyTo(fs);
                }

                return Json(new
                {
                    code = "success",
                    data = targetFileName
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    code = "fail",
                    message = ex.Message
                });
            }
        }
    }
}
