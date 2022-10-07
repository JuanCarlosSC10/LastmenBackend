using Logica;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace PersonalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
   
    public class ProveedorController : ControllerBase
    {
        /*ctrl + r + r */
        ProveedorLogica clientelog = new ProveedorLogica();

        [HttpGet]
        public IActionResult get()
        {
            List<ProveedorModel> listaResultado = new List<ProveedorModel>();
            listaResultado = clientelog.ListarTodo();
            return Ok(listaResultado);
        }


        [HttpGet("{id}")]
        public IActionResult getId(int id)
        {
            ProveedorModel res = new ProveedorModel();
            res = clientelog.ObtenerPorId(id);
            return Ok(res);
        }

        [HttpPost]
        public IActionResult post(ProveedorModel request)
        {
            ProveedorModel response = clientelog.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult put(ProveedorModel request)
        {
            ProveedorModel response = clientelog.ActualizarRegistro(request);
            return Ok(response);
        }


        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            int response = clientelog.deleteRegistro(id);
            return Ok(response);
        }

    }
}
