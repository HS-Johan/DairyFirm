using DairyFirm.Data;
using DairyFirm.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DairyFirm.Controllers
{
    public class VaccineController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VaccineController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VaccineInfo vaccineInfo)
        {
            _context.VaccineInfos.Add(vaccineInfo);
            _context.SaveChanges();

            return Json("");
        }

        // GET: List
        public IActionResult List()
        {
            var allVaccine = _context.VaccineInfos.ToList();

            return Json("");
        }

        // GET: Details
        public IActionResult Details(int id)
        {
            var vaccine = _context.VaccineInfos.FirstOrDefault(x=> x.VaccineId == id);

            if (vaccine == null)
            {
                return NotFound();
            }

            return Json("");
        }

        // GET: Edit
        public IActionResult Edit(int id)
        {
            var vaccine = _context.VaccineInfos.FirstOrDefault(x => x.VaccineId == id);

            if (vaccine == null)
            {
                return NotFound();
            }

            return Json("");
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(VaccineInfo vaccineInfo)
        {
            _context.VaccineInfos.Update(vaccineInfo);
            _context.SaveChanges();

            return Json("");
        }

        // Delete
        public IActionResult Delete(int id)
        {
            var vaccine = _context.VaccineInfos.FirstOrDefault(x => x.VaccineId == id);

            if (vaccine == null)
            {
                return NotFound();
            }

            _context.VaccineInfos.Remove(vaccine);
            _context.SaveChanges();

             return Json("");
        }
    }
}
