<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataForm2.aspx.cs" Inherits="DataProject.DataForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="EmpID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="EmpID" HeaderText="EmpID" InsertVisible="False" ReadOnly="True" SortExpression="EmpID" />
                    <asp:BoundField DataField="EmpName" HeaderText="EmpName" SortExpression="EmpName" />
                    <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
                    <asp:BoundField DataField="DateOfJoin" HeaderText="DateOfJoin" SortExpression="DateOfJoin" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbo_dbConnectionString %>" ProviderName="<%$ ConnectionStrings:dbo_dbConnectionString.ProviderName %>" SelectCommand="SELECT [EmpID], [EmpName], [Salary], [DateOfJoin] FROM [Employee]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
