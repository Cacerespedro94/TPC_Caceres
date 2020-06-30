<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterAdmin.Master" AutoEventWireup="true" CodeBehind="MateriaPrimaAdmin.aspx.cs" Inherits="TPC_Caceres.MateriaPrimaAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
           <a href="AltaMaterial.aspx" class="btn btn-success mb-3 float-right ">Nuevo Material &raquo;</a>
    <asp:GridView CssClass="table" ID="dgvMaterial" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvMaterial_SelectedIndexChanged" OnRowCommand="dgvMaterial_RowCommand">
       
 
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
            <asp:BoundField HeaderText="Proveedor" DataField="proveedor.Nombre" />
            <asp:BoundField HeaderText="Stock" DataField="Stock" />
            <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-danger" Text="Eliminar" CommandName="Eliminar" />
            <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-primary" Text="Modificar" CommandName="Modificar" />
            
        </Columns>

    </asp:GridView>

</asp:Content>
