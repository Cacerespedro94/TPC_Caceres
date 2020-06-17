<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="TPC_Caceres.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section id="Formulario">
    <form action="" method="POST" id="formulario" onsubmit="return false">
        <div class="form-group">
          <label for="ImputNombre" class="txtForm">Ingrese su nombre</label>
          <input type="text" class="form-control" id="ImputNombre" placeholder="Escriba su nombre...">
          <span class="Error" id="NombreError"></span>
        </div>

        <div class="form-group">
            <label for="ImputEmail" class="txtForm">Ingrese su email</label>
            <input type="email" class="form-control" id="ImputEmail" placeholder="nombre@ejemplo.com">
            <span class="Error" id="EmailError"></span>
        </div>

        <div class="ImputTexto">
          <label for="txtForm" class="txtForm">Ingrese un mensaje</label>
          <textarea class="form-control" id="ImputTexto" rows="3"></textarea>
          
          <span class="Error" id="TextoError"></span>
        </div>

        <div id="boton"><input type="submit" class="btn btn-primary" value="Enviar" id="submit"> 
        </div>
      </form>
</section>
</asp:Content>
