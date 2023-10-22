using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Penitenciaria.Funcionalidades.ConsultaEstadoReclusosNs;
using Penitenciaria.Funcionalidades.Helper;

namespace Penitenciaria.Controllers
{
    [ApiController]
    [Route("Reclusos")]
    public class ConsultaEstadoReclusosController : ControllerBase
    {
        private readonly ILogger<ConsultaEstadoReclusosController> _logger;

        public ConsultaEstadoReclusosController(ILogger<ConsultaEstadoReclusosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get(
            [FromServices] ConsultaEstadoReclusos consultaEstadoReclusos,
            int pagina = 1,
            int cantidad = 10
        ) {
            if (pagina < 1) throw new ArgumentException("Nro de página inválido.");
            if (cantidad < 1) throw new ArgumentException("Cantidad solicitada inválida de página inválido.");

            var reclusos = consultaEstadoReclusos.ConsultarEstadoBase( (pagina-1) * cantidad, cantidad);

            var settings = new JsonSerializerSettings
            {
                // Excluimos los datos que no nos interesan
                ContractResolver = new DynamicContractResolverExclude(new[] {
                    "Enfermedades",
                    "Visitantes",
                    "Llamadas",
                    "Sentencia",
                    "Abogado",
                    "Pabellon",
                    "CeldaNro"
                }),

                Formatting = Formatting.Indented
            };

            string jsonString = JsonConvert.SerializeObject(reclusos, settings);
            return Content(jsonString, "application/json");
        }

        [HttpGet("{idRecluso}")]
        public ActionResult GerRecluso(
            [FromServices] ConsultaEstadoReclusos consultaEstadoReclusos,
            long idRecluso
        )
        {
            if (idRecluso < 1) throw new ArgumentException("Id recluso inválido.");

            var recluso = consultaEstadoReclusos.ConsultarRecluso(idRecluso);
            return new JsonResult(recluso);
        }
    }
}