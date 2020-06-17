<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="Laboratorio2.Pagina1" %>

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
         <br />
         <asp:Label id="usuarioLabel" Text="" runat="server" />
        <br />
        <br />
        <asp:TextBox ID="numTxt" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Calcular" OnClick="Button1_Click"/>
        <br />
        <br />
        <asp:TextBox ID="resTxt" runat="server" ></asp:TextBox>
        <br />
        
    </div>
    </form>
</body>
</html>
