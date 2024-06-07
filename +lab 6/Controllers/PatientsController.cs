using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class PatientsController : Controller
    {
        private readonly IPatientService _patientService;

        public PatientsController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        public async Task<IActionResult> Index(string sortOrder, string src)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "namedesc" : "";
            ViewData["OIBSortParm"] = sortOrder=="Oib" ? "oibdesc" : "Oib";
            ViewData["MBOSortParm"] = sortOrder=="Mbo" ? "mbodesc" : "Mbo";
            ViewData["AdmDateSortParm"] = sortOrder=="admission" ? "admissiondesc" : "admission";
            ViewData["DiscDateSortParm"] = sortOrder=="discharge" ? "dischargedesc" : "discharge";
            ViewData["CurrentFilter"] = src;

            var patients = await _patientService.GetAllPatientsAsync(src, sortOrder);
            return View(patients);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _patientService.GetPatientByIdAsync(id.Value);
            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Oib,Mbo,FullName,Dob,AdmissionDate,DischargeDate,Sex,HasInsurance,IsCheckedIn,Diagnosis")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _patientService.AddPatientAsync(patient);
                    return RedirectToAction(nameof(Index));
                }
                catch (ArgumentException ex)
                    {
                    ModelState.AddModelError(string.Empty, ex.Message); 
                }
            }
            return View(patient);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _patientService.GetPatientByIdAsync(id.Value);
            if (patient == null)
            {
                return NotFound();
            }
            return View(patient);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Oib,Mbo,FullName,Dob,AdmissionDate,DischargeDate,Sex,HasInsurance,IsCheckedIn,Diagnosis")] Patient patient)
        {
            if (id != patient.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _patientService.UpdatePatientAsync(patient);
                    return RedirectToAction(nameof(Index));
                }
                catch (ArgumentException ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                    return View(patient);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await PatientExists(patient.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(patient);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _patientService.GetPatientByIdAsync(id.Value);

            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
   
            await _patientService.DeletePatientAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Discharge(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await _patientService.DischargePatientAsync(id.Value);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> PatientExists(int id)
        {
            return await _patientService.GetPatientByIdAsync(id) != null;
        }

    }
}
