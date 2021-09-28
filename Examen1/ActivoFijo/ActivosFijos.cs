using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.ActivoFijo
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ActivosFijos
    {
        [JsonProperty]
        public int Id { get; set; }
        public string CodigoActivo { get; set; }
        public string NombreActivo { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorActivo { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public TipoActivoFijo TipoActivoFijo { get; set; }
       public MetodoDespreciacion MetodoDespreciacion { get; set; } 
    }
}
