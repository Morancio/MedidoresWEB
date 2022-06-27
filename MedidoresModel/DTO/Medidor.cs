using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
    public class Medidor
    {
        private int id;
        private int tipo;

        public String TipoTXT
        {
            get
            {
                string tipoTXT = "";
                switch (tipo)
                {
                    case 1: tipoTXT = "Luz";
                        break;
                    case 2: tipoTXT = "Agua";
                        break;
                }
                return tipoTXT;
            }
        }

        public int Id { get { return id; } set { id = value; } }

        public int Tipo { get { return tipo; } set { tipo = value; } }
    }
}
