<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Laboratorio2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center">
        <br />

        <br />

        <br />

        <br />

        <h3>Login</h3>
        <br />
         <asp:Label id="usuarioLabel" Text="Usuario" runat="server" />
        <asp:TextBox ID="usuarioTxt" runat="server" ></asp:TextBox>
        <br />
        <br />

        <asp:Label id="Label2" Text="Clave" runat="server" />
        <asp:TextBox ID="ClaveTxt" runat="server" ></asp:TextBox>

        <br />
        <br />

        <asp:Button ID="Ingresar" runat="server" Text="Ingresar" OnClick="Button1_Click"/>
    </div>
    </form>
</body>
</html>
