<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStringDestination.aspx.cs" Inherits="Statemangement.QueryStringDestination" %>

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
            <asp:Label ID="lblpass" runat="server" Text=""></asp:Label>

            <br />
            <br />
            <asp:Button ID="BtnGet" runat="server" Text="Get Data" OnClick="BtnGet_Click" />

        </div>
    </form>
</body>
</html>
