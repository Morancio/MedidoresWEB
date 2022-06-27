<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="MedidoresWeb.VerMedidores" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLBL" CssClass="text-success"></asp:Label>
            </div>
            <div>
                <label for="tipoDDL">Tipo de Medidor</label>
                <asp:DropDownList AutoPostBack="true" runat="server" ID="tipoDDL" OnSelectedIndexChanged="TipoDDL_SelectedIndexChanged">
                    <asp:ListItem Value="0" Text="Todos"></asp:ListItem>
                    <asp:ListItem Value="1" Text="Luz"></asp:ListItem>
                    <asp:ListItem Value="2" Text="Agua"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <asp:GridView CssClass="table table-hover table-bordered mt-5"
                    AutoGenerateColumns="false"
                    EmptyDataText="No hay Medidores"
                    ShowHeader="true"
                    runat="server" ID="medidoresGV">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id Medidor" />
                        <asp:BoundField DataField="TipoTXT" HeaderText="Tipo Medidor" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
