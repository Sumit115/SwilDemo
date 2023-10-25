using Microsoft.AspNetCore.Mvc;
using SwilDemo.Models;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SwilDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJDbGllbnRVc2VySUQiOiI4NiIsIkNsaWVudFVzZXJOYW1lIjoicGF3YW4iLCJEQlR5cGUiOiIiLCJDbGllbnRSZWdJRCI6IjEzNjEwIiwiT3RoZXIiOiLDk8Olw7LDtsOlw7IgPSDDs8O3w6nDrMO0w6XDs8O0LsOkw6HDtMOhw6LDocOzw6Uuw7fDqcOuw6TDr8O3w7Muw67DpcO0LDE0MzM7IMOEw6HDtMOhw6LDocOzw6UgPSDDksOlw7TDocOpw6zDlMOlw7PDtDsgw5XDs8Olw7Igw4nDhCA9IMOzw7fDqcOsw7TDpcOzw7Q7IMOQw6HDs8Ozw7fDr8Oyw6QgPSDDk8O3w6nDrMOFw7LDsMOTw6XDssO2w6XDkiM5OTsgw5TDssO1w7PDtMOTw6XDssO2w6XDssODw6XDssO0w6nDpsOpw6PDocO0w6U9w5TDssO1w6U7IiwiVXNlcklEIjoiMTAwMDAwMDgiLCJWZXJzaW9uIjoiMy4yLjE1LjA5IiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiQWRtaW4iLCJleHAiOjE2OTc3MzM5MTUsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6NzI5OSIsImF1ZCI6Imh0dHA6Ly9sb2NhbGhvc3Q6NzI5OSJ9.Ur0yCLCiExyEeJoKZK4IKl4s2deaARR7l2udjTGx92A"; 
            
            return View("HEllo");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}