<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TPC_Caceres.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
                    <asp:GridView CssClass="table" ID="dgvPrueba" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                        <asp:BoundField HeaderText="Precio" DataField="Precio" />
                        <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-danger" Text="Eliminar" CommandName="Select" />
                    </Columns>

                </asp:GridView>
</asp:Content>
