using Catalog.API.Dtos;
using Catalog.API.Models;
using Catalog.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Service.Abstract
{
    public interface ICourseService
    {
        Task<Response<List<CourseDto>>> GetAllCourseAsync();
        Task<Response<CourseDto>> GetByIdCourseAsync(string id);
        Task<Response<List<CourseDto>>> GetAllCoursesByUserIdAsync(string userId);
        Task<Response<CourseDto>> CreateCourseAsync(CourseCreateDto courseCreateDto);
        Task<Response<NoContent>> UpdateCourseAsync(CourseUpdateDto courseUpdateDto);
        Task<Response<NoContent>> DeleteCourseAsync(string id);


    }
}
