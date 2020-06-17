<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="TPC_Caceres.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class=" card-columns mt-5" style="margin-left: 10px; margin-right: 10px;">
        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                <div class="card border-dark">
                    <h3 class="card-title text-center font-weight-bold text-primary"><%#Eval("Nombre")%></h3>
                    <div class="card-body">
                        <img src="<%#Eval("ImagenUrl") %>" class="card-img-top" alt="...">
                        <p class="card-text text-center font-weight-bold"><%#Eval("Descripcion")%></p>
                        <h4 class="card-text text-center font-weight-bold  text-danger">$<%#Eval("Precio")%></h4>
                    </div>
                    <div class="row">
                        <%--<div class="col text-center">
                            <asp:Button ID="btnargumento" CssClass="btn btn-success border border-primary rounded-pill mb-3 float-none " Text="Agregar al carrito" CommandArgument='<%#Eval("Id")%>' CommandName="idproducto" runat="server" OnClick="btnargumento_click" />
                        </div>--%>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
