<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterAdmin.Master" AutoEventWireup="true" CodeBehind="AltaMaterial.aspx.cs" Inherits="TPC_Caceres.AltaMaterial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <div>
  <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Nombre</label>
        <asp:TextBox ID="NombreBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>


 
          <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Descripcion</label>
        <asp:TextBox ID="DescripcionBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>

         <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Id Proveedor</label>
        <asp:TextBox ID="ProveedorBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>

         <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Cantidad</label>
        <asp:TextBox ID="StockBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>

        <asp:Button ID="Agregar" CssClass="btn btn-primary" Text="Agregar" runat="server" OnClick="Agregar_Click" />
  
</div>
</asp:Content>
