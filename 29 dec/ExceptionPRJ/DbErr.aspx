<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DbErr.aspx.cs" Inherits="ExceptionPRJ.DbErr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br /><br />
            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
