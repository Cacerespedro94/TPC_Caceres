<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPC_Caceres.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .contenedor{
            margin-top: 200px;
            width:300px;
            height: 250px;
            background-color: #CFBA38;
        }
        body{
            background-color: white;
        }
    </style>
    
    <div class="container contenedor">
    <form>
  <div class="form-group">
    <label for="exampleInputEmail1">Usuario</label>
    <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
    <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Contraseña</label>
    <input type="password" class="form-control" id="exampleInputPassword1">
  </div>
        <button type="submit" class="btn btn-primary">Iniciar sesión</button>
 <%-- <div class="form-group form-check">
    <input type="checkbox" class="form-check-input" id="exampleCheck1">
    <label class="form-check-label" for="exampleCheck1">Check me out</label>--%>
  </div>
  
</form>
    </div>    

</asp:Content>
