using CodeFirstDemo.Context;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstDemo.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly UserDbContext _context;

        public RegistrationController(UserDbContext context)
        {
            _context = context;
        }

        // GET: RegistrationController
        public ActionResult Create()
        {
            return View();
        }

        // GET: RegistrationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            ViewBag.message = "The user " + user.UserName + " is saved successfully";
            return View();
        }

    }
}
