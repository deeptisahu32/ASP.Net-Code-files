<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RedirectVSResponse.aspx.cs" Inherits="Navigation_prj.RedirectVSResponse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name&nbsp; :&nbsp;&nbsp;&nbsp;  <asp:TextBox ID="Txtname" runat="server"></asp:TextBox>
            <br />
            <br />
            Email :&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Txtmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="GetBtn" runat="server" Text="Get Resource" OnClick="GetBtn_Click" />
        </div>
    </form>
</body>
</html>
