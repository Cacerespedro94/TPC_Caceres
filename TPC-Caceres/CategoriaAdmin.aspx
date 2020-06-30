<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterAdmin.Master" AutoEventWireup="true" CodeBehind="CategoriaAdmin.aspx.cs" Inherits="TPC_Caceres.CategoriaAdmin" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <style>

</style>
                      <div class="form-row">
<%--         <button onclick="Probando()" onload="ComprobarLoad()" class= "btn btn-primary"  >CLICK ACA</button>--%>
      <div onload="ComprobarLoad()" id="AgregarCategoria" class="col-md-6 mb-3">
      <label for="validationCustom01">Nombre de Categoria</label>
        <asp:TextBox ID="CategoriaBox" CssClass="form-control" runat="server" />  
        <asp:Button id="btnAgregar" CssClass="btn btn-primary mt-2" Text="Nueva Categoria" runat="server" OnClick="btnAgregar_Click"  />
         </div>  
      </div>
        <asp:GridView CssClass="table" ID="dgvCategorias" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvCategorias_SelectedIndexChanged" OnRowCommand="dgvCategorias_RowCommand">
       
 
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />

            <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-danger" Text="Eliminar" CommandName="Eliminar" />
            <asp:ButtonField HeaderText="" ButtonType="Link" ControlStyle-CssClass="btn btn-primary" Text="Modificar" CommandName="Modificar" />
            
        </Columns>

    </asp:GridView>

    <script>
        function ComprobarLoad() {

            if (<%=(Page.IsPostBack).ToString().ToLower()%>) {
                var AgregarCategoria = document.getElementById("AgregarCategoria");
                AgregarCategoria.style.display = "block";
            }

        }
        function Probando() {
            var AgregarCategoria = document.getElementById("AgregarCategoria");
            AgregarCategoria.style.display = "block";
        }

 
    </script>
</asp:Content>