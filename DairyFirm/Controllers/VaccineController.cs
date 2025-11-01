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
        public IActionResult Create([FromBody] VaccineInfo vaccineInfo)
        {
            _context.VaccineInfos.Add(vaccineInfo);
            _context.SaveChanges();

            return Json("Vaccine Created Successfully.");
        }

        // GET: List
        public IActionResult List()
        {
            var allVaccine = _context.VaccineInfos.ToList();

            return Json(allVaccine);
        }

        // GET: Details
        public IActionResult Details(int id)
        {
            if(id <= 0)
            {
                return NotFound();
            }

            var vaccine = _context.VaccineInfos.FirstOrDefault(x=> x.VaccineId == id);

            if (vaccine == null)
            {
                return NotFound();
            }

            return Json(vaccine);
        }

        // GET: Edit
        public IActionResult Edit(int id)
        {
            if( id <= 0 )
            {
                return NotFound();
            }

            var vaccine = _context.VaccineInfos.FirstOrDefault(x => x.VaccineId == id);

            if (vaccine == null)
            {
                return NotFound();
            }

            return Json(vaccine);
        }

        // POST: Edit
        [HttpPost]
        public IActionResult Edit([FromBody] VaccineInfo vaccineInfo)
        {
            _context.VaccineInfos.Update(vaccineInfo);
            _context.SaveChanges();

            return Json("Vaccine Updated Successfully.");
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
