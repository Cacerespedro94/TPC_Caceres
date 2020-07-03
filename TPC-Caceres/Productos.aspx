<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="TPC_Caceres.Productos" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body {
            margin-top: 20px;
        }

        .Tarjetas {
            width: 200px;
            height: 400px;
        }
        .cardImagen{
            max-height:200px;
            min-height:200px;
            
        }
    </style>

    <asp:TextBox ID="txtBuscador" CssClass="mt-5 ml-5 ml-2 pt-2 pb-2" runat="server" OnTextChanged="Buscador_TextChanged" />
    <asp:Button Text="Buscar" CssClass="btn btn-primary" OnClick="Buscador_TextChanged" runat="server" />

    <div class=" card-columns mt-5  " style="margin-left: 10px; margin-right: 10px;">
        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                <div class="card border-dark Tarjetas">
                    <h3 class="card-title text-center font-weight-bold text-primary"><%#Eval("Nombre")%></h3>
                    <div class="card-body">
                        <div>
                            <img src="<%#Eval("ImagenUrl") %>" class="card-img-top cardImagen" alt="...">
                            <p class="card-text text-center font-weight-bold"><%#Eval("Descripcion")%></p>
                            <h4 class="card-text text-center font-weight-bold  text-danger">$<%#Eval("Precio")%></h4>
                        </div>
                        <div class="row">
                            <div class="col text-center">
                                <asp:Button ID="btnargumento" CssClass="btn btn-success border border-primary rounded-pill mt-3 float-none " Text="Agregar al carrito" CommandArgument='<%#Eval("Id")%>' CommandName="idproducto" runat="server" OnClick="btnargumento_Click" />
                            </div>
                        </div>

                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
