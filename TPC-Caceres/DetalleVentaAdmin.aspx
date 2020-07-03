<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterAdmin.Master" AutoEventWireup="true" CodeBehind="DetalleVentaAdmin.aspx.cs" Inherits="TPC_Caceres.DetalleVentaAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <style>
                .Tarjetas {
            width: 200px;
            height: 400px;
        }
        .cardImagen{
            max-height:200px;
            min-height:200px;
            
        }
    </style>
        <div class=" card-columns mt-5" style="margin-left: 10px; margin-right: 10px;">
        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
<%--                <div class="card border-dark">
                    <h3 class="card-title text-center font-weight-bold text-primary"><%#Eval("producto.Nombre")%></h3>
                    <div class="card-body">
                       

                        <h4 class="card-text text-center font-weight-bold  text-danger"> Precio $<%#Eval("producto.Precio")%></h4>
                        <h4 class="card-text text-center font-weight-bold  text-danger">Cantidad<%#Eval("producto.CantidadUnidades")%></h4>
                    </div>
                    <div class="row">
                        <div class="col text-center">
                       
                        </div>
                    </div>
                </div>--%>
                                <div class="card border-dark Tarjetas">
                    <h3 class="card-title text-center font-weight-bold text-primary"><%#Eval("producto.Nombre")%></h3>
                    <div class="card-body">
                        <div>
                            <img src="<%#Eval("producto.ImagenUrl") %>" class="card-img-top cardImagen" alt="...">
                            <p class="card-text text-center font-weight-bold"><%#Eval("producto.Descripcion")%></p>
                            <h4 class="card-text text-center font-weight-bold mt-5 text-danger">$<%#Eval("producto.Precio")%></h4>
                        </div>
                        <div class="row">
                            <div class="col text-center">
                                  <h4 class="card-text text-center font-weight-bold text-success mt-3"> Lleva <%#Eval("producto.CantidadUnidades")%> unid.</h4>

                            </div>
                        </div>

                    </div>
                </div>

            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
