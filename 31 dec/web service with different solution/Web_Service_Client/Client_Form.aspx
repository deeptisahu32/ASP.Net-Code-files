<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Client_Form.aspx.cs" Inherits="Web_Service_Client.Client_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    Enter User Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
    <br />
    <br />
    Enter Decimal Number  :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:TextBox ID="txtfnum" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Btnhello" runat="server" Text="Hello Word" OnClick="Btnhello_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnsaygreeting" runat="server" Text="say greeting" OnClick="btnsaygreeting_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnsq" runat="server" Text="for square" OnClick="btnsq_Click" />

    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>

</div>
    </form>
</body>
</html>
