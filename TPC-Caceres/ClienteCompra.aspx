<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClienteCompra.aspx.cs" Inherits="TPC_Caceres.ClienteCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


<%--   <asp:GridView CssClass="table bg-light" Id="DgvClienteVenta" runat="server" AutoGenerateColumns="false">
                    <Columns>--%>

                        <%--<asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />--%>
<%--                        <asp:BoundField HeaderText="Id" DataField="Id" />
                        <asp:BoundField HeaderText="Nombre" DataField="producto.Nombre" />
                        <asp:BoundField HeaderText="Fecha" DataField="fecha" />
                        <asp:BoundField HeaderText="Cantidad" DataField="producto.CantidadUnidades" />
                        <asp:BoundField HeaderText="Precio" DataField="producto.Precio" />--%>
<%--                        <asp:ButtonField HeaderText="Disminuir" ButtonType="Link" ControlStyle-CssClass="btn btn-secondary" Text="-" CommandName="Restar" />
                        <asp:BoundField HeaderText="Cantidad" DataField="CantidadUnidades" />
                        <asp:ButtonField HeaderText="Agregar" ButtonType="Link" ControlStyle-CssClass="btn btn-secondary" Text="+" CommandName="Agregar" />--%>

<%--                        <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-danger" Text="Eliminar" CommandName="Select" />--%>
<%--                    </Columns>



                </asp:GridView>--%>

       <asp:GridView CssClass="table bg-light" Id="DgvCompra" runat="server" AutoGenerateColumns="false" OnRowCommand="DgvCompra_RowCommand" OnSelectedIndexChanged="DgvCompra_SelectedIndexChanged">
                    <Columns>

                        <%--<asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />--%>
                        <asp:BoundField HeaderText="Id" DataField="Id" />
                        <asp:BoundField HeaderText="Fecha" DataField="fecha" />
                        <asp:BoundField HeaderText="Cantidad de Unidades" DataField="carro.Cantidad" />
                        <asp:BoundField HeaderText="Total abonado" DataField="carro.SubTotal" />
              

                   
                        <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-secondary" Text="Ver Detalle" CommandName="Detalle" />


                    </Columns>



                </asp:GridView>


 </asp:Content>
