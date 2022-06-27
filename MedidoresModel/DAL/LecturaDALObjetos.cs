using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class LecturaDALObjetos : ILecturaDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();

        public void Agregar(Lectura lectura)
        {
            lecturas.Add(lectura);
        }

        public void Eliminar(int index)
        {
            lecturas.Remove(lecturas[index]);
        }

        public List<Lectura> Obtener()
        {
            return lecturas;
        }

        public List<Lectura> Filtrar(int idMedidor)
        {
            return lecturas.FindAll(l => l.IdMedidor == idMedidor);
        }
    }
}
