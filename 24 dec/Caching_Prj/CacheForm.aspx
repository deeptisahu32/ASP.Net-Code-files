<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheForm.aspx.cs" Inherits="Caching_Prj.CacheForm" %>
<%--<%@ OutputCache Duration ="30" VaryByParam="None" Location="Client" %>--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Select a Product   : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DDL" runat="server" OnSelectedIndexChanged="DDL_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Text="All" Value="All"></asp:ListItem>
            <asp:ListItem Text="Laptop" Value="Laptop"></asp:ListItem>
            <asp:ListItem Text="Desktop" Value="Desktop"></asp:ListItem>
            <asp:ListItem Text="IPhone" Value="IPhone"></asp:ListItem>
            <asp:ListItem Text="LED TV" Value="LED TV"></asp:ListItem>

        </asp:DropDownList>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <br />

        Server Time :
        <br />
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
        <br />
        <br />

        Client Time :
        <br /><br />
        <script>
            document.write(Date());
        </script>

    </form>
</body>
</html>
