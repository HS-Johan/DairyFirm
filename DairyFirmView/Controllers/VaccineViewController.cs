using Azure;
using DairyFirmView.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace DairyFirmView.Controllers
{
    public class VaccineViewController : Controller
    {
        private readonly HttpClient _httpClient;

        public VaccineViewController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //View: Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Get: Create
        [HttpPost]
        public async Task <IActionResult> Create(VaccineInfoVM vaccineVM)
        {
            var jsonContent = new StringContent(
                JsonConvert.SerializeObject(vaccineVM),
                Encoding.UTF8,
                "application/json"
            );
            var url = $"https://localhost:44371/Vaccine/Create";

            var api =await _httpClient.PostAsync(url,jsonContent);
            if (!api.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            var jsonData = await api.Content.ReadAsStringAsync();
           
            return RedirectToAction("List");
        }

        //View: List
        public async Task<IActionResult> List()
        {
            var url = $"https://localhost:44371/Vaccine/List";

            var responce = await _httpClient.GetAsync(url);

            if (!responce.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            var jsonData = await responce.Content.ReadAsStringAsync();

            var vaccines = JsonConvert.DeserializeObject<List<VaccineInfoVM>>(jsonData);

            return View(vaccines);

        }

        //View: Details
        public async Task<IActionResult> Details(int id)
        {
            if( id <= 0 )
            {
                return BadRequest();
            }

            var url = $"https://localhost:44371/Vaccine/Details/{id}";

            var responce = await _httpClient.GetAsync(url);

            if (!responce.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            var jsonData = await responce.Content.ReadAsStringAsync();

            var vaccine = JsonConvert.DeserializeObject<VaccineInfoVM>(jsonData);

            return View(vaccine);
        }

        //View: Edit
        public async Task<IActionResult> Edit(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var url = $"https://localhost:44371/Vaccine/Edit/{id}";

            var responce = await _httpClient.GetAsync(url);

            if (!responce.IsSuccessStatusCode) 
            {
                return BadRequest();
            }

            var jsonData = await responce.Content.ReadAsStringAsync();

            var vaccine = JsonConvert.DeserializeObject<VaccineInfoVM>(jsonData);

            return View(vaccine);
        }

        //Post: Edit
        [HttpPost]
        public async Task<IActionResult> Edit( VaccineInfoVM vaccineInfoVM )
        {
            if( vaccineInfoVM == null )
            {
                return BadRequest();
            }

            var jsonContent = new StringContent(
                JsonConvert.SerializeObject(vaccineInfoVM),
                Encoding.UTF8,
                "application/json"
            );
            var url = $"https://localhost:44371/Vaccine/Edit";

            var api = await _httpClient.PostAsync(url, jsonContent);
            if (!api.IsSuccessStatusCode)
            {
                return BadRequest();
            }

            var jsonData = await api.Content.ReadAsStringAsync();

            return RedirectToAction("List");
        }

        //View: Delete
        public async Task<IActionResult> Delete(int id)
        {
            if( id <= 0 )
            {
                return BadRequest();
            }

            var url = $"https://localhost:44371/Vaccine/Delete/{id}";

            var responce = await _httpClient.GetAsync(url);

            if( !responce.IsSuccessStatusCode )
            {
                return BadRequest();
            }

            var jsonData = await responce.Content.ReadAsStringAsync();

            return Json(new { head = "Deleted", body = "Vaccine Deleted Successfully.", icon = "success" });
        }
    }
}
