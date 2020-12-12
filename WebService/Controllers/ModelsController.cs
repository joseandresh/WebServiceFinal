using System.Web.Http;
using WebService.Models;

namespace WebService.Controllers
{
    [RoutePrefix("api/Operaciones")]
    public class ModelsController : ApiController
    {
        [HttpGet]
        [Route("{numero:int}")]
        public Model Operaciones (int numero)
        {
            Model model = new Model();
            model.Numero = numero;

            if (numero < 0)
                model.Mensaje = "ERROR";
            if (numero == 0)
                model.Mensaje = "Realizado por Jose Andres Hurtado";
            if (numero > 0)
                model.Mensaje = "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg";

            return model;
        }

    }
}
