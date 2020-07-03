<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPC_Caceres._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
    .Presentacion{
        /*margin-left:10%;
   margin-right: 100px;*/
       background-color:#82482B;
       border-radius: 15px;
       

    }
   body{
       background-color:#090a1d;
   }
    .Formato{

        
    }
    /*.Concreto{
        background-color:#58351D;
    }*/
    .Formu{
        background-color:#82652B;
        border-radius: 15px;
    }
    .Nosotros{
        background-color:#B07B3B;
        border-radius: 15px;
    }
    .Grupo{
        position:relative;
        margin-left: 25%;
    }
    .Nombre{
       position: relative;
       right:10px;
    }
}

</style>
    
    <div class="container Concreto ">        
    <div class="jumbotron Presentacion">
        <h1 class=" text-light">En Concreto</h1>
        <p class="lead text-light">Trabajando con material noble. Estás a pocos clicks de obtener los productos...</p>
        <p><a runat="server" id="btnVerProductos" href="Productos.aspx" class="btn btn-success btn-lg">Ver Productos &raquo;</a>
            <a runat="server" id="btnIniciarSesion" href="Login.aspx" class="btn btn-primary btn-lg">Iniciar Sesión &raquo;</a>
            <a runat="server" id="btnCrearUsuario" href="CrearCuenta.aspx" class="btn btn-info btn-lg">Registrarse &raquo;</a>
        </p>
        
        </div>
        </div>
    <div class="Formu">     
<div class="form-horizontal Grupo  " >
    <div class="form-group ">
    
  <div class="Formulario mt-3">
  <label for="name" class="col-sm-2 mb-3 control-label text-light">Nombre</label>
  <div class="col-sm-10">
   <input type="text" class="form-control mb-3 Nombre" id="name" name="name" placeholder="Nombre y Apellido" value="">
  </div>
 </div>
 <div class="form-group">
  <label for="email" class="col-sm-2 control-label text-light ">Email</label>
  <div class="col-sm-10">
   <input type="email" class="form-control" id="email" name="email" placeholder="ejemplo@email.com" value="">
  </div>
 </div>
 <div class="form-group">
  <label for="message" class="col-sm-2 control-label text-light">Mensaje</label>
  <div class="col-sm-10">
   <textarea class="form-control" rows="4" name="message"></textarea>
  </div>
 </div>
 
 <div class="form-group">
  <div class="col-sm-10 col-sm-offset-2">
   <input id="submit" name="submit" type="submit" value="Send" class="btn btn-primary">
  </div>
 </div>
 <div class="form-group">
  <div class="col-sm-10 col-sm-offset-2">
   <! Will be used to display an alert to the user>
  </div>
 </div>
</div>
    </div>
        </div>
    <div class="Nosotros pt-5  mt-3">
        <div class="container ">
    <div class="row pb-5">
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
    </div>
    </div>
</asp:Content>
