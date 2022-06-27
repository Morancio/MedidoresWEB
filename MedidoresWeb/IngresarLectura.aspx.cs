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
    public partial class IngresarLectura : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        private ILecturaDAL lecturaDAL = new LecturaDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidores = medidorDAL.Obtener();
                this.medidorDDL.DataSource = medidores;
                this.medidorDDL.DataValueField = "Id";
                this.medidorDDL.DataTextField = "Id";
                this.medidorDDL.DataBind();
                this.medidorDDL.Items.Insert(0, "Seleccione Medidor");
            }
        }

        protected void CalendarValidation(object sender, ServerValidateEventArgs args)
        {
            if (this.fechaDTP.SelectedDate == DateTime.MinValue)
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
            
            int.TryParse(this.medidorDDL.SelectedItem.Text.Trim(), out int idMedidor);

            DateTime fecha = this.fechaDTP.SelectedDate;
            int.TryParse(this.horaTXT.Text.Trim(), out int hora);
            int.TryParse(this.minutoTXT.Text.Trim(), out int minuto);

            if (fecha == DateTime.MinValue)
            {
                return;
            }

            TimeSpan ts = new TimeSpan(hora, minuto, 0);
            fecha = fecha.Add(ts);

            int.TryParse(this.lecturaTXT.Text.Trim(), out int valor);

            Lectura lectura = new Lectura()
            {
                IdMedidor = idMedidor,
                Fecha = fecha,
                Valor = valor
            };

            lecturaDAL.Agregar(lectura);
            this.mensajesLBL.Text = "Lectura Ingresada";
            Response.Redirect("VerLecturas.aspx");
        }
    }
}