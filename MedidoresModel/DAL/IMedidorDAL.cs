using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface IMedidorDAL
    {
        List<Medidor> Obtener();

        void Agregar(Medidor medidor);

        List<Medidor> Filtrar(int nivel);

        Medidor Buscar(int id);
    }
}
