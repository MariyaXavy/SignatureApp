using Microsoft.AspNetCore.Mvc;
using SignatureApp.Data;
using SignatureApp.Models;

namespace SignatureApp.Controllers
{
    public class FormController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly ApplicationDbContext _context;

        public FormController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> Submit(UserForm form)
        {
            if (!ModelState.IsValid) return View("Index", form);
            _context.UserForms.Add(form);
            await _context.SaveChangesAsync();
            return RedirectToAction("Confirmation", form);
        }

        [HttpGet]
        public IActionResult Confirmation(UserForm form) => View(form);
    }
}
