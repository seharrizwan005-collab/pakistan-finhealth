using Microsoft.AspNetCore.Mvc;
using WebProject.Models;
using Microsoft.EntityFrameworkCore;

namespace WebProject.Controllers
{
    public class BankController : Controller
    {
        private readonly AppDbContext _context;

        public BankController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Bank/Index
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserID") == null)
                return RedirectToAction("Login", "Auth");

            var banks = _context.Banks.ToList();
            return View(banks);
        }

        // GET: /Bank/Details/5
        public IActionResult Details(int id)
        {
            if (HttpContext.Session.GetString("UserID") == null)
                return RedirectToAction("Login", "Auth");

            var bank = _context.Banks.FirstOrDefault(b => b.BankID == id);
            if (bank == null) return NotFound();

            var ratios = _context.FinancialRatios
                .Include(r => r.RatioCategory)
                .Where(r => r.BankID == id)
                .OrderBy(r => r.Year)
                .ToList();

            ViewBag.Ratios = ratios;
            return View(bank);
        }
    }
}