using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FacultySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        [HttpGet]
        [Route("IsAuthorized")]

        public IActionResult IsAuthorized()
        {
            string Curent_Role = HttpContext.Session.GetString("Role");
            if (Curent_Role == "Staff")
            {
                return Ok(new
                {
                    message = "Authorized User",
                });
            }
            else
            {
                return Unauthorized(new { error = "Unauthorized User" });
            }
        }
    }
}
