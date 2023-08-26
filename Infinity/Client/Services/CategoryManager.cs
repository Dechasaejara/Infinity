using Infinity.Shared.DTOs;

namespace Infinity.Client.Services
{
    public class CategoryManager : APIRepository<CategoryDTO>
    {
        HttpClient http;
        public CategoryManager(HttpClient _http) : base(_http, "Categories", "Id")
        {
            http = _http;
        }
    }
}
