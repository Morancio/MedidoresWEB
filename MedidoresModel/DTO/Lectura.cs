using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
    public class Lectura
    {
        private int idMedidor;
        private DateTime fecha;
        private int valor;

        public int IdMedidor { get { return idMedidor; } set { idMedidor = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public int Valor { get { return valor; } set { valor = value; } }
    }
}
