<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="WebApplication1.Form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style ="display:flex; justify-content:center;align-items:center">

            <asp:TextBox ID="TextBox1" runat="server" BackColor="LightBlue" BorderColor="Blue" BorderWidth="2px"></asp:TextBox>
       </div>

        <br/>
        <br />

        <div style ="display:flex; justify-content:center;align-items:center">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" BackColor="Gray" BorderColor="Black"/>
        </div>

    </form>
</body>
</html>
