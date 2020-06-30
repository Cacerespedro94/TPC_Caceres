<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterAdmin.Master" AutoEventWireup="true" CodeBehind="ventasAdmin.aspx.cs" Inherits="TPC_Caceres.ventasAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
                body {
            margin-top: 70px;
        }
    </style>
           <asp:GridView CssClass="table bg-light" Id="DgvVenta" runat="server" AutoGenerateColumns="false" OnRowCommand="DgvVenta_RowCommand" OnSelectedIndexChanged="DgvVenta_SelectedIndexChanged">
                    <Columns>

                        <%--<asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />--%>
                        <asp:BoundField HeaderText="Id" DataField="Id" />
                        <asp:BoundField HeaderText="Apellido" DataField="cliente.Apellido" />
                        <asp:BoundField HeaderText="Nombre" DataField="cliente.Nombre" />
                        <asp:BoundField HeaderText="Total Abonado" DataField="carro.SubTotal " />
                        <asp:BoundField HeaderText="Cantidad Unidades" DataField="carro.Cantidad " />
                        <asp:BoundField HeaderText="Fecha" DataField="fecha" />
                        
                                                                 
                        
                        <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-secondary" Text="Ver Detalle" CommandName="Detalle" />
                   
                    </Columns>
           
           </asp:GridView>


</asp:Content>
