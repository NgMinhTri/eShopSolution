﻿using eShopSolution.Application.Catalog.Categories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(string languageId)
        {
            var products = await _categoryService.GetAll(languageId);
            return Ok(products);
        }

        [HttpGet("{categoryId}/{languageId}")]
        public async Task<IActionResult> GetById(string languageId, int categoryId)
        {
            var products = await _categoryService.GetById(languageId, categoryId);
            return Ok(products);
        }
    }
}
