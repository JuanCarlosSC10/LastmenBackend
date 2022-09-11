using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   
    public class ClienteModel
    {

        [Key] // es la llave primaria de mi base de datos        
        public int CodCliente { get; set; }

        public string Ruc { get; set; }
        
        public string Direccion { get; set; }
       
        public string Celular { get; set; }
        
        public string Email { get; set; }
        public string Nombres { get; set; }
        public string Dni { get; set; }
        


    }
}
