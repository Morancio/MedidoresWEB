using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface ILecturaDAL
    {
        List<Lectura> Obtener();

        void Eliminar(int index);
        void Agregar(Lectura lectura);
        List<Lectura> Filtrar(int idMedidor);
    }
}
