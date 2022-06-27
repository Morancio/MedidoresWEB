<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarLectura.aspx.cs" Inherits="MedidoresWeb.IngresarLectura" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLBL" CssClass="text-success"></asp:Label>
            </div>

            <div class="card">

                <div class="card-header bg-dark text-white">
                    <h3>Ingresar Lectura</h3>
                </div>

                <div class="card-body">
                    <div class="form-group">
                        <label for="medidorDDL">Medidor</label>
                        <asp:DropDownList runat="server" ID="medidorDDL" CssClass="form-select"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="medidorRFV" runat="server" ControlToValidate="medidorDDL" InitialValue="Seleccione Medidor" ErrorMessage="Seleccione un medidor" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <label for="fechaDTP">Fecha</label>
                        <asp:Calendar ID="fechaDTP" runat="server"></asp:Calendar>
                        <asp:CustomValidator ID="fechaCV" runat="server" ErrorMessage="Seleccione una fecha" ForeColor="Red" OnServerValidate="CalendarValidation"></asp:CustomValidator>
                    </div>

                    <div class="form-group">
                        <label for="horaTXT">Hora</label>
                        <asp:TextBox ID="horaTXT" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="horaRFV" runat="server" ControlToValidate="horaTXT" ErrorMessage="Ingrese la hora" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="horaRV" runat="server" ControlToValidate="horaTXT" ErrorMessage="El valor debe ser entre 0 y 24" ForeColor="Red" Type="Integer" MinimumValue="0" MaximumValue="24"></asp:RangeValidator>
                    </div>

                    <div class="form-group">
                        <label for="minutoTXT">Minuto</label>
                        <asp:TextBox ID="minutoTXT" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="minutoRFV" runat="server" ControlToValidate="minutoTXT" ErrorMessage="Ingrese los minutos" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="minutoRV" runat="server" ControlToValidate="minutoTXT" ErrorMessage="El valor debe ser entre 0 y 59" ForeColor="Red" Type="Integer" MinimumValue="0" MaximumValue="59"></asp:RangeValidator>
                    </div>

                    <div class="form-group">
                        <label for="lecturaTXT">Lectura</label>
                        <asp:TextBox ID="lecturaTXT" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="lecturaRFV" runat="server" ControlToValidate="lecturaTXT" ErrorMessage="Ingrese el valor de lectura" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="lecturaRV" runat="server" ControlToValidate="lecturaTXT" ErrorMessage="El valor debe ser entre 0 y 600" ForeColor="Red" Type="Integer" MinimumValue="0" MaximumValue="600"></asp:RangeValidator>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Button runat="server" ID="saveBTN" OnClick="SaveBTN_Click" Text="Guardar" CssClass="btn btn-primary " />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
