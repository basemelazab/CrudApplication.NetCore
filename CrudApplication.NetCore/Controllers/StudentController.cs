using CrudApplication.NetCore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CrudApplication.NetCore.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext applicationDbConext;
        public StudentController(ApplicationDbContext applicationDbConext)
        {
            this.applicationDbConext = applicationDbConext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllStudent()
        {
           var Students = await applicationDbConext.Students.ToListAsync();
            return View(Students);   
        }
    }
}
