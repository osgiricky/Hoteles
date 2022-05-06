using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Model
{
    public class RESERVAS
    {
        public int ID_RESERVA { get; set; }
        public int ID_SEDE { get; set; }
        public int ID_TIPO_HABITACION { get; set; }
        public DateTime FECHA_IN { get; set; }
        public DateTime FECHA_OUT { get; set; }
        public int NRO_PERSONAS { get; set; }
    }
}
