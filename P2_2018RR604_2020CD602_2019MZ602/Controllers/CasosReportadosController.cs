using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2018RR604_2020CD602_2019MZ602.Models;

namespace P2_2018RR604_2020CD602_2019MZ602.Controllers
{
    public class CasosReportadosController : Controller
    {
        private readonly covidDbContext _covidDbContext;

        public CasosReportadosController(covidDbContext covidDbContext)
        {
            _covidDbContext = covidDbContext;
        }


        // GET: CasosReportadosController
        public ActionResult Index()
        {
            var listadoDepartamentos = (from d in _covidDbContext.Departamentos select d).ToList();

            ViewData["listadoDepartamentos"] = new SelectList(listadoDepartamentos, "id", "nombre");

            var listadoGenero = (from g in _covidDbContext.Generos select g).ToList();

            ViewData["listadoGenero"] = new SelectList(listadoGenero, "id", "nombre");


            return View();
        }

        // GET: CasosReportadosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CasosReportadosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CasosReportadosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CasosReportadosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CasosReportadosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CasosReportadosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CasosReportadosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
