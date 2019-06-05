using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestFindsApi.Data;
using BestFindsApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BestFindsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repository;
        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<Product[]>> Get()
        {
            var results = await _repository.GetAllProductsAsync();

            return results;
        }

        [HttpGet("{categoryId:int}")]
        public async Task<ActionResult<Product[]>> GetByCategoryId(int categoryId)
        {
            var results = await _repository.GetAllProductsByCategory(categoryId);

            return results;
        }

    }
}