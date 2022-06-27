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
    public partial class VerLecturas : System.Web.UI.Page
    {
        private ILecturaDAL lecturaDAL = new LecturaDALObjetos();
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrilla();

                List<Medidor> medidores = medidorDAL.Obtener();
                this.medidorDDL.DataSource = medidores;
                this.medidorDDL.DataTextField  = "Id";
                this.medidorDDL.DataBind();
                this.medidorDDL.Items.Insert(0, "Todos");
            }

        }

        protected void CargarGrilla()
        {
            List<Lectura> lecturas = lecturaDAL.Obtener();
            this.lecturasGV.DataSource = lecturas;
            this.lecturasGV.DataBind();
        }

        protected void CargarGrilla(List<Lectura> filtrada)
        {
            List<Lectura> lecturas = lecturaDAL.Obtener();
            this.lecturasGV.DataSource = filtrada;
            this.lecturasGV.DataBind();
        }

        protected void MedidorDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.medidorDDL.SelectedItem != null)
            {
                if(medidorDDL.SelectedItem.Text == "Todos")
                {
                    CargarGrilla();
                }
                else
                {
                    int idMedidor = Convert.ToInt32(this.medidorDDL.SelectedItem.Text);
                    List<Lectura> filtrada = lecturaDAL.Filtrar(idMedidor);
                    CargarGrilla(filtrada);
                }
            }
        }
    }
}