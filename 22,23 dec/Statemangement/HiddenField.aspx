<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenField.aspx.cs" Inherits="Statemangement.HiddenField" %>

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
                        <asp:HiddenField ID="HiddenField1" runat="server" />
            <br />
            <br />
            <asp:Label ID="lblpass" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:HiddenField ID="HiddenField2" runat="server" />
            <br />
            <br />
            <asp:Button ID="BtnStore" runat="server" OnClick="BtnStore_Click" Text="Store Data" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="LoadBtn" runat="server" OnClick="LoadBtn_Click" Text="Load Data" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblmsg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
