using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebBarbellApplication.Manager;
namespace WebBarbellApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IAppManager _manager;
        public HomeController(IAppManager manager)
        {
            _manager = manager;
        }
        [HttpGet("SimpleCalculateBarbellOutput")]
        public async Task<List<string>> SimpleCalculateBarbellOutput(int weight)
        {
            return await _manager.BarbellOutput( await _manager.SimpleCalculateBarbell(weight));
        }

        [HttpGet("CalculateBarbellOutput")]
        public async Task<List<string>> CalculateBarbellOutput(int weight)
        {
            return await _manager.BarbellOutput(await _manager.CalculateBarbell(weight));
        }
    }
}
