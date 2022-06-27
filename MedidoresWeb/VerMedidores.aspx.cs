using MedidoresModel.DAL;
using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresWeb
{
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrilla();
            }

        }

        protected void CargarGrilla()
        {
            List<Medidor> medidores = medidorDAL.Obtener();
            this.medidoresGV.DataSource = medidores;
            this.medidoresGV.DataBind();
        }

        protected void CargarGrilla(List<Medidor> filtrada)
        {
            List<Medidor> clientes = medidorDAL.Obtener();
            this.medidoresGV.DataSource = filtrada;
            this.medidoresGV.DataBind();
        }

        protected void TipoDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tipoDDL.SelectedItem != null)
            {
                int tipo = Convert.ToInt32(this.tipoDDL.SelectedItem.Value);

                if (tipo == 0)
                {
                    CargarGrilla();
                }
                else
                {
                    List<Medidor> filtrada = medidorDAL.Filtrar(tipo);
                    CargarGrilla(filtrada);
                }
            }
        }
    }
}