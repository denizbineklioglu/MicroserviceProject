using Catalog.API.Dtos;
using Catalog.API.Models;
using Catalog.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Service.Abstract
{
    public interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllCategoryAsync();
        Task<Response<CategoryDto>> CreateCategoryAsync(CategoryDto category);
        Task<Response<CategoryDto>> GetByIdCategoryAsync(string id);

    }
}
