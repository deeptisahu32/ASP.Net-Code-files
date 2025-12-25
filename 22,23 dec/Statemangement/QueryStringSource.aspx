<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStringSource.aspx.cs" Inherits="Statemangement.QueryStringSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <asp:Label ID="lbluser" runat="server" Text="UserName"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblpass" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnStore" runat="server" Text="Store Data" OnClick="BtnStore_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnRedirect" runat="server" Text="RedirectData" OnClick="BtnRedirect_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblmsg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
