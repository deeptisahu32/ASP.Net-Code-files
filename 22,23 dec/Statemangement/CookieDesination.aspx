<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieDesination.aspx.cs" Inherits="Statemangement.CookieDesination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblname" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lblpass" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnget" runat="server" Text="Get data" OnClick="btnget_Click" />
        </div>
    </form>
</body>
</html>
