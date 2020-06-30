<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterAdmin.Master" AutoEventWireup="true" CodeBehind="ProductosAdmin.aspx.cs" Inherits="TPC_Caceres.ProductosAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <a href="AltaProducto.aspx" class="btn btn-success mb-3 float-right ">Nuevo Producto &raquo;</a>
    <a href="#" class="btn btn-success ml-3 mb-3 float-right ">Ajuste de Stock &raquo;</a>


    <asp:GridView CssClass="table" ID="dgvProductosAdmin" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvProductosAdmin_SelectedIndexChanged" OnRowCommand="dgvProductosAdmin_RowCommand">
       
 
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
            <asp:BoundField HeaderText="Precio" DataField="Precio" />
             <asp:BoundField HeaderText="Categoria" DataField="Categoria" />
             <asp:BoundField HeaderText="Sub Categoria" DataField="sub" />
             <asp:BoundField HeaderText="Stock" DataField="Stock" />
             <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-danger" Text="Eliminar" CommandName="Eliminar" />
            <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-primary" Text="Modificar" CommandName="Modificar" />
            
        </Columns>

    </asp:GridView>
   
</asp:Content>
