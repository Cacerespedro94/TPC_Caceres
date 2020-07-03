<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPC_Caceres.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .contenedor{
            margin-top: 50px;
            width:310px;
            height: 350px;
            background-color: #CFBA38;
        }
        body{
            background-color: white;
        }
    </style>
       <div>
    <div class="container contenedor">
     
  <div class="form-group">
    <label class="mt-3" for="exampleInputEmail1">Email</label>
      <asp:TextBox  TextMode="Email" Cssclass="form-control " ID="EmailBox" runat="server" />
    
    <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Contraseña</label>
    <asp:TextBox TextMode="Password"  Cssclass="form-control" ID="ContraseñaBox" runat="server" />
  </div>
        <asp:Label ID="lblError"  Text="" runat="server" />
             <asp:Button Cssclass="btn btn-primary"   Text="Iniciar sesión" runat="server" ID="btnIniciarSesion" OnClick="btnIniciarSesion_Click" />


 <%-- <div class="form-group form-check">
    <input type="checkbox" class="form-check-input" id="exampleCheck1">
    <label class="form-check-label" for="exampleCheck1">Check me out</label>--%>
  </div>
  

    </div>    

</asp:Content>
