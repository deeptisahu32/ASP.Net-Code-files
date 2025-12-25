<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstSession.aspx.cs" Inherits="Statemangement.FirstSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt1" runat="server" Text=""></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="txt2" runat="server" Text=""></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnsesion" runat="server" Text="Session Store" OnClick="btnsesion_Click" />
        </div>
    </form>
</body>
</html>
