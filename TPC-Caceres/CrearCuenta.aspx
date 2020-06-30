<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearCuenta.aspx.cs" Inherits="TPC_Caceres.CrearCuenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
  body{
      margin-top:50px;

  }
  .agregar{
      margin-left: 660px;
  }
    </style>

    <div class="container">
        <div class="row">
            <div class="col-6">

  <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Nombre</label>
        <asp:TextBox ID="NombreBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>

          <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Apellido</label>
        <asp:TextBox ID="ApellidoBox" CssClass="form-control" runat="server" />  
         
     </div>  
      </div>
          <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">DNI</label>
        <asp:TextBox ID="DniBox" CssClass="form-control" runat="server" /> 
            </div>
 
     </div>  
      </div>
                <div class="col-6">
                <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Nombre de Usuario</label>
        <asp:TextBox ID="NombreUsuarioBox" CssClass="form-control" runat="server" />  
          </div>
     </div>  
      
          <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Contraseña</label>
        <asp:TextBox ID="ContraseñaBox" CssClass="form-control" runat="server" />  
         </div>
         </div>
          </div>
        
                <div class="form-row agregar">
        <asp:Button ID="Agregar" CssClass="btn btn-primary " Text="Agregar" runat="server" OnClick="Agregar_Click" />
            </div>
                </div>
       
  

    </div>

</asp:Content>
