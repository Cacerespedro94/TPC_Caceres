﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterAdmin.Master" AutoEventWireup="true" CodeBehind="AltaProducto.aspx.cs" Inherits="TPC_Caceres.AltaProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form class="needs-validation" novalidate>
  <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Nombre</label>
        <asp:TextBox ID="Nombrebox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>

          <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Descripcion</label>
        <asp:TextBox ID="DescBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>
          <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Categoria</label>
        <asp:TextBox ID="CategoriaBox" CssClass="form-control" runat="server" /> 
         <asp:DropDownList ID="cboCategoria" runat="server">
        
    </asp:DropDownList>
         
     </div>  
      </div>
                <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">SubCategoria</label>
        <asp:TextBox ID="SubBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>
          <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Precio</label>
        <asp:TextBox ID="PrecioBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>
          <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Imagen</label>
        <asp:TextBox ID="ImagenBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>
        <asp:Button CssClass="btn btn-primary" Text="Agregar" runat="server" OnClick="Agregar_Click"  />
  
</form>

</asp:Content>
