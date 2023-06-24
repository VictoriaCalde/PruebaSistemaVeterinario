<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDuenno.aspx.cs" Inherits="VeterinariaWeb.frmDuenno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 19px;
        }
        .auto-style2 {
            height: 19px;
            width: 173px;
        }
        .auto-style3 {
            width: 173px;
        }
        .auto-style4 {
            height: 19px;
            width: 207px;
        }
        .auto-style5 {
            width: 207px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">

    <table style="width:100%;">
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style4"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style3">Cédula:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtDuenno_cedula" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Nombre:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtDuenno_nombre" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:DropDownList ID="ddlDuenno" runat="server">
                </asp:DropDownList>
                <asp:Button ID="btnCargarDatosDuenno" runat="server" OnClick="btnCargarDatosDuenno_Click" Text="Cargar Datos" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Apellido:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtDuenno_apellido" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Télefono:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtDuenno_telefono" runat="server" Height="18px" Width="120px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Dirección:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtDuenno_direccion" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="btnInsertar" runat="server" OnClick="btnInsertar_Click" Text="Insertar" Width="62px" />
            </td>
            <td class="auto-style5">
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" />
            </td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
            </td>
        </tr>
    </table>
        <asp:GridView ID="gvDuenno" runat="server">
        </asp:GridView>
        <br />
        <asp:Button ID="btnRegresar" runat="server" Height="26px" OnClick="Button2_Click" Text="Menú principal" />
        <br />
    </form>
</body>
</html>
