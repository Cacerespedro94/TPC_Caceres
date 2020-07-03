<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterAdmin.Master" AutoEventWireup="true" CodeBehind="ventasAdmin.aspx.cs" Inherits="TPC_Caceres.ventasAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        body {
            margin-top: 10px;
        }
    </style>
    <div class="float-left mb-3">
        <asp:TextBox ID="txtBuscador" CssClass=" pt-2 pb-2" runat="server" OnTextChanged="Buscador_TextChanged" />
        <asp:Button Text="Buscar" CssClass="btn btn-primary" OnClick="Buscador_TextChanged" runat="server" />
    </div>
    <div id="print">
    <asp:GridView CssClass="table bg-light" ID="DgvVenta" runat="server" AutoGenerateColumns="false" OnRowCommand="DgvVenta_RowCommand" OnSelectedIndexChanged="DgvVenta_SelectedIndexChanged">
        <Columns>

            <%--<asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />--%>
            <asp:BoundField HeaderText="Id" DataField="Id" />
            <asp:BoundField HeaderText="Apellido" DataField="cliente.Apellido" />
            <asp:BoundField HeaderText="Nombre" DataField="cliente.Nombre" />
            <asp:BoundField HeaderText="Total Abonado" DataField="carro.SubTotal " />
            <asp:BoundField HeaderText="Cantidad Unidades" DataField="carro.Cantidad " />
            <asp:BoundField DataFormatString="{0:d}" HeaderText="Fecha" DataField="fecha" />

            <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-secondary" Text="Ver Detalle" CommandName="Detalle" />

        </Columns>

    </asp:GridView>
        </div>
   
    

</asp:Content>
