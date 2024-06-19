using Microsoft.AspNetCore.Mvc;

namespace OmuNaviAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllRestaurants()
        {
            // ここにロジックを追加して、すべてのレストランを取得します。
            return Ok(new List<string> { "Restaurant1", "Restaurant2" });
        }
    }
}