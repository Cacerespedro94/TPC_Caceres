<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPC_Caceres._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>En Concreto</h1>
        <p class="lead">Trabajando con material noble. Estás a pocos clicks de obtener los productos...</p>
        <p><a href="Productos.aspx" class="btn btn-success btn-lg">Ver Productos &raquo;</a>
            <a href="Login.aspx" class="btn btn-primary btn-lg">Iniciar Sesión &raquo;</a>
        </p>
        
    </div>
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
            <span class="Error" id="EmailError"></spand>
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
    <div class="row">
        <div class="col-md-4">
            <h2>Sobre nosotros</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Redes</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Dirección</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
