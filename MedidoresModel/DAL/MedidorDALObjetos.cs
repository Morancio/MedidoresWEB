using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class MedidorDALObjetos : IMedidorDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();

        public void Agregar(Medidor medidor)
        {
           medidores.Add(medidor);
        }

        public List<Medidor> Obtener()
        {
            return medidores;
        }

        public List<Medidor> Filtrar(int tipo)
        {
            return medidores.FindAll(m => m.Tipo == tipo);
        }

        public Medidor Buscar(int id)
        {
            return medidores.Find(m => m.Id == id);
        }
    }
}
