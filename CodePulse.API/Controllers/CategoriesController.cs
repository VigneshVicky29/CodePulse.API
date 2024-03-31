using CodePulse.API.Data;
using CodePulse.API.Models.Domain;
using CodePulse.API.Models.DTO;
using CodePulse.API.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.API.Controllers
{
    // https://localhost:xxxx/api/categories   
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        //private readonly ApplicationDBContext dbContext;

        //public CategoriesController(ApplicationDBContext dbContext)
        //{
        //    this.dbContext = dbContext;
        //}

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request) 
        {
            //Map the request (DTO) to a domain object
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            }; 

            //await dbContext.Categories.AddAsync(category);
            //await dbContext.SaveChangesAsync();

            await categoryRepository.CreateCategory(category);

            //Domail model to dto
            var response = new CategoryDto
            {
                Id = category.Id,
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };

            return Ok(response);
        }

    }
}
