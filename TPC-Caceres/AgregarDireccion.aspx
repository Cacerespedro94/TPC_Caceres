﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarDireccion.aspx.cs" Inherits="TPC_Caceres.AgregarDireccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">  
        <h1>Agregar dirección</h1>
        <div class="row">
            <div class="col-6">
    <div class="form-row">

                  <div class="col-md-6 mb-3">
      <label for="validationCustom01">Dni</label>
        <asp:TextBox ID="DniBox" CssClass="form-control" runat="server" />  
         
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
                </div>
            <div class="col-6">
         <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Localidad</label>
        <asp:TextBox ID="LocalidadBox" CssClass="form-control" runat="server" />  
         
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
        </div>
        </div>
</asp:Content>
