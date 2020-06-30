<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterAdmin.Master" AutoEventWireup="true" CodeBehind="ClienteVista.aspx.cs" Inherits="TPC_Caceres.ClienteVista" %>


   <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <a href="AltaProducto.aspx" class="btn btn-success mb-3 float-right ">Nuevo Cliente &raquo;</a>
    <asp:GridView CssClass="table" ID="dgvClientes" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvClientes_SelectedIndexChanged" OnRowCommand="dgvClientes_RowCommand">
       
 
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
<%--            <asp:BoundField HeaderText="DNI" DataField="Dni" />--%>
            <asp:BoundField HeaderText="Usuario" DataField="User.Login" />
<%--             <asp:BoundField HeaderText="Localidad" DataField="direccion.Localidad" />
            <asp:BoundField HeaderText="Provincia" DataField="direccion.Provincia" />
             <asp:BoundField HeaderText="Email" DataField="contacto.Email" />
            <asp:BoundField HeaderText="Telefono" DataField="contacto.Telefono" />--%>
            <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-danger" Text="Eliminar" CommandName="Eliminar" />
            <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-primary" Text="Modificar" CommandName="Modificar" />
            
        </Columns>

    </asp:GridView>

</asp:Content>
