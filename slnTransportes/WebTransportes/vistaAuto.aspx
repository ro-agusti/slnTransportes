<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vistaAuto.aspx.cs" Inherits="WebTransportes.vistaAuto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <br />
            <asp:Label ID="lblMarca" runat="server" Text="Marca"></asp:Label>
            <asp:DropDownList ID="ddMarca" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddMarca_SelectedIndexChanged"></asp:DropDownList>
            <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblModelo" runat="server" Text="Modelo"></asp:Label>
            <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblMatricula" runat="server" Text="Matricula"></asp:Label>
            <asp:TextBox ID="txtMatricula" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrecio" runat="server" Text="Precio"></asp:Label>
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnGuardar" runat="server" Text="GUARDAR" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnEditar" runat="server" Text="EDITAR" OnClick="btnEditar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="ELIMINAR" OnClick="btnEliminar_Click" />
            <br />
            <br />
            <asp:Label ID="lblId" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblFiltrarMarca" runat="server" Text="Filtrar por Marca"></asp:Label>
            <asp:DropDownList ID="ddFiltrarMarca" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddFiltrarMarca_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="gridAutos" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
