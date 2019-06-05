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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _repository;
        public CategoriesController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<Category[]>> Get()
        {
            var results = await _repository.GetAllCategoriesAsync();

            return results;
        }

    }
}