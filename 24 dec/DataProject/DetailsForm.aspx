<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsForm.aspx.cs" Inherits="DataProject.DetailsForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="DeptID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="DeptID" HeaderText="DeptID" ReadOnly="True" SortExpression="DeptID" />
                    <asp:BoundField DataField="DeptName" HeaderText="DeptName" SortExpression="DeptName" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbo_dbConnectionString5 %>" SelectCommand="SELECT * FROM [Department]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:dbo_dbConnectionString4 %>" SelectCommand="SELECT * FROM [Department] WHERE ([DeptID] = @DeptID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="DeptID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="DeptID" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
                <Fields>
                    <asp:BoundField DataField="DeptID" HeaderText="DeptID" ReadOnly="True" SortExpression="DeptID" />
                    <asp:BoundField DataField="DeptName" HeaderText="DeptName" SortExpression="DeptName" />
                </Fields>
            </asp:DetailsView>
        </div>
    </form>
</body>
</html>
