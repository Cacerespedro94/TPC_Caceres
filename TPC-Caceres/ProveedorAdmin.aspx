<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterAdmin.Master" AutoEventWireup="true" CodeBehind="ProveedorAdmin.aspx.cs" Inherits="TPC_Caceres.ProveedorAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <a href="AltaProveedor.aspx" class="btn btn-success mb-3 float-right ">Nuevo Proveedor &raquo;</a>
    <asp:GridView CssClass="table" ID="dgvProveedores" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvProveedores_SelectedIndexChanged" OnRowCommand="dgvProveedores_RowCommand">
       
 
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Localidad" DataField="direccion.Localidad" />
            <asp:BoundField HeaderText="Provincia" DataField="direccion.Provincia" />
             <asp:BoundField HeaderText="Email" DataField="contacto.Email" />
            <asp:BoundField HeaderText="Telefono" DataField="contacto.Telefono" />
            <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-danger" Text="Eliminar" CommandName="Eliminar" />
            <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-primary" Text="Modificar" CommandName="Modificar" />
            
        </Columns>

    </asp:GridView>
</asp:Content>
