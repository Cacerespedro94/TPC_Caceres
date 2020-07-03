<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TPC_Caceres.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        body {
            margin-top: 70px;
        }

        .oculto {
            display: none;
        }

        .LABEL {
            font-size: 18px;
        }

        .btnSeguir {
       position: relative;
       left:84.5%;
        }
    </style>
    <div runat="server" id="CarroVacio" >
    <h1 class="ml-5 text-light">Todavía no tienes nada en tu carrito...</h1>
        </div>
    <div class="container mt-5">
        <div class="row">
            <div class="col-sm-9 ">
                <asp:GridView CssClass="table bg-light" ID="dgvCarrito" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvCarrito_SelectedIndexChanged" OnRowCommand="dgvCarrito_RowCommand">
                    <Columns>
                        
                        <asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                        <asp:BoundField HeaderText="Precio" DataField="Precio" />
                        <asp:ButtonField HeaderText="Disminuir" ButtonType="Link" ControlStyle-CssClass="btn btn-secondary" Text="-" CommandName="Restar" />
                        <asp:BoundField HeaderText="Cantidad" DataField="CantidadUnidades" />
                        <asp:ButtonField HeaderText="Agregar" ButtonType="Link" ControlStyle-CssClass="btn btn-secondary" Text="+" CommandName="Agregar" />

                        <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-danger" Text="Eliminar" CommandName="Select" />
                    </Columns>

                </asp:GridView>
            </div>
            <div class="col-sm-3">
                <div id="Tarjeta">
                    <div class="row">
                        <div class="col text-center">
                            <div class="card text-white bg-primary mb-3 mx-auto" style="max-width: 20rem;">
                                <div class="card-header font-weight-bold LABEL">Detalle de compra</div>
                                <div class="card-body">
                                    <asp:Label ID="CanUni" CssClass="card-text LABEL" Text="" runat="server" />
                                    <h3 class="card-title font-weight-bold text-center">Precio final</h3>

                                    <asp:Label ID="Total" CssClass="card-text align-items-center LABEL" Text="" runat="server" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
  
            
            <asp:Button OnClick="btnSeguir_Click" Cssclass="btn btn-success btnSeguir" id="btnSeguir" Text="Comprar" runat="server" />
            
           
    

    </div>


    <script>
        var PrecioTotal = <%=prue.SubTotal%>;
        if (PrecioTotal > 0) {
            document.getElementById("Tarjeta").style.display = "block";
        }
        else {
            
            document.getElementById("Tarjeta").style.display = "none";
        }
    </script>
</asp:Content>
