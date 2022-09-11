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
    public class ProductoController : ControllerBase
    {
        ProductoLogica estadoLogica = new ProductoLogica();

        [HttpGet]
        public IActionResult get()
        {
            List<ProductoModel> listaResultado = new List<ProductoModel>();
            listaResultado = estadoLogica.ListarTodo();
            return Ok(listaResultado);
        }

        [HttpGet("{id}")]
        public IActionResult getId(int id)
        {
            ProductoModel res = new ProductoModel();
            res = estadoLogica.ObtenerPorId(id);
            return Ok(res);
        }

        [HttpPost]
        public IActionResult post(ProductoModel request)
        {
            ProductoModel response = estadoLogica.CrearRegistro(request);
            return Ok(response);
        }


        [HttpPut]
        public IActionResult put(ProductoModel request)
        {
            ProductoModel response = estadoLogica.ActualizarRegistro(request);
            return Ok(response);
        }


        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            int response = estadoLogica.deleteRegistro(id);
            return Ok(response);
        }
    }
 
  

}
