<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productselectionprj.aspx.cs" Inherits="web_project.Productselectionprj" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Selection</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:DropDownList ID="DropDownListid" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProduct_selectedindexchanged">
            </asp:DropDownList>
            <br /><br />

            <br />
            <asp:Image ID="Imageid" runat="server" width="200px" Height="200px"/>

            <br />
            <br />
            <asp:Button ID="btnPrice" runat="server" Text="Get Price" OnClick="btnPrice_Click" />

            <br />
            <br />
            <asp:Label ID="lblprice" runat="server" Text="" Font-Bold="true" Font-Size="Large"></asp:Label>

        </div>
    </form>
</body>
</html>
