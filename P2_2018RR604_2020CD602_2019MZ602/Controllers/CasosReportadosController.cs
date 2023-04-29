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

        public IActionResult Index()
        {
            var listadodepartamentos = (from d in _covidDbContext.Departamentos
                                        select d).ToList();

            ViewData["listadodepartamentos"] = new SelectList(listadodepartamentos, "id", "nombre");

            var listadogenero = (from g in _covidDbContext.Generos
                                 select g).ToList();

            ViewData["listadogenero"] = new SelectList(listadogenero, "id", "nombre");
            var listadoCaso = (from c in _covidDbContext.CasosReportados
            join d in _covidDbContext.Departamentos on c.departamento_id equals d.id
                                 join g in _covidDbContext.Generos on c.genero_id equals g.id
                                 select new
                                 {
                                     departamentos = d.nombre,
                                     genero = g.nombre,
                                     confirmados = c.confirmados,
                                     recuperados = c.recuperados,
                                     fallecidos = c.fallecidos,

                                 }).ToList();
            ViewData["listadoCaso"] = listadoCaso;

            return View();

        }
        public IActionResult CrearDatos(CasosReportados nuevoDato)
        {
            _covidDbContext.Add(nuevoDato);
            _covidDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

