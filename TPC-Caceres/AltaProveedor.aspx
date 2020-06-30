<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterAdmin.Master" AutoEventWireup="true" CodeBehind="AltaProveedor.aspx.cs" Inherits="TPC_Caceres.AltaProveedor" %>
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
      <label for="validationCustom01">Calle</label>
        <asp:TextBox ID="CalleBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>

         <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Altura</label>
        <asp:TextBox ID="AlturaBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>

         <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Codigo Postal</label>
        <asp:TextBox ID="CodigoBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>

         <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Provincia</label>
        <asp:TextBox ID="ProvinciaBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>

         <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Localidad</label>
        <asp:TextBox ID="LocalidadBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>

         <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Email</label>
        <asp:TextBox ID="EmailBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>

         <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Telefono</label>
        <asp:TextBox ID="TelefonoBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>
        <asp:Button ID="Agregar" CssClass="btn btn-primary" Text="Agregar" runat="server" OnClick="Agregar_Click" />
  
</div>
</asp:Content>
