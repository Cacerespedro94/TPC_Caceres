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



  <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Nombre</label>
        <asp:TextBox ID="NombreBox" CssClass="form-control" runat="server" typeMode="text" name="login_email"  pattern=".{3,}" title="Tres(3) o mas caracteres" required="" />  
         
     </div>  
      </div>

          <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Apellido</label>
        <asp:TextBox ID="ApellidoBox" CssClass="form-control" runat="server" typeMode="text" name="login_email"  pattern=".{2,}" title="Dos(2) o mas caracteres" required="" />  
         
     </div>  
      </div>

                <div class="col-6">
                <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Email</label>
        <asp:TextBox ID="NombreUsuarioBox" CssClass="form-control" TextMode="Email" runat="server" pattern=".{4,}" title="Cuatro(4) o mas caracteres" required="" />  
          </div>
     </div>  
      
          <div class="form-row">
    <div class="col-md-6 mb-3">
      <label for="validationCustom01">Contraseña</label>
        <asp:TextBox ID="ContraseñaBox" CssClass="form-control" runat="server" pattern=".{4,}" title="Cuatro(4) o mas caracteres" required=""  />  
         </div>
         </div>
          </div>
        

                <div class="form-row agregar">
        <asp:Button ID="Agregar" CssClass="btn btn-primary " Text="Agregar" runat="server" OnClick="Agregar_Click" />
            </div>
                </div>
       
  

    </div>

</asp:Content>
