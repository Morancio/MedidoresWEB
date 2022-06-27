<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="MedidoresWeb.VerLecturas" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLBL" CssClass="text-success"></asp:Label>
            </div>
            <div>
                <label for="medidorDDL">Medidor</label>
                <asp:DropDownList AutoPostBack="true" runat="server" ID="medidorDDL" CssClass="form-select" OnSelectedIndexChanged="MedidorDDL_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div>
                <asp:GridView CssClass="table table-hover table-bordered mt-5"
                    AutoGenerateColumns="false"
                    EmptyDataText="No hay Lecturas"
                    ShowHeader="true"
                    runat="server" ID="lecturasGV">
                    <Columns>
                        <asp:BoundField DataField="IdMedidor" HeaderText="Id Medidor" />
                        <asp:BoundField DataField="Fecha" HeaderText="Fecha Lectura" />
                        <asp:BoundField DataField="Valor" HeaderText="Valor Lectura" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
