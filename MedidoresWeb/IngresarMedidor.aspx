<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarMedidor.aspx.cs" Inherits="MedidoresWeb.IngresarMedidor" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLBL" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Ingresar Medidor</h3>
                </div>

                <div class="card-body">
                    <div class="form-group">
                        <label for="idTXT">ID Medidor</label>
                        <asp:TextBox ID="idTXT" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="idRFV" runat="server" ControlToValidate="idTXT" ErrorMessage="Ingrese una ID" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CustomValidator ID="idCV" runat="server" ControlToValidate="idTXT" ErrorMessage="Ingrese un valor númerico o distinto de 0" ForeColor="Red" OnServerValidate="CheckInput"></asp:CustomValidator>
                    </div>

                    <div class="form-group">
                        <label for="tipoDDL">Tipo</label>
                        <asp:DropDownList runat="server" ID="tipoDDL" CssClass="form-select">
                            <asp:ListItem Value="1" Text="Luz"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Agua"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Button runat="server" ID="saveBTN" OnClick="SaveBTN_Click" Text="Guardar" CssClass="btn btn-primary " />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

