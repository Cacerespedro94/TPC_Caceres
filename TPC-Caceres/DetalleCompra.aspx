﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleCompra.aspx.cs" Inherits="TPC_Caceres.DetalleCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class=" card-columns mt-5" style="margin-left: 10px; margin-right: 10px;">
        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                <div class="card border-dark">
                    <h3 class="card-title text-center font-weight-bold text-primary"><%#Eval("producto.Nombre")%></h3>
                    <div class="card-body">
                       

                        <h4 class="card-text text-center font-weight-bold  text-danger"> Precio $<%#Eval("producto.Precio")%></h4>
                        <h4 class="card-text text-center font-weight-bold  text-danger">Cantidad<%#Eval("producto.CantidadUnidades")%></h4>
                    </div>
                    <div class="row">
                        <div class="col text-center">
                       
                        </div>
                    </div>
                </div>

            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>