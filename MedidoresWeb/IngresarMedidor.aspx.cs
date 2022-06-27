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
    public partial class IngresarMedidor : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckInput(object source, ServerValidateEventArgs args)
        {
            int.TryParse(this.idTXT.Text.Trim(), out int id);
            if (id == 0)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void SaveBTN_Click(object sender, EventArgs e)
        {
            int.TryParse(this.idTXT.Text.Trim(), out int id);
            int.TryParse(this.tipoDDL.SelectedValue, out int tipo);

            Medidor medidor = new Medidor()
            {
                Id = id,
                Tipo = tipo
            };

            if (medidorDAL.Buscar(id) != null)
            {
                this.mensajesLBL.Text = "Medidor ya existe";
                return;
            }

            if (id == 0)
            {
                return;
            }
            medidorDAL.Agregar(medidor);
            this.mensajesLBL.Text = "Medidor ingresado";
            Response.Redirect("VerMedidores.aspx");
        }
    }
}