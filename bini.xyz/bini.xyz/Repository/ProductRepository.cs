using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bini.xyz.Models;
using Microsoft.AspNetCore.Routing;

namespace bini.xyz.Repository
{
	public class ProductRepository
	{
		public List<ProductModel> GetAllProduct()
		{
			return DataSource();
		}

		public ProductModel GetProduct(int id)
		{

			return DataSource().Where(x => x.Id == id).FirstOrDefault();
		}

		public List<ProductModel> SearchProduct(string productname, string productType)
		{
			return DataSource().Where(x => x.Name.Contains(productname) && x.Type.Contains(productType)).ToList();
		}
		private List<ProductModel> DataSource()
		{
			return new List<ProductModel>()
			{
				new ProductModel(){ Id = 1, Name ="Surgical Gown", Description = "Used in Surgery", Type = "A"},
				new ProductModel(){ Id = 2, Name ="Pep Kit", Description = "Overall gown and related material for pep", Type = "A"},
				new ProductModel(){ Id = 3, Name ="Gloves", Description = "For miscellaneous use", Type = "B"},
				new ProductModel(){ Id = 4, Name ="Mask", Description = "For miscellaneous use", Type = "B"},
				new ProductModel(){ Id = 5, Name ="Dressing Pad", Description = "Used in beds for patients", Type = "C"},
				new ProductModel(){ Id = 6, Name ="Patient Gown", Description = "gOWN FOR PATIENT", Type = "A"},
			};

		}
	}
}
