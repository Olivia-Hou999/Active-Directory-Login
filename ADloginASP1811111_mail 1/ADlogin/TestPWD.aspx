<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPWD.aspx.cs" Inherits="ADlogin.TestPWD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="pwd" runat="server"></asp:TextBox>
        <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="ok" runat="server" Text="Button" OnClick="ok_Click" />
    </div>
    </form>
</body>
</html>
