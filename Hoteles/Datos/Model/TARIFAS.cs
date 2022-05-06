using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Model
{
    public class TARIFAS
    {
        public int ID_TARIFA { get; set; }
        public int ID_SEDE { get; set; }
        public int ID_TIPO_HABITACION { get; set; }
        public DateTime FECHA_INI { get; set; }
        public DateTime FECHA_FIN { get; set; }
        public int VALOR_NOCHE_PERSONA { get; set; }
    }
}
