using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace bibliotecaAestethic.Data
{
    public class MG
    {
        [Key]
        public int id { get; set; }
        public string modelo { get; set; }
        public string nombre { get; set; }
        public string creador { get; set; }
        public int porcentajedefuncionamiento { get; set; }
        public string descripcion { get; set; }
    }
}
