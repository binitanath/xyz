using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bini.xyz.Repository;
using Microsoft.AspNetCore.Mvc;
using bini.xyz.Models;

namespace bini.xyz.Controllers
{
	public class ProductsController : Controller
	{
		public readonly ProductRepository _productRepository  = null;

		public ProductsController()
		{
			_productRepository = new ProductRepository();
		}

		public ViewResult GetAllProducts()
		{
			//return _productRepository.GetAllProduct();
			return View();
		}
		public ProductModel GetProduct(int id)
		{
			return _productRepository.GetProduct(id);
		}
		public List<ProductModel> SearchProduct(string productName, string productType)
		{
			return _productRepository.SearchProduct(productName, productType) ;
		}

	}
}
